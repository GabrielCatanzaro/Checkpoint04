# Proposta e Execução

Este projeto é um sistema console em .NET 8 para gerenciar usuários, utilizando Entity Framework Core com banco Oracle. Permite cadastrar, listar, atualizar, remover usuários e gerar relatórios dos 5 com mais XP ou tarefas concluídas.

## Como rodar

1. Edite a connection string no arquivo `Sprint3/Data/AppDbContext.cs` com os dados do seu Oracle.
2. Para rodar este projeto, você precisa instalar as seguintes dependências NuGet:
- **Microsoft.EntityFrameworkCore (8.0.0)**
- **Microsoft.EntityFrameworkCore.Design (8.0.0)**
- **Oracle.EntityFrameworkCore (8.21.121)** (ou `Oracle.EntityFrameworkCore` da Oracle)
- **Microsoft.Extensions.Configuration(9.0.0)**
- **Microsoft.Extensions.Configuration.FileExtensions(9.0.0)**
- **Microsoft.Extensions.Configuration.Json(9.0.0)**


  Integrantes:

  Gabriel Gomes Catanzaro / RM93445
  Cassio Eid Kobayashi Yonetsuka / RM99678
  Filipe Prado Menezes / RM98765
  Lucas Gomes Alcantara / RM98766
  Henrique Canali Cuzato / RM88166
