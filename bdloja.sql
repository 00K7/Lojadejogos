create database bdloja;
use bdloja;

create table Funcionario
(
	FuncionarioID varchar(20) primary key,
    FuncionarioNome varchar(50) not null,
	FuncionarioCargo varchar(50) not null,
	FuncionarioDataNascimento datetime not null
);