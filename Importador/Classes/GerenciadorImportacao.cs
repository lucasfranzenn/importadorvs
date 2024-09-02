using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Import.OpenDocument;
using Importador.Conexao;
using System;
using System.Collections.Generic;
using System.Data;
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

                while (reader.Read())
                {
                    sqlInsert.Clear();
                    sqlInsert.Append($"INSERT INTO {tabela.ToString()} (");
                    sqlInsert.Append(string.Join(", ", nomeColunas));
                    sqlInsert.Append(") VALUES (");

                    for (int i = 0; i < qtdColunas; i++)
                    {
                        object value = reader.GetValue(i);

                        if (value is string || value is DateTime)
                        {
                            sqlInsert.Append($"'{value}'");
                        }
                        else if (value is DBNull)
                        {
                            sqlInsert.Append("NULL");
                        }
                        else
                        {
                            sqlInsert.Append(value);
                        }

                        if (i < qtdColunas - 1)
                        {
                            sqlInsert.Append(", ");
                        }
                    }

                    sqlInsert.Append(");");

                    // Insere Registro no banco do MyCommerce
                    InsereRegistroMyCommerce(sqlInsert.ToString());

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

        private static void InsereRegistroMyCommerce(string sqlInsert)
        {
            IDbCommand cmd = ConexaoManager.instancia.GetConexaoMyCommerce().CreateCommand();
            cmd.CommandText = sqlInsert;
            cmd.ExecuteNonQuery();
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
