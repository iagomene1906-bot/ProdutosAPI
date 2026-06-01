# ProdutosAPI 📦

[![Linguagem](https://img.shields.io/badge/Linguagem-C%23-239120?style=flat-square&logo=c-sharp&logoColor=white)](#)
[![Framework](https://img.shields.io/badge/Framework-ASP.NET_Core-512BD4?style=flat-square&logo=.net&logoColor=white)](#)
[![Database](https://img.shields.io/badge/Database-SQL_Server-CC292B?style=flat-square&logo=microsoft-sql-server&logoColor=white)](#)
[![Documentação](https://img.shields.io/badge/Swagger-85EA2D?style=flat-square&logo=swagger&logoColor=black)](#)

## 📖 Sobre o Projeto

O **ProdutosAPI** é um sistema de back-end desenvolvido para realizar o controle e a gestão de um catálogo de produtos. 

Diferente de soluções iniciais baseadas em arquivos locais (como JSON), este projeto evoluiu para utilizar um ambiente real de produção com persistência de dados em um banco de dados relacional **SQL Server**. O projeto aborda o mapeamento de entidades, isolamento de credenciais sensíveis e operações completas de CRUD.

## ✨ Funcionalidades

* Cadastro de novos produtos no catálogo.
* Listagem completa de todos os produtos cadastrados.
* Busca de detalhes de um produto específico através de seu ID.
* Atualização de dados de um produto existente.
* Remoção de produtos do sistema com persistência segura no banco de dados.

## 🚀 Tecnologias Utilizadas

* **C#**
* **ASP.NET Core**
* **Microsoft SQL Server** (Banco de dados relacional)
* **Entity Framework Core**
* **Swagger** (Interface interativa para documentação e testes das rotas)

## 📍 Endpoints Principais

| Método | Rota | Descrição |
|---|---|---|
| `GET` | `/api/produtos` | Retorna a lista de todos os produtos gravados no banco. |
| `GET` | `/api/produtos/{id}` | Busca no banco um produto específico pelo seu ID. |
| `POST` | `/api/produtos` | Insere um novo produto no banco de dados. |
| `PUT` | `/api/produtos/{id}` | Atualiza os dados de um produto existente no banco. |
| `DELETE` | `/api/produtos/{id}` | Remove permanentemente um produto do banco de dados. |

## 🛠️ Como Executar o Projeto

### Pré-requisitos
* [SDK do .NET](https://dotnet.microsoft.com/download) instalado em sua máquina.
* Instância do **SQL Server** ativa localmente.

### Passos para rodar
1. Clone este repositório:
```bash
   git clone https://github.com/iagomene1906-bot/ProdutosAPI.git
```
2. Acesse a pasta do projeto através do terminal.
3. Configure sua String de Conexão conforme o exemplo dentro da pasta.
4. Execute o comando para criar as tabelas:
```bash
   dotnet ef database update
```
5. Execute a aplicação:
```bash
   dotnet run
```
6. Acesse a interface do Swagger pelo navegador para testar a comunicação direta com o seu banco SQL Server.

## 👨‍💻 Autor

Criado por **[Iago Oliveira]** - Sinta-se à vontade para se conectar comigo!

[![GitHub](https://img.shields.io/badge/GitHub-100000?style=flat-square&logo=github&logoColor=white)](https://github.com/iagomene1906-bot)
