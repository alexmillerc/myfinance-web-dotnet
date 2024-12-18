# Sistema de Gestão Financeira (myfinance-web-dotnet)

Projeto do Curso de Pós-Graduação em Engenharia de Software da PUC-MG

![.NET](https://img.shields.io/badge/.NET-6.0-blueviolet?style=flat-square) ![C#](https://img.shields.io/badge/C%23-10.0-239120?style=flat-square) ![SQL Server](https://img.shields.io/badge/SQL%20Server-2019-red?style=flat-square)

## Descrição

Sistema para gerenciamento financeiro com as seguintes funcionalidades:

- **Cadastro de Receitas/Despesas**: Registrar entradas financeiras com descrição, valor, tipo (receita ou despesa) e data.
- **Listagem de Receitas/Despesas**: Tabela com visualização de dados financeiros cadastrados.

## Tecnologias

- **Linguagem**: C#
- **Framework**: ASP.NET Core 6.0
- **Banco de Dados**: SQL Server 2019
- **ORM**: Entity Framework Core

## Requisitos

- **SDK do .NET 6.0**
- **SQL Server 2019**
- **Visual Studio 2022** (ou equivalente)

## Configuração do Banco de Dados

1. Atualize o arquivo `appsettings.json` com suas credenciais:
   ```json
   {
       "ConnectionStrings": {
           "DefaultConnection": "Server=LOCALHOST\SQLEXPRESS;Database=myfinance;Trusted_Connection=True;TrustServerCertificate=True;"
       }
   }
   ```
2. Configure o banco de dados:
   ```bash
   dotnet ef database update
   ```

## Como Executar

1. Clone o repositório:
   ```bash
   git clone https://github.com/alexmillerc/myfinance-web-dotnet
   ```
2. Acesse o diretório:
   ```bash
   cd myfinance-web-netcore
   ```
3. Restaure as dependências e compile o projeto:
   ```bash
   dotnet restore && dotnet build
   ```
4. Inicie a aplicação:
   ```bash
   dotnet run
   ```
5. Acesse [http://localhost:5211] no navegador.

## Estrutura do Projeto

- **Controllers**: Lógica das requisições (e.g., `PlanoContaController.cs`)
- **Domain**: Entidades de domínio (e.g., `PlanoConta.cs`)
- **Infrastructure**: Configuração de acesso ao banco (e.g., `MyFinanceDbContext.cs`)
- **Models**: Modelos de dados (e.g., `PlanoContaModel.cs`)
- **Services**: Regras de negócio (e.g., `PlanoContaService.cs`)
- **Views**: Páginas (e.g., `Index.cshtml`, `Cadastro.cshtml`)

## Licença

Este projeto está licenciado sob a [MIT License](LICENSE).
