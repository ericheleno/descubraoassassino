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
--              de locais
-- =============================================
CREATE PROCEDURE [dbo].[P_MANTER_LOCAL] 
	@id_local int,
	@nm_local VARCHAR(100),
	@fl_excluir INT
AS
BEGIN
	SET NOCOUNT ON;

	IF (@id_local = 0)
	BEGIN 
		INSERT INTO [dbo].[local]
                    ([nm_local])
             VALUES
                    (@nm_local)

		SELECT SCOPE_IDENTITY()
	END
	ELSE
	BEGIN
		IF (@fl_excluir = 1)
		BEGIN
			DELETE FROM [dbo].[local]
				  WHERE [id_local] = @id_local
		END
		ELSE
		BEGIN
			UPDATE [dbo].[local]
			   SET [nm_local] = @nm_local
			 WHERE [id_local] = @id_local
		END
	END	  
END
GO
