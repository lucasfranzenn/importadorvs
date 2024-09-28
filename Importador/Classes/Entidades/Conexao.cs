using Importador.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importador.Classes.Entidades
{
    public class Conexao
    {
        public Conexao(Constantes.Enums.Sistema sistema)
        {
            CodigoImplantacao = Configuracoes.Default.CodigoImplantacao;
            TipoConexao = Convert.ToBoolean(sistema);
            TipoBanco = 0;
            Host = "localhost";
            Porta = 3306;
            Usuario = "root";
            Senha = "vssql";
            if (sistema == Constantes.Enums.Sistema.MyCommerce) 
            {
                Banco = $"imp_{CodigoImplantacao}";
            }
            else
            {
                Banco = $"imp_{CodigoImplantacao}_origem";
            }
        }

        public Conexao()
        {

        }

        public int? CodigoConexao { get; set; } = null;
        public string CodigoImplantacao { get; set; }
        public bool TipoConexao { get; set; }
        public int TipoBanco { get; set; }
        public string Host { get; set; }
        public int Porta { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string Banco { get; set; }
    }
}
