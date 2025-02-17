# HouseManagement API

Este é um projeto de uma API para controle financeiro desenvolvida em C# utilizando .NET 8 no Visual Studio 2022.

## Configuração e Execução  

### Pré-requisitos
Para funcionar é necessário ter instalado:  
- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
- [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)
- Visual Studio 2022

###  Configuração do Banco de Dados  
Edite o arquivo `appsettings.json`, localizado em `HouseManagement.API`, e atualize a string de conexão:  

```json
"DefaultConnection": "Server=NOME_DO_SERVIDOR;Database=NOME_DO_BANCO;User Id=USUARIO;Password=SENHA;TrustServerCertificate=True"
```
Para iniciar o aplicativo é possível usar o bõtão de início do próprio Visual Studio 2022 ou usar o comando na pasta raíz do projeto
```bash
dotnet run --project HouseManagement.API
```
A API funciona usando o Swagger na porta 7229. Quando rodar abra:
https://localhost:7229/swagger

## Endpoints
- GET /api/Person – Lista todas as pessoas e suas transações
- POST /api/Person – Adiciona uma nova pessoa
- DELETE /api/Person/{id} – Remove uma pessoa
- POST /api/Transaction – Adiciona uma transação
- DELETE /api/Transaction/{id} – Remove uma transação