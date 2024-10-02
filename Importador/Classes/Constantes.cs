using DevExpress.CodeParser;
using DevExpress.XtraEditors;
using Importador.Classes.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importador.Classes
{
    public static class Constantes
    {
        public static class Caminhos
        {
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
                {"produtos", new List<string> { "produtos"} },
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

            public static readonly Dictionary<string, Func<object, object>> FuncoesPreImportacaoPorParametro = new()
            {
                {"cbCriarConsumidorFinal",  GerenciadorImportacao.CriarConsumidorFinal}
            };

            public static readonly Dictionary<string, Func<IDataReader, bool>> FuncoesDuranteImportacaoPorParametro = new()
            {
                {"cbValidarDocumento",  GerenciadorImportacao.ValidarExistenciaDocumento}
            };

            public static readonly Dictionary<string, Func<object, object>> FuncoesPosImportacaoPorParametro = new()
            {
                  {"cbCriarUnidades",  GerenciadorImportacao.CriarUnidades}
            };

            public static readonly Dictionary<Enums.TabelaMyCommerce, List<string>> UpdatesPorTabela = new()
            {
                { Enums.TabelaMyCommerce.clientes, new List<string>
                    { "UPDATE CLIENTES SET STATUS = 'ATIVA' WHERE STATUS = '' OR STATUS IS NULL",
                        "UPDATE CLIENTES SET STAT = 'f' WHERE STAT = '' OR STAT IS NULL",
                        "UPDATE CLIENTES SET TIPO = 'C' WHERE TIPO = '' OR TIPO IS NULL",
                        "UPDATE CLIENTES SET ATIVO = -1 WHERE ATIVO = 0 OR ATIVO IS NULL",
                        "UPDATE CLIENTES SET RAZAOSOCIAL = NOMEFANTASIA WHERE RAZAOSOCIAL = ''",
                        "UPDATE clientes set FisicaJuridica ='F', ConsFinal =1 WHERE cpf  is not null and FisicaJuridica is null",
                        "UPDATE clientes set FisicaJuridica ='J' WHERE cnpj  is not null and FisicaJuridica is null",
                        "UPDATE clientes SET datacadastro =  CURDATE() ; ",
                        "ALTER TABLE `clientes` CHANGE COLUMN `Usuario` `Usuario` VARCHAR(45) NULL COLLATE 'latin1_swedish_ci', CHANGE COLUMN `Terminal` `Terminal` VARCHAR(45) NULL COLLATE 'latin1_swedish_ci';",
                        "UPDATE CLIENTES SET USUARIO = 'MASTER', Terminal='SERVER';",
                        "UPDATE clientes cl LEFT JOIN cidades ci ON cl.Cidade = ci.Cidade AND cl.UF = ci.UF SET cl.CodigoCidadeIbge = ci.Codigo WHERE cl.CodigoCidadeIbge IS NULL;",
                        "update clientes set consfinal = 1, Contribuinte_Icms = 0 where fisicajuridica = 'F';",
                        "update clientes set consfinal = 0, Contribuinte_Icms = 1 where fisicajuridica = 'J' and ie != 'ISENTO';",
                        "update clientes set consfinal = 1, Contribuinte_Icms = 0 where fisicajuridica = 'J' and ie = 'ISENTO';",
                        "update clientes set consfinal = 1, Contribuinte_Icms = 0 where consfinal IS NULL;"
                    }
                },
                { Enums.TabelaMyCommerce.produtos, new List<string>
                    {
                        "UPDATE PRODUTOS SET Status =  'n' WHERE STATUS = '' OR STATUS IS NULL",
                        "UPDATE PRODUTOS SET ModalidadeControle =  'Normal' WHERE ModalidadeControle ='' OR ModalidadeControle IS NULL",
                        "UPDATE PRODUTOS SET Ativo = -1 WHERE ATIVO = '' OR ATIVO IS NULL",
                        "UPDATE PRODUTOS SET Terminal = 'SERVIDOR' WHERE Terminal = '' OR Terminal  IS NULL",
                        "UPDATE PRODUTOS SET Usuario  = 'MASTER' WHERE Usuario  = '' OR Usuario  IS NULL",
                        "UPDATE PRODUTOS SET TipoProduto = 'Revenda' WHERE  TipoProduto  = '' OR TipoProduto IS NULL",
                        "UPDATE PRODUTOS SET BaseCalculoICMS = 100 WHERE BaseCalculoICMS IS NULL",
                        "update produtos p SET  p.custofinal = ifnull(p.valorcusto,0) + ifnull(p.OutrosCustos,0), datacadastro = CURDATE()",
                        "update produtos set percentualt1=(vendat1/if(coalesce(valorcusto,0) = 0, 1, ValorCusto))*100-100",
                        "update produtos set percentualt1 = truncate(percentualt1,2)",
                        "update produtos set unvenda = 'UN' Where unvenda is null",
                        "update produtos set uncompra = unvenda Where uncompra is null",
                        "update produtos set EnviaBalanca = 1 Where unvenda = 'KG'",
                        "update produtos   set ncm = null where ncm ='.  . 0'"
                    }
                }
            };
        }
    }

}
