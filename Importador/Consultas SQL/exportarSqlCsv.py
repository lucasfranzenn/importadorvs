# -*- coding: utf-8 -*-

import pandas as pd
import pyodbc
import sys
import mysql.connector

def main(connection_string, query, output_csv):

    db_connection = mysql.connector.connect(
            host='10.1.1.220',
            user='root',
            password='vssql',
            database='bdvinicius',
            port='3306'
        )
    db_cursor = db_connection.cursor()

    # Conectando ao banco de dados
    # conn = pyodbc.connect(connection_string)
    
    # Lendo dados com pandas
    df = pd.read_sql(query, db_connection)
    
    # Exportando para CSV
    df.to_csv(output_csv, index=False)
    
    print(f"Dados exportados para {output_csv}")

if __name__ == "__main__":
    connection_string = sys.argv[1]  # A string de conexão passada do C#
    query = sys.argv[2]              # A consulta SQL passada do C#
    output_csv = sys.argv[3]         # O caminho do arquivo CSV de saída
    
    main(connection_string, query, output_csv)
