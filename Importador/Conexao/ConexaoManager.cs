﻿using DevExpress.XtraEditors;
using FirebirdSql.Data.FirebirdClient;
using MySqlConnector;
using Npgsql;
using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using static Importador.Classes.Constantes;
using static Importador.Classes.Utils;

namespace Importador.Conexao
{
    public class ConexaoManager
    {
        private readonly IDbConnection _conexaoMariaDB;
        private readonly IDbConnection _conexaoImportacao;
        public static ConexaoManager instancia;

        public ConexaoManager()
        {
            _conexaoMariaDB = new MariaDbConnection().CriarConexao(GetImportacao(Enums.Sistema.MyCommerce));

            ConexaoBase genericDbFactory = ConexaoFactory.CriarConexaoBanco((Enums.TipoBanco)GetImportacao(Enums.Sistema.Importacao).TipoBanco);
            _conexaoImportacao = genericDbFactory.CriarConexao(GetImportacao(Enums.Sistema.Importacao));
        }

        public IDbConnection GetConexaoMyCommerce()
        {
            return _conexaoMariaDB;
        }

        public IDbConnection GetConexaoImportacao()
        {
            return _conexaoImportacao;
        }

        public static bool ConexoesAbertas()
        {
            if (instancia is not null)
                instancia.CloseConnections();

            instancia = new();
            bool conexaoAberta=false;
            try
            {
                instancia._conexaoMariaDB.Open();
                conexaoAberta = true;
                instancia._conexaoImportacao.Open();
            }
            catch (DbException e)
            {
                if (conexaoAberta==true)
                    XtraMessageBox.Show(e.Message, "..::Problema na conexão do Banco da Importação::..", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                else
                    XtraMessageBox.Show(e.Message, "..::Problema na conexão do Banco do MyCommerce::..", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        public void CloseConnections()
        {
            _conexaoMariaDB.Close();
            _conexaoImportacao.Close();
        }

        public string GetProcurarColunaQuery(string coluna) => _conexaoImportacao switch
        {
            (MySqlConnection) => $"SELECT TABLE_NAME AS TABELA, COLUMN_NAME AS COLUNA FROM information_schema.columns WHERE TABLE_SCHEMA = '{GetImportacao(Enums.Sistema.Importacao).Banco}' AND COLUMN_NAME LIKE '%{coluna}%' ORDER BY TABLE_NAME, ordinal_position",
            (SqlConnection) => $"SELECT T.name AS Tabela, C.name AS Coluna FROM sys.sysobjects AS T (NOLOCK) INNER JOIN sys.all_columns AS C (NOLOCK) ON T.id = C.object_id AND T.XTYPE = 'U' where upper(C.NAME) LIKE upper('%{coluna}%') ORDER BY T.name ASC",
            (FbConnection) => $"select rdb$relation_name as tabela, rdb$field_name AS coluna from rdb$relation_fields where upper(rdb$field_name) like upper('%{coluna}%') AND UPPER(rdb$relation_name) NOT LIKE upper('RDB%')  ORDER BY rdb$relation_name",
            (NpgsqlConnection) => $"SELECT table_name as tabela, column_name as coluna FROM information_schema.columns WHERE upper(column_name) like upper('%{coluna}%') order by table_name",
            _ => null
        };
    }

}
