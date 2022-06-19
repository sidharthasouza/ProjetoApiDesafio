PASSOS PARA RODAR O PROJETO: 

- Abra o a Solution 'ProjetoApiDesafio' por meio do Visual Studio 2019.
- Com o projeto aberto no Visual Studio, clique em F5 para executar a WEBAPI.
- O projeto não foi desenvolvido com base no TDD.

- Com o projeto rodando, os EndPoints serão exibidos.

- O banco de dados utilizado é o SQL Server.
- No arquivo appsettings.json, configure a string de conexão de acordo com os dados de acesso ao banco.
- O projeto utiliza Migrations, que auxilia na criação da base de dados.
- Vá ao menu Tools >> NuGet Package Manager >> Package Manager Console.
- Digite o comando: Update-Database.
- A base será criada no Sql Server.