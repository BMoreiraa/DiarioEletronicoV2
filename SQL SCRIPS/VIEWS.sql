/*#################################################################################################################################################*/
					/*CRIAÇÃO DE UMA VIEW PARA BUSCAR ALUNO QUE SEJAM DA MESMA TURMA */
/*#################################################################################################################################################*/

CREATE VIEW ALUNO_TURMA AS
	SELECT AL.NomeAluno,TM.Serie 
	FROM ALUNO AS AL, PROFESSOR AS PF, TURMA AS TM, DIARIOELE AS DE
	WHERE DE.Id_Professor = PF.Id AND DE.Id_Turma = TM.Id;
GO

/*#################################################################################################################################################*/	
					/*CRIAÇÃO DE UMA VIEW PARA BUSCAR CIDADE DE UM UF */
           
CREATE VIEW CidadeUF AS
SELECT CD.NomeCidade,UF.AbreviacaoUF 
FROM CIDADE AS CD,UF AS UF 
WHERE CD.Id_UF = UF.Id;
GO

/*#################################################################################################################################################*/          
CREATE OR ALTER proc SP_BuscarCidadeUF
@filtro varchar(250) = ''
AS
	SELECT * from CidadeUF WHERE NomeCidade LIKE  + @filtro + '%'  OR AbreviacaoUF LIKE  '%' + @filtro+ '%'
GO
 EXEC SP_BuscarCidadeUF 'RJ'

