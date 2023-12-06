# TabelasDinamicas

## Sobre
Projeto para uma demonstração de modelos de tabelas dinamicas utilizando arquitetura em camadas, se baseando muito no padrão Domain-Driven Design (DDD), dividindo assim o projeto em 4 camadas, sendo essas:
* __Web:__ Camada mais exposta, onde se encontra os controllers com seus devidos endpoints para acesso a API.
* __Application:__ Camada responsavel pelas regras de negócio, manipulação de dados e entidades ViewModel/DTO para consumo externo.
* __Domain:__ Camada de entidades base, que representam tabelas no banco de dados e interfaces de repositorios para interação com o mesmo.
* __Data :__ Camada mais interna do fluxo de dados, responsavel pelas implementações de repositorio, mapeamento das entidades de Domain para o banco de dados, e contexto(s) necessario.
* __Core:__ Camada de metodos que possam ser compartilhados entre as camadas.

A ideas das tabelas dinamicas da-se com a utilização de 3 entidades: __Tabela__,  __Registro__,  __Complemento__, Tabela, como o nome ja diz, representa dados de uma tabela, contendo dados referentes a mesma que possam vir a ser necessarios, Registros representa cada linha de dados presente em uma tabela, já complemento diz respeito a informação extra que uma tabela pode conter, assim forma-se um relacionamento n-n para Tabela com Complemento, formando assim a entidade ComplementoTabela, da mesma forma que Registro para Complemento, formando assim a entidade ComplementoRegistro. ComplementoTabela tem a função de informar quais complementos uma tabela contem, o que, visualmente, se da como coluna extras e especificas para uma tabela especifica, e ComplementoRegistro cumpre a função de armazenar qual o valor foi dado a um complemento em um registro pertencente a uma tabela.


## Tecnologias

* [.NET 7](https://dotnet.microsoft.com/download)
* [ASP.NET Core 7](https://docs.microsoft.com/en-us/aspnet/core)
* [Entity Framework Core 7](https://docs.microsoft.com/en-us/ef/core)
* [C# 11](https://docs.microsoft.com/en-us/dotnet/csharp)


## Praticas

* Clean Architecture
* Clean Code
* SOLID Principles
* Separation of Concerns
* DDD (Domain-Driven Design)


#### Prerequisitos

* [.NET SDK](https://dotnet.microsoft.com/download/dotnet)
* [SQL Server](https://go.microsoft.com/fwlink/?linkid=866662)

### Links

* [Linkedin](https://br.linkedin.com/in/pedro-augusto-silva-281782152)