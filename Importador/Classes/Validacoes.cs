using DevExpress.CodeParser;
using Importador.Conexao;
using Importador.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Data.Filtering.Helpers.SubExprHelper;

namespace Importador.Classes
{
    internal class Validacoes
    {

        private static StringBuilder _retorno = new();
        private static IDbCommand _cmd = null;
        private static int _qtdRegistros = 0;
        private static string _nomeLog = null;

        internal static string AjustarCodIBGE()
        {
            _retorno.Clear();

            _cmd = ConexaoManager.instancia.GetConexaoMyCommerce().CreateCommand();

            _retorno.AdicionarLinhaLog("Ajustando IBGE");

            _cmd.CommandText = "select count(*) from clientes c join cidades cid on replace(c.Cidade, '\'', '') = replace(cid.Cidade, '\'', '') and c.UF = cid.UF and c.CodigoCidadeIbge <> cid.Codigo";
            _qtdRegistros = Convert.ToInt32(_cmd.ExecuteScalar());

            _retorno.AdicionarLinhaLog($"### Ajustado {_qtdRegistros} clientes que estavam com código de municipio errado.");

            _cmd.CommandText = "update clientes join cidades on replace(clientes.Cidade, '\'', '') = replace(cidades.Cidade, '\'', '') and clientes.UF = cidades.UF and clientes.CodigoCidadeIbge <> cidades.Codigo set clientes.Cidade = Cidades.Cidade, clientes.CodigoCidadeIbge = cidades.Codigo";
            _cmd.ExecuteNonQuery();

            return _retorno.ToString();
        }

        internal static object RodarVerificacoes(object _)
        {
            StringBuilder sb = new();

            sb.Append(VerificarCestInvalidos());
            sb.Append(VerificarNcmInvalidos());
            sb.Append(VerificarCidadesCodIBGE());
            sb.Append(VerificarCPFCNPJDuplicado());
            sb.Append(VerificarContasQuitadasPendentes());

            Utils.CriarTXT(sb.ToString(), $"Validacoes\\log_validacoes");

            return "\"Validacoes\\*\" \"";
        }

        internal static string VerificarCestInvalidos()
        {
            _retorno = new();
            _cmd = ConexaoManager.instancia.GetConexaoMyCommerce().CreateCommand();
            _nomeLog = "Validacoes\\cest_inválidos";

            _retorno.AdicionarLinhaLog($"Validações automatizadas - Implantação {Configuracoes.Default.CodigoImplantacao}\n");

            _retorno.AdicionarLinhaLog("Iniciando verificação de cests inválidos.");
            _retorno.AdicionarLinhaLog("Executando Consulta SQL.");

            _cmd.CommandText = Constantes.Mapeamento.ConsultaPorValidacao.GetValueOrDefault(Constantes.Enums.ConsultasValidacoes.QtdCest);
            _qtdRegistros = Convert.ToInt32(_cmd.ExecuteScalar());

            _retorno.AdicionarLinhaLog($"### Foram identificados {_qtdRegistros} registros que possuem um cest inválido.\n");

            Utils.DeletarArquivo(_nomeLog);

            if (_qtdRegistros > 0)
            {
                Utils.CriarTXT(Utils.ExportSQLtoText(Constantes.Mapeamento.ConsultaPorValidacao.GetValueOrDefault(Constantes.Enums.ConsultasValidacoes.RegCest)), $"{_nomeLog}");
            }

            return _retorno.ToString();
        }

        internal static string VerificarCidadesCodIBGE()
        {
            _retorno.Clear();
            _nomeLog = "Validacoes\\codibge_inválidos";

            _retorno.AdicionarLinhaLog("Iniciando verificação de codigo ibge das cidades dos clientes.");
            _retorno.AdicionarLinhaLog("Executando Consulta SQL.");

            _cmd.CommandText = Constantes.Mapeamento.ConsultaPorValidacao.GetValueOrDefault(Constantes.Enums.ConsultasValidacoes.QtdCodIBGE);
            _qtdRegistros = Convert.ToInt32(_cmd.ExecuteScalar());

            _retorno.AdicionarLinhaLog($"### Foram identificados {_qtdRegistros} clientes que estão com o código do municipio ibge inválido (nulo ou errado).\n");

            Utils.DeletarArquivo(_nomeLog);

            if (_qtdRegistros > 0)
            {
                Utils.CriarTXT(Utils.ExportSQLtoText(Constantes.Mapeamento.ConsultaPorValidacao.GetValueOrDefault(Constantes.Enums.ConsultasValidacoes.RegCodIBGE)), $"{_nomeLog}");
            }

            return _retorno.ToString();
        }

        internal static string VerificarContasQuitadasPendentes()
        {
            _retorno.Clear();
            _nomeLog = "contasquitadas_pendentes";

            _retorno.AdicionarLinhaLog("Iniciando verificação de Contas que estão quitadas, porém com valor pendente.");
            _retorno.AdicionarLinhaLog("Executando Consulta SQL.");

            _cmd.CommandText = Constantes.Mapeamento.ConsultaPorValidacao.GetValueOrDefault(Constantes.Enums.ConsultasValidacoes.QtdQuitadasPendentes);
            _qtdRegistros = Convert.ToInt32(_cmd.ExecuteScalar());

            _retorno.AdicionarLinhaLog($"### Foram identificadas {_qtdRegistros} contas que possuem estão quitadas, porém constam um valor pendente.\n");

            Utils.DeletarArquivo(_nomeLog);

            if (_qtdRegistros > 0)
            {
                Utils.CriarTXT(Utils.ExportSQLtoText(Constantes.Mapeamento.ConsultaPorValidacao.GetValueOrDefault(Constantes.Enums.ConsultasValidacoes.RegCodIBGE)), $"{_nomeLog}");
            }

            return _retorno.ToString();
        }

        internal static string VerificarCPFCNPJDuplicado()
        {
            _retorno.Clear();
            _nomeLog = "Validacoes\\cpfcnpj_duplicado";

            _retorno.AdicionarLinhaLog("Iniciando verificação de CPF/CNPJ duplicados.");
            _retorno.AdicionarLinhaLog("Executando Consulta SQL.");

            _cmd.CommandText = Constantes.Mapeamento.ConsultaPorValidacao.GetValueOrDefault(Constantes.Enums.ConsultasValidacoes.QtdCPFCNPJ);
            _qtdRegistros = Convert.ToInt32(_cmd.ExecuteScalar());

            _retorno.AdicionarLinhaLog($"### Existem {_qtdRegistros} clientes que estão com o CPF/CNPJ duplicado.\n");

            Utils.DeletarArquivo(_nomeLog);

            if (_qtdRegistros > 0)
            {
                Utils.CriarTXT(Utils.ExportSQLtoText(Constantes.Mapeamento.ConsultaPorValidacao.GetValueOrDefault(Constantes.Enums.ConsultasValidacoes.RegCPFCNPJ)), $"{_nomeLog}");
            }

            return _retorno.ToString();
        }

        internal static string VerificarFiscal()
        {
            _retorno.Clear();
            _nomeLog = "Validacoes\\produtos_fiscal";

            string[] cabecalhos = new[] { "CodigoSistemaAntigo", "CodigoMyCommerce", "Descrição", "Validações Reprovadas" };
            string erro;
            List<string[]> listaRegistros = new List<string[]>(); 

            string regimeTrib = Configuracoes.Default.RegimeEmpresa.ToString() + " - " + (Configuracoes.Default.RegimeEmpresa == 0 ? "Simples Nacional" : Configuracoes.Default.RegimeEmpresa == 1 ? "Lucro Real" : "Lucro Presumido");

            _retorno.AdicionarLinhaLog("Iniciando validação automática de produtos");
            _retorno.AdicionarLinhaLog($"Regime tributário: {regimeTrib}");

            _cmd.CommandText = Configuracoes.Default.RegimeEmpresa == 0 ? Constantes.Mapeamento.ConsultaPorValidacao.GetValueOrDefault(Constantes.Enums.ConsultasValidacoes.GetProdSN) : Constantes.Mapeamento.ConsultaPorValidacao.GetValueOrDefault(Constantes.Enums.ConsultasValidacoes.GetProdLucro);
            IDataReader reader = _cmd.ExecuteReader();

            while (reader.Read())
            {
                //Valida se o produto tem NCM (É obrigatório que todo produto tenha)
                if (reader["ncm"] is DBNull)
                {
                    _retorno.AdicionarLinhaLog($"Produto: {reader["codigo"].ToString()} - Falhou NCM Obrigatório (NULL)");
                    erro = "Falhou em NCM Obrigatório (NULL)";
                    listaRegistros.Add(GetRegistroErro(reader, erro));
                }

                //Valida se o ncm possui cest, se possuir, e obrigatorio que tenha
                if (reader["ExisteCest"].ToString() == "1" && reader["cest"] is DBNull)
                {
                    _retorno.AdicionarLinhaLog($"Produto: {reader["codigo"].ToString()} - Falhou CEST Obrigatório (NCM do produto necessita ter um cest cadastrado)");
                    erro = "Falhou em CEST Obrigatório (NCM do produto necessita ter um cest cadastrado)";
                    listaRegistros.Add(GetRegistroErro(reader, erro));
                }

                //Valida se pis e cofins do produto possuem dois digitos e se ambos sao iguais
                if (reader["pis"].ToString().Length != 2  || reader["cofins"].ToString().Length != 2 || string.Compare(reader["pis"].ToString(), reader["cofins"].ToString(), true) != 0)
                {
                    _retorno.AdicionarLinhaLog($"Produto: {reader["codigo"].ToString()} - Falhou em CST PIS/COFINS (Cadastro errado ou divergem entre si)");
                    erro = "Falhou em PIS/COFINS (Cadastro errado ou divergem entre si)";
                    listaRegistros.Add(GetRegistroErro(reader, erro));
                }
                //Aqui havia um elso para o bloco a seguir, removido...

                if (Configuracoes.Default.RegimeEmpresa == 0)
                {
                    if (Convert.ToDouble(reader["aliqpis"]) != 0)
                    {
                        _retorno.AdicionarLinhaLog($"Produto: {reader["codigo"].ToString()} - Falhou em Aliquota de PIS (Para empresa do regime simples, aliquota deve estar zerada)");
                        erro = "Falhou em Aliquota de PIS (Para empresa do regime simples, aliquota deve estar  zerada)";
                        listaRegistros.Add(GetRegistroErro(reader, erro));
                    }

                    if (Convert.ToDouble(reader["aliqcofins"]) != 0)
                    {
                        _retorno.AdicionarLinhaLog($"Produto: {reader["codigo"].ToString()} - Falhou em Aliquota de PIS (Para empresa do regime simples, aliquota deve estar zerada)");
                        erro = "Falhou em Aliquota de PIS (Para empresa do regime simples, aliquota deve estar  zerada)";
                        listaRegistros.Add(GetRegistroErro(reader, erro));
                    }

                    if (reader["cst"].ToString().Length != 4)
                    {
                        _retorno.AdicionarLinhaLog($"Produto: {reader["codigo"].ToString()} - Falhou em CST ICMS (Cadastro errado)");
                        erro = "Falhou em CST ICMS (Cadastro errado)";
                        listaRegistros.Add(GetRegistroErro(reader, erro));
                    }

                    if (Convert.ToDouble(reader["BaseCalculoICMS"]) != 0)
                    {
                        _retorno.AdicionarLinhaLog($"Produto: {reader["codigo"].ToString()} - Falhou em Base de Cálculo do ICMS (Para empresa do simples, base deve estar zerada)");
                        erro = "Falhou em Base de Cálculo do ICMS (Para empresa do simples, base deve estar zerada)";
                        listaRegistros.Add(GetRegistroErro(reader, erro));
                    }

                    if (Convert.ToDouble(reader["AliquotaICMS"]) != 0)
                    {
                        _retorno.AdicionarLinhaLog($"Produto: {reader["codigo"].ToString()} - Falhou em Alíquota do ICMS (Para empresa do simples, alíquota deve estar zerada)");
                        erro = "Falhou em Alíquota do ICMS (Para empresa do simples, alíquota deve estar zerada)";
                        listaRegistros.Add(GetRegistroErro(reader, erro));
                    }
                }
                else
                {
                    if (Configuracoes.Default.RegimeEmpresa == 1)
                    {
                        switch (reader["pis"].ToString())
                        {
                            case "01":
                                if (Convert.ToDouble(reader["aliqpis"]) != 1.65)
                                {
                                    _retorno.AdicionarLinhaLog($"Produto: {reader["codigo"].ToString()} - Falhou em Aliquota de PIS (Para empresa do lucro real, aliquota do cst pis 01 deve ser 1.65)");
                                    erro = "Falhou em Aliquota de PIS (Para empresa do lucro real, aliquota do cst pis 01 deve ser 1.65)";
                                    listaRegistros.Add(GetRegistroErro(reader, erro));
                                }
                                break;
                            case "02" or "03":
                                if (Convert.ToDouble(reader["aliqpis"]) == 1.65)
                                {
                                    _retorno.AdicionarLinhaLog($"Produto: {reader["codigo"].ToString()} - Falhou em Aliquota de PIS (Para empresa do lucro real, aliquota do cst pis 02/03 deve ser diferente de 1.65)");
                                    erro = $"Falhou em Aliquota de PIS (Para empresa do lucro real, aliquota do cst pis 02/03 deve ser diferente de 1.65)";
                                    listaRegistros.Add(GetRegistroErro(reader, erro));
                                }
                                break;
                            default:
                                if (reader["aliqpis"] is DBNull || Convert.ToDouble(reader["aliqpis"]) != 0)
                                {
                                    _retorno.AdicionarLinhaLog($"Produto: {reader["codigo"].ToString()} - Falhou em Aliquota de PIS (Para empresa do lucro real, aliquota do cst pis {reader["pis"]} deve estar zerada)");
                                    erro = $"Falhou em Aliquota de PIS (Para empresa do lucro real, aliquota do cst pis {reader["pis"]} deve estar zerada)";
                                    listaRegistros.Add(GetRegistroErro(reader, erro));
                                }
                                break;
                        }

                        switch (reader["cofins"].ToString())
                        {
                            case "01":
                                if (Convert.ToDouble(reader["aliqcofins"]) != 7.6)
                                {
                                    _retorno.AdicionarLinhaLog($"Produto: {reader["codigo"].ToString()} - Falhou em Aliquota de COFINS (Para empresa do lucro real, aliquota do cst cofins 01 deve ser 7.6)");
                                    erro = "Falhou em Aliquota de COFINS (Para empresa do lucro real, aliquota do cst cofins 01 deve ser 7.6)";
                                    listaRegistros.Add(GetRegistroErro(reader, erro));
                                }
                                break;
                            case "02" or "03":
                                if (Convert.ToDouble(reader["aliqcofins"]) == 7.6)
                                {
                                    _retorno.AdicionarLinhaLog($"Produto: {reader["codigo"].ToString()} - Falhou em Aliquota de COFINS (Para empresa do lucro real, aliquota do cst cofins 02/03 deve ser diferente de 7.6)");
                                    erro = $"Falhou em Aliquota de COFINS (Para empresa do lucro real, aliquota do cst cofins 02/03 deve ser diferente de 7.6)";
                                    listaRegistros.Add(GetRegistroErro(reader, erro));
                                }
                                break;
                            default:
                                if (reader["aliqpis"] is DBNull || Convert.ToDouble(reader["aliqcofins"]) != 0)
                                {
                                    _retorno.AdicionarLinhaLog($"Produto: {reader["codigo"].ToString()} - Falhou em Aliquota de COFINS (Para empresa do lucro real, aliquota do cst cofins {reader["cofins"]} deve estar zerada)");
                                    erro = $"Falhou em Aliquota de COFINS (Para empresa do lucro real, aliquota do cst cofins {reader["cofins"]} deve estar zerada)";
                                    listaRegistros.Add(GetRegistroErro(reader, erro));
                                }

                                if (reader["CodNaturezaPis"] is DBNull)
                                {
                                    _retorno.AdicionarLinhaLog($"Produto: {reader["codigo"].ToString()} - Falhou em Codigo de natureza PIS/COFINS (Para empresa do lucro real com o cst pis/cofins {reader["cofins"]}, é obrigatório ter codigo de natureza");
                                    erro = $"Falhou em Codigo de natureza PIS/COFINS (Para empresa do lucro real com o cst pis/cofins {reader["cofins"]}, é obrigatório ter codigo de natureza";
                                    listaRegistros.Add(GetRegistroErro(reader, erro));
                                }
                                break;
                        }
                    }
                    else
                    {
                        switch (reader["pis"].ToString())
                        {
                            case "01":
                                if (Convert.ToDouble(reader["aliqpis"]) != 0.65)
                                {
                                    _retorno.AdicionarLinhaLog($"Produto: {reader["codigo"].ToString()} - Falhou em Aliquota de PIS (Para empresa do lucro presumido, aliquota do cst pis 01 deve ser 0.65)");
                                    erro = "Falhou em Aliquota de PIS (Para empresa do lucro real, aliquota do cst pis 01 deve ser 0.65)";
                                    listaRegistros.Add(GetRegistroErro(reader, erro));
                                }
                                break;
                            case "02" or "03":
                                if (Convert.ToDouble(reader["aliqpis"]) == 0.65)
                                {
                                    _retorno.AdicionarLinhaLog($"Produto: {reader["codigo"].ToString()} - Falhou em Aliquota de PIS (Para empresa do lucro presumido, aliquota do cst pis 02/03 deve ser diferente de 0.65)");
                                    erro = $"Falhou em Aliquota de PIS (Para empresa do lucro real, aliquota do cst pis 02/03 deve ser diferente de 1.65)";
                                    listaRegistros.Add(GetRegistroErro(reader, erro));
                                }
                                break;
                            default:
                                if (Convert.ToDouble(reader["aliqpis"]) != 0)
                                {
                                    _retorno.AdicionarLinhaLog($"Produto: {reader["codigo"].ToString()} - Falhou em Aliquota de PIS (Para empresa do lucro real, aliquota do cst pis {reader["pis"]} deve estar zerada)");
                                    erro = $"Falhou em Aliquota de PIS (Para empresa do lucro real, aliquota do cst pis {reader["pis"]} deve estar zerada)";
                                    listaRegistros.Add(GetRegistroErro(reader, erro));
                                }

                                if (reader["CodNaturezaPis"] is DBNull)
                                {
                                    _retorno.AdicionarLinhaLog($"Produto: {reader["codigo"].ToString()} - Falhou em Codigo de natureza PIS/COFINS (Para empresa do lucro presumido com o cst pis/cofins {reader["cofins"]}, é obrigatório ter codigo de natureza");
                                    erro = $"Falhou em Codigo de natureza PIS/COFINS (Para empresa do lucro presumido com o cst pis/cofins {reader["cofins"]}, é obrigatório ter codigo de natureza";
                                    listaRegistros.Add(GetRegistroErro(reader, erro));
                                }
                                break;
                        }

                        switch (reader["cofins"].ToString())
                        {
                            case "01":
                                if (Convert.ToDouble(reader["aliqcofins"]) != 3)
                                {
                                    _retorno.AdicionarLinhaLog($"Produto: {reader["codigo"].ToString()} - Falhou em Aliquota de COFINS (Para empresa do lucro presumido, aliquota do cst cofins 01 deve ser 3.0)");
                                    erro = "Falhou em Aliquota de COFINS (Para empresa do lucro presumido, aliquota do cst cofins 01 deve ser 3.0)";
                                    listaRegistros.Add(GetRegistroErro(reader, erro));
                                }
                                break;
                            case "02" or "03":
                                if (Convert.ToDouble(reader["aliqcofins"]) == 7.6)
                                {
                                    _retorno.AdicionarLinhaLog($"Produto: {reader["codigo"].ToString()} - Falhou em Aliquota de COFINS (Para empresa do lucro presumido, aliquota do cst cofins 02/03 deve ser diferente de 3.0)");
                                    erro = $"Falhou em Aliquota de COFINS (Para empresa do lucro presumido, aliquota do cst cofins 02/03 deve ser diferente de 3.0)";
                                    listaRegistros.Add(GetRegistroErro(reader, erro));
                                }
                                break;
                            default:
                                if (Convert.ToDouble(reader["aliqcofins"]) != 0)
                                {
                                    _retorno.AdicionarLinhaLog($"Produto: {reader["codigo"].ToString()} - Falhou em Aliquota de COFINS (Para empresa do lucro presumido, aliquota do cst cofins {reader["cofins"]} deve estar zerada)");
                                    erro = $"Falhou em Aliquota de COFINS (Para empresa do lucro presumido, aliquota do cst cofins {reader["cofins"]} deve estar zerada)";
                                    listaRegistros.Add(GetRegistroErro(reader, erro));
                                }
                                break;
                        }
                    }

                    if (reader["cst"].ToString().Length != 3)
                    {
                        _retorno.AdicionarLinhaLog($"Produto: {reader["codigo"].ToString()} - Falhou em CST ICMS (Cadastro errado)");
                        erro = "Falhou em CST ICMS (Cadastro errado)";
                        listaRegistros.Add(GetRegistroErro(reader, erro));
                    }
                    else
                    {
                        switch (reader["cst"].ToString().Substring(1, 2))
                        {
                            case "00":
                                if (Convert.ToDouble(reader["BaseCalculoICMS"]) != 100)
                                {
                                    _retorno.AdicionarLinhaLog($"Produto: {reader["codigo"].ToString()} - Falhou em Base de Cálculo do ICMS (Para empresa do lucro com cst x00, base deve ser 100)");
                                    erro = "Falhou em Base de Cálculo do ICMS (Para empresa do lucro com cst x00, base deve ser 100)";
                                    listaRegistros.Add(GetRegistroErro(reader, erro));
                                }
                                break;
                            case "20":
                                if (Convert.ToDouble(reader["BaseCalculoICMS"]) == 100)
                                {
                                    _retorno.AdicionarLinhaLog($"Produto: {reader["codigo"].ToString()} - Falhou em Base de Cálculo do ICMS (Para empresa do lucro com cst x20, base deve ser menor que 100)");
                                    erro = "Falhou em Base de Cálculo do ICMS (Para empresa do lucro com cst x20, base deve ser menor que 100)";
                                    listaRegistros.Add(GetRegistroErro(reader, erro));
                                }
                                break;
                            default:
                                if (Convert.ToDouble(reader["BaseCalculoICMS"]) != 0)
                                {
                                    _retorno.AdicionarLinhaLog($"Produto: {reader["codigo"].ToString()} - Falhou em Base de Cálculo do ICMS (Para empresa do lucro com cst {reader["cst"]}, base deve ser 0)");
                                    erro = $"Falhou em Base de Cálculo do ICMS(Para empresa do lucro com cst {reader["cst"]}, base deve ser 0)";
                                    listaRegistros.Add(GetRegistroErro(reader, erro));
                                }
                                break;
                        }

                        switch (reader["cst"].ToString().Substring(1, 2))
                        {
                            case "00" or "10" or "20" or "70":
                                if (Convert.ToDouble(reader["AliquotaICMS"]) == 0)
                                {
                                    _retorno.AdicionarLinhaLog($"Produto: {reader["codigo"].ToString()} - Falhou em Alíquota do ICMS (Para empresa do lucro com cst x00/x10/x20/x70, alíquota deve ser maior que 0)");
                                    erro = "Falhou em Alíquota do ICMS (Para empresa do lucro com cst x00/x10/x20/x70, alíquota deve ser maior que 0)";
                                    listaRegistros.Add(GetRegistroErro(reader, erro));
                                }
                                break;
                            default:
                                if (Convert.ToDouble(reader["AliquotaICMS"]) != 0)
                                {
                                    _retorno.AdicionarLinhaLog($"Produto: {reader["codigo"].ToString()} - Falhou em Alíquota do ICMS (Para empresa do lucro com cst x40/x41/x50/x51/x60/x90, alíquota deve ser 0)");
                                    erro = $"Falhou em Alíquota do ICMS (Para empresa do lucro com cst x40/x41/x50/x51/x60/x90, alíquota deve ser 0)";
                                    listaRegistros.Add(GetRegistroErro(reader, erro));
                                }
                                break;
                        }
                    }
                }
                
                

                if (reader["cstipi"].ToString().Length == 2 && reader["cstipi"] is string ipi)
                {
                    if(string.Compare(ipi, "50", true) == 0)
                    {
                        if (Convert.ToDouble(reader["ipi"]) == 0)
                        {
                            _retorno.AdicionarLinhaLog($"Produto: {reader["codigo"].ToString()} - Falhou em Aliquota do IPI (CST IPI 50: Precisa ter aliquota, porem esta zerada)");
                            erro = "Falhou em Aliquota do IPI (CST IPI 50: Precisa ter aliquota, porem esta zerada)";
                            listaRegistros.Add(GetRegistroErro(reader, erro));
                        }
                    }
                    else
                    {
                        if (Convert.ToDouble(reader["ipi"]) != 0)
                        {
                            _retorno.AdicionarLinhaLog($"Produto: {reader["codigo"].ToString()} - Falhou em Aliquota do IPI (CST IPI 51/52/53/54/55/99: Aliquota deve estar zerada)");
                            erro = "Falhou em Aliquota do IPI (CST IPI 51/52/53/54/55/99: Aliquota deve estar zerada)";
                            listaRegistros.Add(GetRegistroErro(reader, erro));
                        }

                        if (reader["CodigoEnqIPI"] is DBNull)
                        {
                            _retorno.AdicionarLinhaLog($"Produto: {reader["codigo"].ToString()} - Falhou em Enquadramento do IPI (CST IPI 51/52/53/54/55: Necessitam de um codigo)");
                            erro = "Falhou em Enquadramento do IPI (CST IPI 51/52/53/54/55: Necessitam de um codigo)";
                            listaRegistros.Add(GetRegistroErro(reader, erro));
                        }
                    }
                }
                else
                {
                    _retorno.AdicionarLinhaLog($"Produto: {reader["codigo"].ToString()} - Falhou em CST IPI (Cadastro errado)");
                    erro = "Falhou em CST IPI (Cadastro errado)";
                    listaRegistros.Add(GetRegistroErro(reader, erro));
                }
            }

            reader.Close();

            if (listaRegistros.Count > 0)
            {
                Utils.CriarTXT(Utils.ExportRegToText(cabecalhos, listaRegistros), $"{_nomeLog}");
            }

            return _retorno.ToString();
        }

        private static string[] GetRegistroErro(IDataReader reader, string erro)
        {
            string[] registro = new string[4];

            registro[0] = reader[0] is DBNull ? "null" : reader[0].ToString();
            registro[1] = reader[1].ToString();
            registro[2] = reader[2].ToString();
            registro[3] = erro;

            return registro;
        }

        internal static string VerificarNcmInvalidos()
        {
            _retorno.Clear();
            _nomeLog = "Validacoes\\ncm_inválidos";

            _retorno.AdicionarLinhaLog("Iniciando verificação de NCM inválidos.");
            _retorno.AdicionarLinhaLog("Executando Consulta SQL.");

            _cmd.CommandText = Constantes.Mapeamento.ConsultaPorValidacao.GetValueOrDefault(Constantes.Enums.ConsultasValidacoes.QtdNCM);
            _qtdRegistros = Convert.ToInt32(_cmd.ExecuteScalar());

            _retorno.AdicionarLinhaLog($"### Foram identificados {_qtdRegistros} registros que possuem um NCM inválido (nulo ou errado).\n");

            Utils.DeletarArquivo(_nomeLog);

            if (_qtdRegistros > 0)
            {
                Utils.CriarTXT(Utils.ExportSQLtoText(Constantes.Mapeamento.ConsultaPorValidacao.GetValueOrDefault(Constantes.Enums.ConsultasValidacoes.RegNCM)), $"{_nomeLog}");
            }

            return _retorno.ToString();
        }
    }
}
