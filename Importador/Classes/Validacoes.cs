using Importador.Conexao;
using Importador.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
