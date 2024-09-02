using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Import.OpenDocument;
using Importador.Conexao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Importador.Classes.VariaveisGlobais;

namespace Importador.Classes
{
    public static class GerenciadorImportacao
    {
        public static int GetQtdRegistros(string sql)
        {
            IDbCommand count = ConexaoManager.instancia.GetConexaoImportacao().CreateCommand();
            count.CommandText = $"select count(*) from ({sql.TrimEnd(';')}) as qtd";

            return Convert.ToInt32(count.ExecuteScalar());
        }

        public static void Importar(string sql, ref ProgressBarControl pbImportacao, Tabelas tabela, List<CheckEdit> parametros)
        {
            StringBuilder sqlInsert = new();
            IDbCommand sqlQuery = ConexaoManager.instancia.GetConexaoImportacao().CreateCommand();
            int qtdRegistros = GetQtdRegistros(sql);
            string progressoRegistros;

            sqlQuery.CommandText = sql;

            pbImportacao.EditValue = 0;
            pbImportacao.Properties.Maximum = qtdRegistros;

            //Limpa tabelas
            if (parametros.Any((p) => string.Equals(p.Name, "cbExcluirRegistros") && p.Checked)) LimpaTabelas(TabelasTruncate[tabela.ToString()]);

            using (IDataReader reader = sqlQuery.ExecuteReader())
            {
                int qtdColunas = reader.FieldCount;
                string[] nomeColunas = new string[qtdColunas];

                for (int i = 0; i < qtdColunas; i++)
                {
                    nomeColunas[i] = reader.GetName(i);
                }

                sqlInsert.Clear();
                sqlInsert.Append($"INSERT INTO {tabela.ToString()} (");
                sqlInsert.Append(string.Join(", ", nomeColunas));
                sqlInsert.Append(") VALUES (");
                sqlInsert.Append(string.Join(", ", nomeColunas.Select(col => $"@{col}")));
                sqlInsert.Append(");");

                while (reader.Read())
                {
                    using (IDbCommand cmd = ConexaoManager.instancia.GetConexaoMyCommerce().CreateCommand())
                    {
                        cmd.CommandText = sqlInsert.ToString();
                        cmd.Parameters.Clear();
                        for (int i = 0; i < qtdColunas; i++)
                        {
                            object value = reader.GetValue(i);

                            IDbDataParameter parameter = cmd.CreateParameter();
                            parameter.ParameterName = $"@{nomeColunas[i]}";

                            if (value is DBNull)
                            {
                                parameter.Value = DBNull.Value;
                            }
                            else
                            {
                                parameter.Value = value;
                            }
                            cmd.Parameters.Add(parameter);
                        }

                        cmd.ExecuteNonQuery();
                    }

                    //Incrementa a progressbar e atualiza o seu texto
                    int registroAtual = Convert.ToInt32(pbImportacao.EditValue) + 1;
                    progressoRegistros = $"{registroAtual} de {qtdRegistros} registros";
                    pbImportacao.PerformStep();
                    pbImportacao.Update();
                    pbImportacao.CustomDisplayText += (sender, args) => 
                    {
                        args.DisplayText = progressoRegistros;
                    };
                }
            }
        }

        private static void LimpaTabelas(List<string> tabelas)
        {
           foreach (string tabela in tabelas)
            {
                IDbCommand truncate = ConexaoManager.instancia.GetConexaoMyCommerce().CreateCommand();
                truncate.CommandText = $"truncate table {tabela};";
                truncate.ExecuteNonQuery();
            }
        }
    }
}
