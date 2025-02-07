using Importador.Properties;
using Importador.UserControls.Importacao;
using System;
using System.Collections.Generic;
using System.Data;

namespace Importador.Classes
{
    public static class Constantes
    {
        public static class Caminhos
        {
            public const string exeMySqlDump = @"Configuracao\mysqldump";
            public const string exeRar = @"Configuracao\rar";
            public const string pdfImportacaoFiscal = @"Configuracao\importacao_fiscal.pdf";
            public const string relatorioGeral = @"Relatorios\Modelos\Geral.frx";
            public const string AuthJira = @"Configuracao\jira";
            public const string CredencialDrive = @"Configuracao\cred.json";
            public const string PastaPaiDrive = @"Configuracao\parentFolderId";
            public const string SqlPadroes = @"Configuracao\sql_padrao.json";
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
                produtosestoque,
                contasapagar,
                contasareceber,
                produtos_st,
                servicos,
                backup,
                secoes,
                grupos,
                subgrupos,
                fabricantes,
                generico,
                produtosfornecedor,
                produtosbarcode,
                produtos_kits,
                scriptsql
            }

            public enum TabelaBancoLocal
            {
                implantacoes,
                conexoes,
                consultas,
                parametros,
                observacoes,
                registrosdetempo
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

            public enum RegistrosDeTempoStatus
            {
                ContandoTempo = 0,
                MontandoSQL,
                ImportandoDados
            }

            public enum RelatorioGeralDataTable
            {
                Implantacoes,
                Minutagem
            }

            public enum ConsultasValidacoes
            {
                QtdCest, 
                RegCest,
                QtdNCM,
                RegNCM,
                QtdCodIBGE,
                RegCodIBGE,
                QtdCPFCNPJ,
                RegCPFCNPJ,
                QtdQuitadasPendentes,
                RegQuitadasPendentes,
                GetProdSN,
                GetProdLucro
            }
        }

        public static class Mapeamento
        {
            public static readonly Dictionary<Enums.ConsultasValidacoes, string> ConsultaPorValidacao = new()
            {
                {Enums.ConsultasValidacoes.QtdCest, $"select count(*) from produtos p where length(cest)<7" },
                {Enums.ConsultasValidacoes.RegCest, $"select CodigoImportacaoDados as CodigoSistemaAntigo, codigo as CodigoMyCommerce, Descricao, cest from produtos p where length(cest)<7" },
                {Enums.ConsultasValidacoes.QtdNCM, "select count(*) from produtos p where length(coalesce(ncm, 0))<10" },
                {Enums.ConsultasValidacoes.RegNCM, "select CodigoImportacaoDados as CodigoSistemaAntigo, codigo as CodigoMyCommerce, Descricao, ncm from produtos p where length(coalesce(ncm, 0))<10" },
                {Enums.ConsultasValidacoes.QtdCodIBGE, "select count(*) from clientes c left join cidades cid on c.CodigoCidadeIbge = cid.Codigo  where cid.Codigo is null" },
                {Enums.ConsultasValidacoes.RegCodIBGE, "select CodigoImportacaoDados as CodigoSistemaAntigo, c.codigo as CodigoMyCommerce, c.RazaoSocial, c.Cidade, c.UF , c.CodigoCidadeIbge from clientes c left join cidades cid on c.CodigoCidadeIbge = cid.Codigo  where cid.Codigo is null" },
                {Enums.ConsultasValidacoes.QtdCPFCNPJ, "select count(*) from (with duplicados as( \tselect cpf, cnpj, FisicaJuridica from clientes where fisicaJuridica = 'J' and cnpj <> '00.000.000/0000-00' group by CNPJ having count(*)>1  \tunion all  \tselect cpf, cnpj, FisicaJuridica from clientes where clientes.FisicaJuridica = 'F' and CPF <> '000000000-00' group by CPF having count(*)>1 ) select codigo, razaosocial, c.cpf, c.cnpj, c.FisicaJuridica from clientes c join duplicados d on if(d.fisicajuridica = 'F', c.cpf = d.cpf, c.cnpj = d.cnpj) order by cpf, cnpj) as tb" },
                {Enums.ConsultasValidacoes.RegCPFCNPJ, "with duplicados as( \tselect cpf, cnpj, FisicaJuridica from clientes where fisicaJuridica = 'J' and cnpj <> '00.000.000/0000-00' group by CNPJ having count(*)>1  \tunion all  \tselect cpf, cnpj, FisicaJuridica from clientes where clientes.FisicaJuridica = 'F' and CPF <> '000000000-00' group by CPF having count(*)>1 ) select CodigoImportacaoDados as CodigoSistemaAntigo, codigo as CodigoMyCommerce, razaosocial, c.cpf, c.cnpj, c.FisicaJuridica from clientes c join duplicados d on if(d.fisicajuridica = 'F', c.cpf = d.cpf, c.cnpj = d.cnpj) order by cpf, cnpj" },
                {Enums.ConsultasValidacoes.QtdQuitadasPendentes, "select count(sequencia) from (select sequencia from contasareceber c where Quitado = 1 and ValorPendente <> 0 union all select sequencia from contasapagar c where Quitado = 1 and ValorPendente <> 0) as tb" },
                {Enums.ConsultasValidacoes.RegQuitadasPendentes, "select sequencia, codigo, razaosocial, ndocumento, valor, valorpago, valorpendente, quitado, dataquitacao, vencimento from contasareceber c where Quitado = 1 and ValorPendente <> 0 union all select sequencia, codigo, razaosocial, ndocumento, valor, valorpago, valorpendente, quitado, dataquitacao, vencimento from contasapagar c where Quitado = 1 and ValorPendente <> 0" },
                {Enums.ConsultasValidacoes.GetProdSN, "select CodigoImportacaoDados, Codigo, Descricao, p.NCM, p.Cest, (tc.ncm is not null) as ExisteCest, Cst_Pis_Simples as pis, Cst_Cofins_Simples as cofins, Cst_IPI_Simples as cstipi , IPI, CodigoEnqIPI, CST_Simples as cst, BaseCalculoICMS, AliquotaICMS, Aliq_Pis_Simples as aliqpis, Aliq_Cofins_Simples as aliqcofins, CodNaturezaPis from produtos p left join (select distinct ncm from tabela_cest) tc on replace(p.NCM, '.', '') = tc.NCM" },
                {Enums.ConsultasValidacoes.GetProdLucro, "select CodigoImportacaoDados, Codigo, Descricao, p.NCM, p.Cest, (tc.ncm is not null) as ExisteCest, CST_PIS as pis , CST_COFINS as cofins, CSt_IPI as cstipi, IPI, CodigoEnqIPI, CodigoCF as cst , BaseCalculoICMS, AliquotaICMS, Aliq_PIS as aliqpis, Aliq_COFINS as aliqcofins, CodNaturezaPis from produtos p left join (select distinct ncm from tabela_cest) tc on replace(p.NCM, '.', '') = tc.NCM\r\n" },
            };

            public static readonly Dictionary<Enums.RelatorioGeralDataTable, string> ConsultaPorDataTable = new()
            {
                {Enums.RelatorioGeralDataTable.Minutagem,  $"select EMPRESA, tela, strftime('%d/%m/%Y %H:%M', DataHoraInicio) AS Inicio,  strftime('%d/%m/%Y %H:%M', DataHoraFim) AS Término, CASE status WHEN 0 THEN '0 - Contando Tempo' WHEN 1 THEN '1 - Montando SQL' WHEN 2 THEN '2 - Importando Dados' ELSE 'Não identificado' END AS Status, printf('%02d:%02d:%02d',(julianday(DataHoraFim) - julianday(DataHoraInicio)) * 24,((julianday(DataHoraFim) - julianday(DataHoraInicio)) * 24 * 60) % 60,round(((julianday(datahorafim) - julianday(datahorainicio)) * 24 * 60 * 60)) % 60 ) as Minutagem, Observacao from registrosdetempo"},
                {Enums.RelatorioGeralDataTable.Implantacoes, $"SELECT codigoimplantacao, empresa, RazaoSocialCliente, SistemaAntigo, BancoDeDados, RegimeEmpresa, NomeResponsavel,Workflow FROM Implantacoes i" }
            };

            public static readonly Dictionary<string, List<string>> TabelasTruncatePorTabela = new()
            {
                {"clientes", new List<string> { "clientes" } },
                {"produtos", new List<string> { "produtos", "unidades", "tabelas_preco_produto", "tabelas"} },
                {"contasapagar", new List<string> { "contasapagar" } },
                {"contasareceber", new List<string> { "contasareceber" } },
                {"produtosestoque", new List<string> { "produtosestoque", "acertoestoque", "auditoriaestoque"} }
            };

            public static readonly Dictionary<string, List<Func<object, object>>> FuncoesFormatadorasPorColuna = new()
            {
                {"ncm",  new List<Func<object, object>> { Formatadores.FormataNCM } },
                {"cpf", new List<Func<object, object>> { Formatadores.FormataCPF  } },
                {"cnpj", new List<Func<object, object>> { Formatadores.FormataCNPJ  } },
                {"cep", new List<Func<object, object>> { Formatadores.FormataCEP  } },
                {"telefone1", new List<Func<object, object>> { Formatadores.FormataTelefone  } },
                {"telefone2", new List<Func<object, object>> { Formatadores.FormataTelefone  } },
                {"fax", new List<Func<object, object>> { Formatadores.FormataTelefone  } },
                {"vencimento", new List<Func<object, object>> {Formatadores.FormataData} },
                {"vencimentooriginal", new List<Func<object, object>> {Formatadores.FormataData} },
                {"datalancamento", new List<Func<object, object>> {Formatadores.FormataData} }
            };

            public static readonly Dictionary<string, Func<object, object>> FuncoesPreImportacaoPorParametro = new()
            {
                {"cbAlterarTabela", GerenciadorImportacao.AlterarTabelaClientes },
                {"cbCriarConsumidorFinal",  GerenciadorImportacao.CriarConsumidorFinal}
            };

            public static readonly Dictionary<string, Func<IDataReader, bool>> FuncoesDuranteImportacaoPorParametro = new()
            {
                {"cbValidarDocumento",  GerenciadorImportacao.ValidarExistenciaDocumento},
                {"cbValidarCodBarras",  GerenciadorImportacao.ValidarExistenciaCodBarras},
                {"cbVincularPorReferencia", GerenciadorImportacao.VincularProdPorCodigoImpDados },
                {"cbVincularCodBarPorReferencia", GerenciadorImportacao.VincularCodBarPorCodigoImpDados },
                {"cbImportarEstoque", GerenciadorImportacao.ImportarEstoque },
                {"cbImportarCodBarras", GerenciadorImportacao.ImportarCodBarrasAdicionais }
            };

            public static readonly Dictionary<string, Func<object, object>> FuncoesPosImportacaoPorParametro = new()
            {
                  {"cbCriarUnidades",  GerenciadorImportacao.CriarUnidades},
                  {"cbCriarTabelaPreco",  GerenciadorImportacao.CriarTabelaPreco},
                  {"cbVincularPorContato", GerenciadorImportacao.VincularCliForPorCodigoImpDados },
                  {"cbImportarEstoque", GerenciadorImportacao.VerificarDuplicidade },
                  {"cbImportarCodBarras", GerenciadorImportacao.AtualizarCodBarras },
                  {"cbEnviarValidacoes", Validacoes.RodarVerificacoes }
            };

            public static readonly Dictionary<string, List<string>> UpdatesPorTabela = new()
            {
                { "clientes", new List<string>
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
                        "update clientes set consfinal = 1, Contribuinte_Icms = 0 where consfinal IS NULL;",
                        "insert into cep (select null as id, c.CodigoCidadeIbge as idcidade, c.CEP as cep from clientes c left join cep on cep.IDCidade = c.CodigoCidadeIbge and c.cep = cep.CEP Where c.CEP Is Not Null And c.CodigoCidadeIbge Is Not Null and cep.cep is null)"
                    }
                },
                { "produtos", new List<string>
                    {
                        "UPDATE PRODUTOS SET Status =  'n' WHERE STATUS = '' OR STATUS IS NULL",
                        "UPDATE PRODUTOS SET ModalidadeControle =  'Normal' WHERE ModalidadeControle ='' OR ModalidadeControle IS NULL",
                        "UPDATE PRODUTOS SET Ativo = -1 WHERE cast(ATIVO as varchar(3))= '' OR ATIVO IS NULL",
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
                        "update produtos set ncm = null where ncm ='.  . 0'"
                    }
                }
            };
        }
    }

}
