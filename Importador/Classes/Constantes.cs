using DevExpress.CodeParser;
using Importador.Classes.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importador.Classes
{
    public static class Constantes
    {
        public static class Caminhos
        {
            public const string ConsultasJson = @"Configuracao\consultas.json";
            public const string SkinTxt = @"Configuracao\skin.txt";
        }
        
        public static class Enums
        {
            public enum Sistema
            {
                MyCommerce,
                Importacao
            }

            public enum TabelaMyCommerce
            {
                clientes,
                produtos,
                estoque,
                contasapagar,
                contasareceber,
                produto_st,
                servicos
            }

            public enum TabelaBancoLocal
            {
                implantacoes,
                conexoes,
                consultas
            }

            public enum Dml
            {
                Insert = 0,
                Update,
                Select
            }

            public enum TipoBanco
            {
                MySQL = 0,
                Firebird,
                PostgreSQL,
                SQLServer,
                Access,
                ConnectionString
            }
        }

        public static class Mapeamento
        {
            public static readonly Dictionary<string, List<string>> TabelasTruncatePorTabela = new()
            {
                {"clientes", new List<string> { "clientes" } },
                {"estoque", new List<string> { "produtosestoque", "acertoestoque", "auditoriaestoque"} }
            };

            public static readonly Dictionary<string, List<Func<object, object>>> FuncoesFormatadorasPorColuna = new()
            {
                {"ncm",  new List<Func<object, object>> { Formatadores.FormataNCM } },
                {"cpf", new List<Func<object, object>> { Formatadores.FormataCPF  } },
                {"cnpj", new List<Func<object, object>> { Formatadores.FormataCNPJ  } },
                {"cep", new List<Func<object, object>> { Formatadores.FormataCEP  } },
                {"telefone1", new List<Func<object, object>> { Formatadores.FormataTelefone  } },
                {"telefone2", new List<Func<object, object>> { Formatadores.FormataTelefone  } },
                {"fax", new List<Func<object, object>> { Formatadores.FormataTelefone  } }
            };
        }
    }

}
