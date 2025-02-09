﻿using Importador.Properties;
using System;

namespace Importador.Classes.Entidades
{
    internal class Consultas
    {
        public Consultas(string tabela, string sql)
        {
            CodigoImplantacao = Convert.ToInt32(Configuracoes.Default.CodigoImplantacao);
            Empresa = Convert.ToInt32(Configuracoes.Default.Empresa);
            Consulta = sql;
            TabelaConsulta = tabela;
        }

        public Consultas() { }
        public int? CodigoConsulta { get; set; } = null;
        public int Empresa { get; set; }
        public int CodigoImplantacao { get; set; }
        public string TabelaConsulta { get; set; }
        public string Consulta { get; set; }
    }
}
