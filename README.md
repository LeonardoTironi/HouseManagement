# HouseManagement API

Este � um projeto de uma API para controle financeiro desenvolvida em C# utilizando .NET 8 no Visual Studio 2022.

## Configura��o e Execu��o  

### Pr�-requisitos
Para funcionar � necess�rio ter instalado:  
- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
- [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)
- Visual Studio 2022

###  Configura��o do Banco de Dados  
Edite o arquivo `appsettings.json`, localizado em `HouseManagement.API`, e atualize a string de conex�o:  

```json
"DefaultConnection": "Server=NOME_DO_SERVIDOR;Database=NOME_DO_BANCO;User Id=USUARIO;Password=SENHA;TrustServerCertificate=True"
```
Para iniciar o aplicativo � poss�vel usar o b�t�o de in�cio do pr�prio Visual Studio 2022 ou usar o comando na pasta ra�z do projeto
```bash
dotnet run --project HouseManagement.API
```
A API funciona usando o Swagger na porta 7229. Quando rodar abra:
https://localhost:7229/swagger

## Endpoints
- GET /api/Person � Lista todas as pessoas e suas transa��es
- POST /api/Person � Adiciona uma nova pessoa
- DELETE /api/Person/{id} � Remove uma pessoa
- POST /api/Transaction � Adiciona uma transa��o
- DELETE /api/Transaction/{id} � Remove uma transa��o