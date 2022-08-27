/*#####################################################################################################################################

											CRIAÇÃO DAS PROCEDURES DO BANCO

#####################################################################################################################################*/

/*											CRIAÇÃO DAS PROCEDURES DE INSERT DE TODAS AS TABELAS									 */

/*###################################################################################################################################*/

CREATE PROCEDURE SP_InserirAgente
	@Id INT OUTPUT,
	@NomeAgente VARCHAR(150),
	@NomeUsuario VARCHAR(100),
	@Senha VARCHAR(150)
AS
	INSERT INTO AGENTEPEDAGOGICO(NomeAgente,NomeUsuario,Senha)
	VALUES(@NomeAgente,@NomeUsuario,@Senha)
	SET @Id = (SELECT @@IDENTITY)
	--SELECT @@IDENTITY
GO

/*###################################################################################################################################*/

CREATE PROCEDURE SP_InserirAluno
	@Id INT OUTPUT,
	@NomeAluno VARCHAR(100) ,
	@DataDeNascimento VARCHAR(50),
	@TelefoneResponsavel VARCHAR(50) ,
	@CPF VARCHAR(100),
	@Email VARCHAR(100) ,
	@NomeDoResponsavel VARCHAR(100),
	@Id_Sexo INT,
	@Id_Cidade INT ,
	@EnderecoAluno VARCHAR(100),
	@Complemento VARCHAR(100),
	@Setor VARCHAR(100),
	@Numero INT ,
	@CEP VARCHAR(50),
	@Senha VARCHAR(150),
	@Id_Turma INT,
	@NomeUsuario VARCHAR(100)
AS
	INSERT INTO ALUNO(NomeAluno, DataDeNascimento,TelefoneResponsavel,CPF,Email,NomeDoResponsavel,Id_Sexo,Id_Cidade,EnderecoAluno,Setor,Numero,CEP,Senha,Id_Turma,NomeUsuario)
	Values(@NomeAluno,@DataDeNascimento,@TelefoneResponsavel,@CPF,@Email,@NomeDoResponsavel,@Id_Sexo,@Id_Cidade,@EnderecoAluno,@Setor,@Numero,@CEP,@Senha,@Id_Turma,@NomeUsuario)
	SET @Id = (SELECT @@IDENTITY)
	--SELECT @@IDENTITY
GO

/*###################################################################################################################################*/

CREATE PROCEDURE SP_InserirBimestre 
	@Id INT OUTPUT,
	@Bimestre VARCHAR(100)
AS
INSERT INTO BIMESTRE(Bimestre)
	VALUES(@Bimestre)
	SET @Id = (SELECT @@IDENTITY)
	--SELECT @@IDENTITY
GO

/*###################################################################################################################################*/

CREATE PROCEDURE SP_InserirCidade 
	@Id INT OUTPUT,
	@Id_UF INT,
	@NomeCidade VARCHAR(50)
AS
INSERT INTO CIDADE(Id_UF,NomeCidade)
	VALUES(@Id_UF,@NomeCidade)
	SET @Id = (SELECT @@IDENTITY)
	--SELECT @@IDENTITY
GO

/*###################################################################################################################################*/

CREATE PROCEDURE SP_InserirDiario
	@Id INT OUTPUT,
	@Id_Disciplina INT,
	@Id_Professor INT ,
	@Id_Turma INT
AS
	INSERT INTO DIARIOELE(Id_Disciplina,Id_Professor,Id_Turma)
	VALUES(@Id_Disciplina,@Id_Professor,@Id_Turma)
GO

/*###################################################################################################################################*/

CREATE PROCEDURE SP_InserirDisciplina
	@Id INT OUTPUT,
	@NomeDisciplina VARCHAR(50)
AS
	INSERT INTO DISCIPLINA(NomeDisciplina)
	VALUES(@NomeDisciplina)
	SET @Id = (SELECT @@IDENTITY)
	--SELECT @@IDENTITY
GO

/*###################################################################################################################################*/

CREATE PROCEDURE SP_InserirFrequencia
	@Id INT OUTPUT,
	@Id_Aluno INT,
	@Id_Diario INT,
	@Faltas INT,
	@Data_ DATETIME
AS
	INSERT INTO FREQUENCIA(Id_Aluno,Id_Diario,Faltas,Data_)/* DAR UMA OLHADA ANTES DE CRIAR */
	VALUES(@Id_Aluno,@Id_Diario,@Faltas,GETDATE())
	SET @Id = (SELECT @@IDENTITY)
	--SELECT @@IDENTITY
GO

/*###################################################################################################################################*/

CREATE PROC SP_InserirNota
	@Id INT OUTPUT,
	@Id_Aluno INT,
	@Id_Turma INT,
	@Id_Diario INT,
	@Nota float
AS
	INSERT INTO Nota(Id_Aluno,Id_Turma,Id_Diario,Nota)
	VALUES(@Id_Aluno,@Id_Turma,@Id_Diario,CONVERT(FLOAT, ROUND(@Nota, 2)))
	SET @Id = (SELECT @@IDENTITY)
	--SELECT @@IDENTITY
GO

/*###################################################################################################################################*/

CREATE PROC SP_InserirOcorrencia
	@Id INT OUTPUT,
	@Id_Aluno INT,
	@Id_Diario INT,
	@Descricao VARCHAR(100)
AS
	INSERT INTO OCORRENCIA(Id_Aluno,Id_Diario,Descricao)
	VALUES(@Id_Aluno,@Id_Diario,@Descricao)
	SET @Id = (SELECT @@IDENTITY)
	--SELECT @@IDENTITY
GO

/*###################################################################################################################################*/

CREATE PROC SP_InserirPlanoDeAula 
	@Id INT OUTPUT,
	@Id_professor INT ,
	@Id_Diario INT ,
	@Conteudo VARCHAR(100)
AS
	INSERT INTO PLANODEAULA(Id_professor,Id_Diario,Conteudo)
	VALUES(@Id_professor,@Id_Diario,@Conteudo)
	SET @Id = (SELECT @@IDENTITY)
	--SELECT @@IDENTITY
GO

/*###################################################################################################################################*/

CREATE PROC SP_InserirProfessor
	@Id INT OUTPUT,
	@Id_Sexo INT,
	@Id_Cidade INT,
	@Nome VARCHAR(100),
	@CPF VARCHAR(100),
	@Email VARCHAR(100),
	@Telefone VARCHAR(50),
	@DataDeNascimento VARCHAR(100),
	@Endereco VARCHAR(100),
	@Setor VARCHAR(100),
	@CEP VARCHAR(50),
	@Senha VARCHAR(150),
	@NomeUsuario VARCHAR(100)
AS 
	INSERT INTO PROFESSOR(Id_Sexo,Id_Cidade,Nome,CPF,Email,Telefone,DataDeNascimento,Endereco,Setor,CEP,Senha,NomeUsuario)
	VALUES(@Id_Sexo,@Id_Cidade,@Nome,@CPF,@Email,@Telefone,@DataDeNascimento,@Endereco,@Setor,@CEP,@Senha,@NomeUsuario)
	SET @Id = (SELECT @@IDENTITY)
	--SELECT @@IDENTITY
GO


/*###################################################################################################################################*/

CREATE PROC SP_InserirSexo 
	@Id int output,
	@Sexo varchar(50)
AS
	INSERT INTO Sexo(Sexo)
	VALUES(@Sexo)
	SET @Id = (SELECT @@IDENTITY)
	--SELECT @@IDENTITY
GO

/*###################################################################################################################################*/

CREATE PROC SP_InserirTurma
	@Id int OUTPUT ,
	@Serie varchar(100),
	@Id_Turno INT
As
	INSERT INTO Turma(Serie,Id_TURNO)
	VALUES(@Serie,@Id_Turno)
	SET @Id = (SELECT @@IDENTITY)
	--SELECT @@IDENTITY
GO

/*###################################################################################################################################*/

CREATE PROC SP_InseirTurno
	@Id int  OUTPUT,
	@Nome_Turno varchar(100)
AS
	INSERT INTO TURNO(Nome_Turno)
	VALUES(@Nome_Turno)
	SET @Id = (SELECT @@IDENTITY)
	--SELECT @@IDENTITY
GO

/*EXEC SP_InseirTurno 0,'MATUTINO'
GO*/
/*EXEC SP_InseirTurno 0,'VESPERTINO'
GO*/

/*###################################################################################################################################*/

CREATE PROC SP_InseirUF
	@Id int  OUTPUT,
	@NomeUF varchar(50),
	@AbreviacaoUF VARCHAR(10)
AS
	INSERT INTO UF(NomeUF,AbreviacaoUF)
	VALUES(@NomeUF,@AbreviacaoUF)
	SET @Id = (SELECT @@IDENTITY)
	--SELECT @@IDENTITY
GO

/*EXEC SP_InseirUF 0,'TO'
GO*/

/*###################################################################################################################################*/

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
