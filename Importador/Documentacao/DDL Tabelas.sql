﻿-- Conexoes definition

CREATE TABLE Conexoes(
    CodigoConexao integer primary KEY auto_increment,
    CodigoImplantacao int,
    TipoConexao boolean,
    TipoBanco int,
    host text,
    porta int,
    usuario text,
    senha text,
    banco text,
    padrao boolean DEFAULT 0
);

-- Implantacoes definition

CREATE TABLE Implantacoes(
    CodigoImplantacao int not null primary key,
    RazaoSocialCliente text,
    SistemaAntigo text,
    LinkFormulario text,
    LinkBackup text,
    RegimeEmpresa int not null Check(RegimeEmpresa in(0, 1, 2)),
    NomeResponsavel text,
    ImportarClientes int not null Check(ImportarClientes in (0, 1, 2)),
    ImportarFornecedores int not null Check(ImportarFornecedores in (0, 1, 2)),
    ImportarContasAPagar int not null Check(ImportarContasAPagar in (0, 1, 2)),
    ImportarContasAReceber int not null Check(ImportarContasAReceber in (0, 1, 2)),
    ImportarProdutos boolean not null,
    ImportarEstoque boolean not null,
    ImportarSecoes boolean not null,
    ImportarGrupos boolean not null,
    ImportarSubGrupos boolean not null,
    ImportarFabricantes boolean not null,
    ImportarGrades boolean not null,
    ImportarLotes boolean not null,
    Workflow text
);

-- Consultas definition

CREATE TABLE Consultas(
    CodigoConsulta integer not null primary KEY,
    CodigoImplantacao int,
    TabelaConsulta text,
    Consulta text
);

-- Nomenclaturas definition

CREATE TABLE Nomenclaturas(
    CodigoNomenclatura int not null primary key,
    NomenclaturaMyCommerce text not null,
    NomenclaturaImportacao text not null unique
);

-- Observacoes definition

CREATE TABLE Observacoes(
    CodigoObservacao integer not null  primary key,
    CodigoImplantacao int,
    Tela text,
    observacao text
);

-- RegistrosDeTempo definition

CREATE TABLE RegistrosDeTempo(
    CodigoRegistroDeTempo integer not null  primary key,
    CodigoImplantacao int,
    Operador text not null,
    Tela text not null,
    `Status` int,
    DataHoraInicio datetime not null,
    DataHoraFim datetime not null
);

-- SistemasImportados definition

CREATE TABLE SistemasImportados(
    CodigoSistemaImportado integer not null primary key,
    NomeSistema text,
    CodigoImplantacao int
);