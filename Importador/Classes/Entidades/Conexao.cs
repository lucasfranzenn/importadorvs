using Importador.Properties;
using System;

namespace Importador.Classes.Entidades
{
    public class Conexao
    {
        public Conexao(Constantes.Enums.Sistema sistema)
        {
            CodigoImplantacao = Configuracoes.Default.CodigoImplantacao;
            Empresa = Configuracoes.Default.Empresa;
            TipoConexao = Convert.ToBoolean(sistema);
            TipoBanco = 0;
            Host = "localhost";
            Porta = 3306;
            Usuario = "root";
            Senha = "vssql";
            Padrao = true;
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

        public Conexao(Constantes.Enums.TipoBanco tipoBanco)
        {
            CodigoImplantacao = Configuracoes.Default.CodigoImplantacao;
            Empresa = Configuracoes.Default.Empresa;
            TipoConexao = true;
            TipoBanco = (int)tipoBanco;
            switch (tipoBanco)
            {
                case Constantes.Enums.TipoBanco.Firebird:
                    Host = "localhost";
                    Porta = 3050;
                    Usuario = "SYSDBA";
                    Senha = "masterkey";
                    Banco = "C:\\banco.fdb;Charset=UTF8";
                    break;
                case Constantes.Enums.TipoBanco.PostgreSQL:
                    Host = "LOCALHOST";
                    Porta = 5432;
                    Usuario = "postgres";
                    Senha = "vssql";
                    Banco = $"imp_{CodigoImplantacao}";
                    break;
                case Constantes.Enums.TipoBanco.SQLServer:
                    Host = "localhost";
                    Porta = 1423;
                    Usuario = "SA";
                    Senha = "";
                    Banco = $"imp_{CodigoImplantacao}";
                    break;
                case Constantes.Enums.TipoBanco.Access:
                    Host = "ACCESS";
                    Porta = 1111;
                    Usuario = $"{Environment.MachineName}";
                    Senha = "";
                    Banco = $"C:\\banco.mdb";
                    break;
                default:
                    Host = "localhost";
                    Porta = 3306;
                    Usuario = $"root";
                    Senha = "vssql";
                    Banco = $"imp_{CodigoImplantacao}";
                    break;
            }
        }

        public int? CodigoConexao { get; set; } = null;
        public string CodigoImplantacao { get; set; }
        public string Empresa { get;set; }
        public bool TipoConexao { get; set; }
        public int TipoBanco { get; set; }
        public string Host { get; set; }
        public int Porta { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string Banco { get; set; }
        public bool Padrao { get; set; } = false;
    }
}
