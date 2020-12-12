USE [dbPICC_20202]
GO

CREATE TABLE GoMusic_Endereco(
	IdEndereco INT NOT NULL,
	Rua VARCHAR(50),
	Cidade VARCHAR(20),
	Numero VARCHAR(6),
	Bairro VARCHAR(30),
	UF CHAR(2)

)

ALTER TABLE GoMusic_Endereco
ADD CONSTRAINT PKGoMusic_Endereco PRIMARY KEY (IdEndereco)

CREATE TABLE GoMusic_Musico(
	IdMusico INT NOT NULL,					
	Instrumentos VARCHAR(50),
	DescricaoMusico VARCHAR(100),
	GeneroMusical VARCHAR(50),
	Nome VARCHAR(100),
	CPF VARCHAR(11),
	Idade INT,
	Telefone INT,
	Email VARCHAR(50),
	IdEndereco INT NOT NULL
)
	
ALTER TABLE GoMusic_Musico
ADD CONSTRAINT PKGoMusic_Musico PRIMARY KEY (IdMusico),
CONSTRAINT FK_IdEndereco FOREIGN KEY (IdEndereco) References GoMusic_Endereco (IdEndereco)


alter table GoMusic_Musico
alter column Telefone varchar(15)

alter table GoMusic_Endereco add IdMusico int 