using DevExpress.XtraEditors;
using Importador.Classes;
using Importador.Classes.Entidades;
using Importador.Conexao;
using Importador.UserControls.Componentes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Importador.Classes.Constantes;

namespace Importador.UserControls.BaseControls
{
    public partial class UCBaseImportacao : UCBase
    {
        public UCBaseImportacao()
        {
            InitializeComponent();
        }

        private void btnResetarSql_Click(object sender, EventArgs e)
        {
            txtSqlImportacao.Text = Utils.GetSqlPadrao(MyC.Tabela.ToString());
        }

        protected async void btnImportar_Click(object sender, EventArgs e)
        {
            if (GerenciadorImportacao.VerificarSQL(txtSqlImportacao.Text) is string erro)
            {
                XtraMessageBox.Show(erro, "..::Importador::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblHorarioInicioImportacao.Text = DateTime.Now.ToString();

            List<CheckEdit> listaParametros = gcParametros.Controls.OfType<CheckEdit>().ToList();

            Utils.AtualizaSQLImportacao(txtSqlImportacao.Text, MyC.Tabela.ToString());

            ConexaoBancoImportador.AtualizaParametros(MyC, listaParametros);

            Enabled = false;

            await Task.Run(() => GerenciadorImportacao.Importar(txtSqlImportacao.Text, pbImportacao, MyC.Tabela.ToString(), listaParametros.Where(p => p.Checked).ToList()));

            lblHorarioFimImportacao.Text = DateTime.Now.ToString();

            Utils.MostrarNotificacao($"Importação dos {MyC.Tabela.ToString()} finalizada", "Importação");

            Enabled = true;
        }

        protected void UCBaseImportacao_Load(object sender, EventArgs e)
        {
            //Validação necessária para não bugar o designer do Visual Studio
            if (DesignMode) return;

            if (!ConexaoManager.ConexoesAbertas())
            {
                Enabled = false;
                return;
            }

            Parametro param;

            txtSqlImportacao.Text = ConexaoBancoImportador.GetSql(MyC.Tabela.ToString());

            foreach (var parametro in gcParametros.Controls.OfType<CheckEdit>().ToList())
            {
                param = ConexaoBancoImportador.GetEntidade<Parametro>(Enums.TabelaBancoLocal.parametros, $"Tela = '{MyC.Tabela}' and NomeParametro = '{parametro.Name}'");

                if (param is null)
                {
                    ConexaoBancoImportador.InserirRegistro(new Parametro(MyC, parametro), Enums.TabelaBancoLocal.parametros);
                    param = ConexaoBancoImportador.GetEntidade<Parametro>(Enums.TabelaBancoLocal.parametros, $"Tela = '{MyC.Tabela}' and NomeParametro = '{parametro.Name}'");
                }

                parametro.Checked = param.Valor;
            }
        }

        protected void AlternarVisibilidade()
        {
            Controls.OfType<Control>().ToList().ForEach(c => c.Enabled = !c.Enabled);
        }

        protected void btnObservacao_Click(object sender, EventArgs e)
        {
            var obsObservacao = new Observacao(btnObservacao.Location, Size, MyC.Tabela.ToString());

            AlternarVisibilidade();
            Controls.Add(obsObservacao);

            obsObservacao.BringToFront();

            obsObservacao.Disposed += (sender, args) => AlternarVisibilidade();
            SizeChanged -= (sender, args) => obsObservacao.AtualizaProporcoes(btnObservacao.Location, Size);
            SizeChanged += (sender, args) => obsObservacao.AtualizaProporcoes(btnObservacao.Location, Size);
        }

        private void btnVerificarSintaxeSQL_Click(object sender, EventArgs e)
        {
            if (GerenciadorImportacao.VerificarSQL(txtSqlImportacao.Text) is string erro)
            {
                XtraMessageBox.Show(erro, "..::Importador::..", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            XtraMessageBox.Show("Comando SQL executado sem erros!", "..::Importador::..", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
