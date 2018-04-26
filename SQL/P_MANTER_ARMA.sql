USE [DescubraAssassino]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Eric H. Silva
-- Create date: 25 Abr 2018
-- Description:	Procedure que mantém cadastro
--              de armas
-- =============================================
CREATE PROCEDURE [dbo].[P_MANTER_ARMA] 
	@id_arma int,
	@nm_arma VARCHAR(100),
	@fl_excluir INT
AS
BEGIN
	SET NOCOUNT ON;

	IF (@id_arma = 0)
	BEGIN 
		INSERT INTO [dbo].[arma]
                    ([nm_arma])
             VALUES
                    (@nm_arma)

		SELECT SCOPE_IDENTITY()
	END
	ELSE
	BEGIN
		IF (@fl_excluir = 1)
		BEGIN
			DELETE FROM [dbo].[arma]
				  WHERE [id_arma] = @id_arma
		END
		ELSE
		BEGIN
			UPDATE [dbo].[arma]
			   SET [nm_arma] = @nm_arma
			 WHERE [id_arma] = @id_arma
		END
	END	  
END
GO
