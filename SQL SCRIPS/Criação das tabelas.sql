/*#################################################################################################################################*/
USE master
GO

CREATE DATABASE DiarioEleV2
GO

USE DiarioElev2
GO

 /*#################################################################################################################################*/

CREATE TABLE AGENTEPEDAGOGICO
(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	NomeAgente VARCHAR(150) NULL,
	Senha VARCHAR(150)NOT NULL,
	NomeUsuario VARCHAR(100) NOT NULL
)
GO
/*#################################################################################################################################*/

CREATE TABLE ALUNO 
(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Id_Sexo int NULL,
	Id_Cidade int NULL,
	Id_Turma int NULL,
	NomeAluno VARCHAR(100) NULL,
	DataDeNascimento VARCHAR(50)NULL,
	TelefoneResponsavel VARCHAR(50) NULL,
	CPF VARCHAR(100)NULL,
	Email VARCHAR(100) NULL,
	NomeDoResponsavel VARCHAR(100)NULL,
	EnderecoAluno VARCHAR(100) NULL,
	Complemento VARCHAR(100)NULL,
	Setor VARCHAR(100)NULL,
	Numero INT NULL,
	CEP VARCHAR(50)NULL,
	NomeUsuario VARCHAR(100)NOT NULL,
	Senha VARCHAR(150)NOT NULL
)
GO

/*#################################################################################################################################*/
	
CREATE TABLE BIMESTRE
(
	Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	Bimestre VARCHAR(100)null


)
GO

/*#################################################################################################################################*/

CREATE TABLE CIDADE
(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Id_UF int NULL,
	NomeCidade VARCHAR(50) NULL
)
GO

/*#################################################################################################################################*/

CREATE TABLE DIARIOELE
(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Id_Disciplina int NULL,	
	Id_Professor int NULL,
	Id_Turma int NULL,
)
GO

/*#################################################################################################################################*/

CREATE TABLE DISCIPLINA
(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	NomeDisciplina VARCHAR(50) NOT NULL,
)
GO
/*#################################################################################################################################*/
CREATE TABLE FREQUENCIA(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Id_Aluno int NULL,
	Id_Diario int null,
	Faltas bit NULL,
	Data_ datetime NULL,
)
GO

/*#################################################################################################################################*/

CREATE TABLE NOTA(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Id_Aluno int NULL,
	Id_Turma int NULL,
	Id_Diario int null,
	Nota FLOAT NULL,
)
GO

/*#################################################################################################################################*/

CREATE TABLE OCORRENCIA
(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Id_Aluno int NULL,
	Id_Diario int NULL,
	Descricao VARCHAR(100) NULL,
)
GO

/*#################################################################################################################################*/

CREATE TABLE PLANODEAULA
(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Id_professor int NULL,
	Id_Diario int NULL,
	Conteudo VARCHAR(100) NULL,
)
GO

/*#################################################################################################################################*/
CREATE TABLE PROFESSOR
(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Id_Sexo int NULL,
	Id_Cidade int NULL,
	Nome VARCHAR(100) NULL,
	CPF VARCHAR(100) NULL,
	Email VARCHAR(100) NULL,
	Telefone VARCHAR(50) NULL,
	DataDeNascimento VARCHAR(50)NULL,
	Endereco VARCHAR(100) NULL,
	Complemento VARCHAR(100),
	Setor VARCHAR(100)NULL,
	CEP VARCHAR(50)NULL,
	NomeUsuario VARCHAR(100)NOT NULL,
	Senha VARCHAR(150)NOT NULL

)
GO
/*#################################################################################################################################*/
CREATE TABLE SEXO
(
	Id int PRIMARY KEY IDENTITY(1,1)NOT NULL,
	SEXO VARCHAR (50) NULL
)
GO

/*#################################################################################################################################*/

CREATE TABLE TURMA
(
	Id int PRIMARY KEY IDENTITY (1,1) NOT NULL,
	Id_TURNO INT NULL,
	Serie VARCHAR(100) NULL
)
GO
/*#################################################################################################################################*/
CREATE TABLE TURNO
(
	Id INT PRIMARY KEY IDENTITY (1,1)NOT NULL,
	Nome_Turno VARCHAR(100) NULL
)
/*#################################################################################################################################*/

CREATE TABLE UF
(
	Id int PRIMARY KEY IDENTITY(1,1) NOT NULL,
	NomeUF VARCHAR(50)NULL,
	AbreviacaoUF VARCHAR(10)NULL
)
GO

/*#################################################################################################################################*/
SELECT*FROM AGENTEPEDAGOGICO
GO
SELECT*FROM ALUNO
GO
SELECT*FROM BIMESTRE
GO
SELECT*FROM CIDADE
GO
SELECT*FROM DIARIOELE
GO
SELECT*FROM DISCIPLINA
GO
SELECT*FROM FREQUENCIA
GO
SELECT*FROM Nota
GO
SELECT*FROM OCORRENCIA
GO
SELECT*FROM PLANODEAULA
GO
SELECT*FROM PROFESSOR
GO
SELECT*FROM SEXO
GO
SELECT*FROM TURMA
GO
SELECT*FROM TURNO
GO
SELECT*FROM UF
GO
