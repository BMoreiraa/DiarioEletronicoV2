/*#################################################################################################################################################*/
					/*CREA��O DE UAM VIEW PARA BUSCAR ALUNO POR TURMA */
/*#################################################################################################################################################*/

CREATE VIEW ALUNO_TURMA AS
	SELECT AL.NomeAluno,TM.Serie 
	FROM ALUNO AS AL, PROFESSOR AS PF, TURMA AS TM, DIARIOELE AS DE
	WHERE DE.Id_Professor = PF.Id AND DE.Id_Turma = TM.Id
GO

/*#################################################################################################################################################*/	
           

           