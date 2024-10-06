using DevExpress.XtraEditors;
using Importador.Classes;
using Importador.Conexao;
using System.Threading.Tasks;
using System;
using System.Linq;
using System.Windows.Controls;
using System.Collections.Generic;
using System.Windows.Forms;
using Importador.Classes.Entidades;
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

        private async void btnImportar_Click(object sender, EventArgs e)
        {
            new Task(() => lblHorarioInicioImportacao.Text = DateTime.Now.ToString()).Start();

            List<CheckEdit> listaParametros = gcParametros.Controls.OfType<CheckEdit>().ToList();

            Utils.AtualizaSQLImportacao(txtSqlImportacao.Text, MyC.Tabela);

            ConexaoBancoImportador.AtualizaParametros(MyC, listaParametros);

            Enabled = false;

            await Task.Run(() => GerenciadorImportacao.Importar(txtSqlImportacao.Text, ref pbImportacao, MyC.Tabela, listaParametros.Where(p => p.Checked).ToList()));

            lblHorarioFimImportacao.Text = DateTime.Now.ToString();

            Utils.MostrarNotificacao($"Importação dos {MyC.Tabela.ToString()} finalizada", "Importação");

            Enabled = true;
        }

        private void UCBaseImportacao_Load(object sender, EventArgs e)
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

            txtSqlImportacao.Text = ConexaoBancoImportador.GetSql(MyC.Tabela);

            foreach (var parametro in gcParametros.Controls.OfType<CheckEdit>().ToList())
            {
                try
                {
                    param = ConexaoBancoImportador.GetEntidade<Parametro>(Enums.TabelaBancoLocal.parametros, $"Tela = '{MyC.Tela}' and NomeParametro = '{parametro.Name}'");
                }
                catch (Exception)
                {
                    ConexaoBancoImportador.InserirRegistro(new Parametro(MyC, parametro), Enums.TabelaBancoLocal.parametros);
                }
                finally
                {
                    param = ConexaoBancoImportador.GetEntidade<Parametro>(Enums.TabelaBancoLocal.parametros, $"Tela = '{MyC.Tela}' and NomeParametro = '{parametro.Name}'");

                    parametro.Checked = param.Valor;
                }
            }
        }
    }
}
