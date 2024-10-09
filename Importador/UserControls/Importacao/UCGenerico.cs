using DevExpress.XtraEditors;
using Importador.Classes;
using Importador.Classes.Entidades;
using Importador.Conexao;
using Importador.Properties;
using Importador.UserControls.BaseControls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using static Importador.Classes.Constantes;

namespace Importador.UserControls.Importacao
{
    public partial class UCGenerico : UCBaseImportacao
    {
        public UCGenerico()
        {
            InitializeComponent();

            btnImportar.Click -= btnImportar_Click;
            Load -= UCBaseImportacao_Load;
        }

        private void cbTabelas_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus && !string.IsNullOrWhiteSpace(cbTabelas.Text) && !cbTabelas.Properties.Items.Contains(cbTabelas.Text))
            {
                cbTabelas.Properties.Items.Add(cbTabelas.Text);
            }
        }

        private void AlterarSql()
        {
            txtSqlImportacao.Text = ConexaoBancoImportador.GetSql(cbTabelas.SelectedText);
        }

        private void cbTabelas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cbTabelas.Properties.Items.Contains(cbTabelas.Text))
            {
                return;
            }

            txtSqlImportacao.Text = ConexaoBancoImportador.GetSql(cbTabelas.Text);
        }

        private async void btnImportar_Click_1(object sender, EventArgs e)
        {
            lblHorarioInicioImportacao.Text = DateTime.Now.ToString();

            List<CheckEdit> listaParametros = gcParametros.Controls.OfType<CheckEdit>().ToList();

            Utils.AtualizaSQLImportacao(txtSqlImportacao.Text, cbTabelas.Text);

            ConexaoBancoImportador.AtualizaParametros(MyC, listaParametros);

            Enabled = false;

            await Task.Run(() => GerenciadorImportacao.Importar(txtSqlImportacao.Text, ref pbImportacao, cbTabelas.Text, listaParametros.Where(p => p.Checked).ToList()));

            lblHorarioFimImportacao.Text = DateTime.Now.ToString();

            Utils.MostrarNotificacao($"Importação dos {MyC.Tabela.ToString()} finalizada", "Importação");

            Enabled = true;
        }

        private void UCGenerico_Load(object sender, EventArgs e)
        {
            //Validação necessária para não bugar o designer do Visual Studio
            if (DesignMode) return;

            if (!ConexaoManager.ConexoesAbertas())
            {
                XtraMessageBox.Show("Conexões não foram estabelecidas!\nConfigure-as corretamente", "..::Importador::..");
                Enabled = false;
                return;
            }

            var cmd = ConexaoBancoImportador.instancia.conexao.CreateCommand();
            cmd.CommandText = $"select tabelaconsulta from consultas where codigoimplantacao = {Configuracoes.Default.CodigoImplantacao} and tabelaconsulta not in ('{string.Join("', '", (Enums.TabelaMyCommerce[])Enum.GetValues(typeof(Enums.TabelaMyCommerce)))}')";

            using (var reader = cmd.ExecuteReader())
                while (reader.Read())
                    cbTabelas.Properties.Items.Add(reader["tabelaconsulta"]);

            Parametro param;

            if (cbTabelas.Properties.Items.Count > 0) cbTabelas.SelectedIndex = 0;

            txtSqlImportacao.Text = ConexaoBancoImportador.GetSql(cbTabelas.Text);

            foreach (var parametro in gcParametros.Controls.OfType<CheckEdit>().ToList())
            {
                try
                {
                    param = ConexaoBancoImportador.GetEntidade<Parametro>(Enums.TabelaBancoLocal.parametros, $"Tela = '{MyC.Tabela}' and NomeParametro = '{parametro.Name}'");
                }
                catch (Exception)
                {
                    ConexaoBancoImportador.InserirRegistro(new Parametro(MyC, parametro), Enums.TabelaBancoLocal.parametros);
                }
                finally
                {
                    param = ConexaoBancoImportador.GetEntidade<Parametro>(Enums.TabelaBancoLocal.parametros, $"Tela = '{MyC.Tabela}' and NomeParametro = '{parametro.Name}'");

                    parametro.Checked = param.Valor;
                }
            }
        }
    }
}
