using DevExpress.XtraEditors;
using Importador.Classes;
using Importador.Classes.Entidades;
using Importador.Conexao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
                XtraMessageBox.Show("Conexões não foram estabelecidas!\nConfigure-as corretamente", "..::Importador::..");
                Enabled = false;
                return;
            }

            Parametro param;

            txtSqlImportacao.Text = ConexaoBancoImportador.GetSql(MyC.Tabela.ToString());

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
