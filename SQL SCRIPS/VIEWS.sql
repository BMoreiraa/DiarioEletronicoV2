/*###################################################################################################################################*/
					/*CRIAÇÃO DE UMA VIEW PARA BUSCAR ALUNO QUE SEJAM DA MESMA TURMA */
/*###################################################################################################################################*/

CREATE VIEW ALUNO_TURMA AS
	SELECT AL.NomeAluno, TM.Serie
	FROM ALUNO AS AL, TURMA AS TM
	WHERE TM.Id = AL.Id_Turma
GO


SELECT * FROM ALUNO_TURMA

/*###################################################################################################################################*/	
					/*CRIAÇÃO DE UMA VIEW PARA BUSCAR CIDADE DE UM UF */
           
CREATE VIEW CidadeUF AS
	SELECT CD.NomeCidade,UF.AbreviacaoUF 
	FROM CIDADE AS CD,UF AS UF 
	WHERE CD.Id_UF = UF.Id;
GO

SELECT * FROM CidadeUF

/*CREATE OR ALTER  OR ALTER proc SP_BuscarCidadeUF
	@filtro varchar(250) = ''
	AS
		SELECT * from CidadeUF WHERE NomeCidade LIKE  + @filtro + '%'  OR AbreviacaoUF LIKE  '%' + @filtro+ '%'
GO*/
/*###################################################################################################################################*/ 

CREATE VIEW PROFESSOR_TURMA AS
	SELECT PF.Nome, TM.Serie 
	FROM PROFESSOR AS PF, DIARIOELE AS DE, TURMA AS TM
	WHERE PF.Id = DE.Id_Professor AND TM.Id = DE.Id_Professor;
GO
SELECT * FROM PROFESSOR_TURMA

/*###################################################################################################################################*/
/*###################################################################################################################################*/
/*###################################################################################################################################*/

SELECT PT.Nome,ALT.NomeAluno
FROM PROFESSOR_TURMA AS PT, ALUNO_TURMA AS ALT
WHERE PT.Serie = ALT.Serie
 

