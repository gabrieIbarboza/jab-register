create database dbJabRegister;
use dbJabRegister;

create table tbUser(
	user_id varchar(128) primary key unique,
    user_nome varchar(50) not null,
    user_cpf varchar(128) not null,
    user_tel varchar(14),
    user_email varchar(50),
    user_genero char(1),
    user_endereco varchar(60),
    user_dtnasc date
);

select * from tbUser;

create procedure SP_RegistraUser(
	nome varchar(50), 
    cpf varchar(128), 
    tel varchar(14), 
    email varchar(50),
    genero char(1),
    endereco varchar(60),
    dtnasc date
) insert into tbUser values (
		uuid(), nome, cpf, tel, email, genero, endereco, dtnasc
    );

