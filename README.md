Blog – Sistema de publicação com C#, POO e Entity Framework Core

Este projeto simula um sistema de Blog, com cadastro e organização de posts, categorias e usuários, desenvolvido para praticar C#, POO e persistência de dados utilizando Entity Framework Core com SQL Server.

🚀 Tecnologias utilizadas

C#

.NET

Entity Framework Core

SQL Server

Fluent API para mapeamento de entidades

Programação Orientada a Objetos

🧠 Conceitos aplicados

Encapsulamento e modelagem de entidades

Relacionamento entre tabelas (Posts, Users, Categories)

Organização em camadas (Data, Models, Maps)

Uso de DbContext e DbSet<T>

OnModelCreating com ApplyConfiguration

Configuração de banco via UseSqlServer

Estrutura clara e didática para estudos

📂 Estrutura do Projeto

Data

BlogDataContext (DbContext configurado com SQL Server)

Mapeamentos das entidades via Fluent API (CategoryMap, PostMap, UserMap)

Models

Post

Category

User

Cada entidade possui propriedades, relacionamentos e validações básicas.

🗄️ Banco de Dados

O projeto se conecta a um banco SQL Server local:

options.UseSqlServer("Server=localhost,1433;Database=Blog;User ID=sa;Password=******");

🔧 Você pode ajustar a connection string conforme o seu ambiente.

🎯 Objetivo

Este projeto foi desenvolvido para praticar:

Modelagem de domínio

Persistência com Entity Framework Core

Organização de código

POO aplicado a um caso real

Comunicação com banco de dados SQL Server
