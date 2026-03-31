# Comando Docker para criação da instancia Docker
docker run -v ~/docker --name sqlserver -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=1q2w3e4r@#$" -p 1433:1433 -d mcr.microsoft.com/mssql/server

# Connection String
Server=localhost,1433;Database=balta;User ID=sa;Password=1q2w3e4r@#$

# Criação do banco de Dados no SQL Server
create database MQSVendasAppDb
go
use MQSVendasAppDb;
go
create table [User]
(
	Id Uniqueidentifier primary key default newid(),
	Username nvarchar(50) not null,
	[Password] nvarchar(100) not null,
	[Nome] nvarchar(50) not null,
	LastName nvarchar(50) not null,
	Email nvarchar(100)unique not null
)
go

# Alimentação do Banco
insert into [User] values(NEWID(), 'admin','admin', 'MQS', 'Advance', 'advance@mqs.com.br')
insert into [User] values(NEWID(), 'pop','querty', 'Pop Mel', 'Sebhant', 'pop.mel@mqs.com.br')
insert into [User] values(NEWID(), 'charles','asdfg', 'bicolao', 'bicolao', 'bicolao@mqs.com.br')
go
select * from [User]