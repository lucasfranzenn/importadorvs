using DevExpress.Mvvm.Native;
using DevExpress.PivotGrid.QueryMode;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using Importador.Classes;
using Importador.Conexao;
using Importador.Properties;
using Importador.UserControls.Componentes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Importador.UserControls.Utilitarios
{
    public partial class UCScriptSQL : BaseControls.UCBase
    {
        private string _tabela = "";

        public UCScriptSQL()
        {
            InitializeComponent();
        }

        private async void btnExecutarTextoSelecionado_Click(object sender, EventArgs e)
        {
            Enabled = false;
            tcDataSet.TabPages.Clear();
            txtLog.Text = "";
            int i = 1;

            IDbCommand cmd = cbConexao.SelectedIndex == 0 ? ConexaoManager.instancia.GetConexaoMyCommerce().CriarComando() : cbConexao.SelectedIndex == 1 ? ConexaoManager.instancia.GetConexaoImportacao().CriarComando() : ConexaoBancoImportador.instancia.conexao.CriarComando();
            DataTable dt = new DataTable();

            string[] queries = string.IsNullOrWhiteSpace(txtScriptSQL.SelectedText) ? GetConsultaAtual() : txtScriptSQL.SelectedText.Split(';');
            queries = queries.Where(q => q.Trim().Length > 3).ToArray();

            foreach (string query in queries)
            {
                if (Utils.GetDML(query) is string dml && !string.IsNullOrEmpty(dml))
                {
                    try
                    {
                        cmd.CommandText = query;
                        txtLog.AppendLine($"{dml} executado com sucesso, {cmd.ExecuteNonQuery()} registro(s) afetado(s).");
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Erro SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }
                }
                else
                {
                    cmd.CommandText = query;

                    dt = new DataTable();
                    XtraTabPage tp = new();

                    try
                    {
                        using IDataReader reader = cmd.ExecuteReader(CommandBehavior.SchemaOnly);
                        dt.Load(reader, LoadOption.OverwriteChanges);
                        tp.Text = string.IsNullOrEmpty(dt.TableName) ? $"{cmd.Connection.Database} - Resultados {i}" : cmd.Connection.Database + "." + dt.TableName;
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Erro SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }
                    tp.ShowCloseButton = DevExpress.Utils.DefaultBoolean.True;
                    tcDataSet.ClosePageButtonShowMode = ClosePageButtonShowMode.InAllTabPageHeaders;
                    tcDataSet.CloseButtonClick += (sender, e) => { tcDataSet.TabPages.Remove(((e as ClosePageButtonEventArgs)?.Page as XtraTabPage)!); };

                    await Task.Run(() => tp.Controls.Add(new GridDataSet(cmd)));
                    tcDataSet.TabPages.Add(tp);

                    txtLog.AppendLine($"Consulta em {tp.Text} executada com sucesso.");
                    i++;
                }
            }

            Utils.AtualizaSQLImportacao(txtScriptSQL.Text, _tabela);
            Enabled=true;
        }

        private string[] GetConsultaAtual()
        {
            int indexSelecionado = txtScriptSQL.SelectionStart;

            int start = txtScriptSQL.Text.LastIndexOf(";", indexSelecionado) > txtScriptSQL.Text.LastIndexOf("\r\n", indexSelecionado) ? txtScriptSQL.Text.LastIndexOf(";", indexSelecionado): txtScriptSQL.Text.LastIndexOf("\r\n", indexSelecionado);
            start = (start == -1) ? 0 : start + 1;

            int end = (txtScriptSQL.Text.IndexOf(';', indexSelecionado) > 0) && txtScriptSQL.Text.IndexOf(';', indexSelecionado) > txtScriptSQL.Text.IndexOf("\r\n", indexSelecionado) ? txtScriptSQL.Text.IndexOf(';', indexSelecionado) : txtScriptSQL.Text.IndexOf("\r\n", indexSelecionado);
            end = (end == -1) ? txtScriptSQL.Text.Length : end + 1;

            if (start==end) start = txtScriptSQL.Text.LastIndexOf(";", start-2) > txtScriptSQL.Text.LastIndexOf("\r\n", start-2) ? txtScriptSQL.Text.LastIndexOf(";", start-2)+1 : txtScriptSQL.Text.LastIndexOf("\r\n", start-2)+1;

            return [txtScriptSQL.Text.Substring(start, end - start)];
        }

        private void UCScriptSQL_Load(object sender, EventArgs e)
        {
            if (!ConexaoManager.ConexoesAbertas())
            {
                Enabled = false;
                return;
            }
            _tabela = $"{MyC.Tabela.ToString()}-{cbConexao.Text}";
            txtScriptSQL.Text = ConexaoBancoImportador.GetSql(_tabela);

            if (ConexaoBancoImportador.ExisteObservacao(MyC.Tabela.ToString())) { btnObservacao.ImageOptions.Image = Resources.newtask_16x16; }
        }

        private void txtScriptSQL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F9)
            {
                btnExecutarTextoSelecionado_Click(sender, e);
            }
        }

        private void cbConexao_SelectedValueChanged(object sender, EventArgs e)
        {
            _tabela = $"{MyC.Tabela.ToString()}-{cbConexao.Text}";
            txtScriptSQL.Text = ConexaoBancoImportador.GetSql(_tabela);
        }

        private void btnObservacao_Click(object sender, EventArgs e)
        {
            var obsObservacao = new Observacao(btnObservacao.Location, Size, MyC.Tabela.ToString());

            AlternarVisibilidade();
            Controls.Add(obsObservacao);

            obsObservacao.BringToFront();

            obsObservacao.Disposed += (sender, args) => AlternarVisibilidade();
            SizeChanged -= (sender, args) => obsObservacao.AtualizaProporcoes(btnObservacao.Location, Size);
            SizeChanged += (sender, args) => obsObservacao.AtualizaProporcoes(btnObservacao.Location, Size);
        }

        private void AlternarVisibilidade()
        {
            Controls.OfType<Control>().ToList().ForEach(c => c.Enabled = !c.Enabled);
        }
    }
}
