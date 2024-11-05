# Importador de Dados - MyCommerce

Este é o projeto do importador de dados para o sistema ERP MyCommerce da Visual Software, sua principal funcionalidade é migrar os dados do sistema antigo do cliente para o nosso, fazendo os ajustes e correções necessárias para encaixar-se na regra de negócio utilizada.
<br>Anteriormente software era baseado no VB6 e por ser um projeto "pequeno" e fácil de ser migrado, foi feito a decisão de migrar para o C#, mas mantendo dentro do ambiente .NET.

<hr>

## Tecnologias utilizadas
- <b>Linguagem:</b> C# 12.0;
- <b>Frameworks:</b> .NET 8 & DevExpress v24.1.3
- <b>Gestão de Relatórios:</b> FastReport OpenSource 2025.1;
- <b>Banco de Dados Local:</b> SQLite 3;

<hr>

### Melhorias inclusas
- Melhora na velocidade ao importar dados ~= 65%;
- Melhora na lógica do código comparado ao anterior, visando a manutenabilidade;
- Removido a necessidade de ter instalado o ODBC dos SGBD mais comuns (Firebird, MySQL, SQL Server, Postgree);

### Customizações Inclusas
- Cadastrar e armazenar informações de implantações;
- Armazenamento local para salvar dados de importações realizadas;
- Botão para resetar a SQL Padrão utilizada em determinada tela;
- Botão para verificar sintaxe SQL da consulta;
- Cadastrar observações para cada tabela a ser importada;
- Contagem de tempo para cada tela;
- Visualizar tempo de trabalho para cada tela;
- Gerar relatório de tempo gasto na implantação atual;
- <b>Recursos de Apoio:</b>
  - <b>Nomenclaturas:</b> Cadastrar nomenclaturas encontradas visando facilitar a procura de campos futuramente, por exemplo: (produtos -> itens || produtos -> mercadorias);
  - <b>Sistemas importados:</b> Lista de todos os sistemas importados, incluindo o código, razao social, sistema e banco de dados do sistema.
  - <b>Fiscal:</b> Contém um documento fiscal para auxiliar dúvidas sobre tributações

### Download do executável 

 - <a href="https://drive.google.com/file/d/19xxL3Ml-chqKnUUiUxbrz-QvHUPxyXkf/view?usp=sharing">Standalone - win x64</a>

### Documentações
  - <a href="https://github.com/lucasfranzenn/importadorvs/blob/main/Importador/Documentacao/backlog.md"> Backlog inicial do projeto</a>
  - <a href="https://github.com/lucasfranzenn/importadorvs/blob/main/Importador/Documentacao/DDL%20Tabelas.txt">Documentação de DDL das tabelas</a>
