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
	INSERT INTO AgentePedagogico(NomeAgente,NomeUsuario,Senha)
	VALUES(@NomeAgente,@NomeUsuario,@Senha)
	SET @Id = (SELECT @@IDENTITY)
	--SELECT @@IDENTITY
GO

/*###################################################################################################################################*/

CREATE PROCEDURE SP_InserirAluno
	@Id int OUTPUT,
	@NomeAluno VARCHAR(100) ,
	@DataDeNascimento VARCHAR(50),
	@TelefoneResponsavel VARCHAR(50) ,
	@CPF VARCHAR(100),
	@Email VARCHAR(100) ,
	@NomeDoResponsavel VARCHAR(100),
	@Id_Sexo int,
	@Id_Cidade int ,
	@EnderecoAluno VARCHAR(100),
	@Complemento VARCHAR(100),
	@Setor VARCHAR(100),
	@Numero INT ,
	@CEP VARCHAR(50),
	@Senha VARCHAR(150),
	@Id_Turma int,
	@NomeUsuario VARCHAR(100)
AS
	INSERT INTO Aluno(NomeAluno, DataDeNascimento,TelefoneResponsavel,CPF,Email,NomeDoResponsavel,Id_Sexo,Id_Cidade,EnderecoAluno,Setor,Numero,CEP,Senha,Id_Turma,NomeUsuario)
	Values(@NomeAluno,@DataDeNascimento,@TelefoneResponsavel,@CPF,@Email,@NomeDoResponsavel,@Id_Sexo,@Id_Cidade,@EnderecoAluno,@Setor,@Numero,@CEP,@Senha,@Id_Turma,@NomeUsuario)
	SET @Id = (SELECT @@IDENTITY)
	--SELECT @@IDENTITY
GO