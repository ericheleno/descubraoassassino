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
--              de crimes
-- =============================================
CREATE PROCEDURE [dbo].[P_MANTER_CRIME] 
	@id_crime int,
	@nm_crime VARCHAR(100),
	@ds_crime VARCHAR(250),
	@fl_excluir INT
AS
BEGIN
	SET NOCOUNT ON;

	IF (@id_crime = 0)
	BEGIN 
		INSERT INTO [dbo].[crime]
                    ([nm_crime]
                    ,[ds_crime])
             VALUES
                    (@nm_crime
                    ,@ds_crime)

		SELECT SCOPE_IDENTITY()
	END
	ELSE
	BEGIN
		IF (@fl_excluir = 1)
		BEGIN
			DELETE FROM [dbo].[crime]
				  WHERE [id_crime] = @id_crime
		END
		ELSE
		BEGIN
			UPDATE [dbo].[crime]
			   SET [nm_crime] = @nm_crime
				   ,[ds_crime] = @ds_crime
			 WHERE [id_crime] = @id_crime
		END
	END	  
END
GO
