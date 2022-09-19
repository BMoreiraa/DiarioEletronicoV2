CREATE PROCEDURE SP_BuscarAgente
	@filtro varchar(250) = ''
AS
	SELECT Id,Senha,NomeAgente,NomeUsuario from AgentePedagogico WHERE  Id like '%' +@filtro + '%' OR NomeUsuario LIKE  '' + @filtro + ''
GO----OK
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE SP_BuscarAluno /*buscando por nome, id, NOME DE USUARIO */
	@filtro varchar(250) = ''
AS
	SELECT Id,NomeAluno, DataDeNascimento,TelefoneResponsavel,cpf,Email,NomeDoResponsavel,Id_Sexo,Id_Cidade,EnderecoAluno,setor,numero,cep,senha,Id_Turma,NomeUsuario 
	FROM Aluno WHERE Id LIKE '%'+ @filtro + '%' or NomeUsuario LIKE + @filtro + '%'
GO 
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
CREATE PROC SP_BuscarProfessor
 @filtro varchar(250) = ''
AS
	SELECT Id,Id_Sexo,Id_Cidade,Nome,CPF,Email,Telefone,DataDeNascimento,Endereco,Complemento,setor,CEP,Senha,NomeUsuario from Professor WHERE Id '%' + LIKE  @filtro + '%' OR NomeUsuario like + @filtro+'%'
GO