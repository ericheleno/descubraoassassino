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
--              de suspeitos
-- =============================================
CREATE PROCEDURE [dbo].[P_MANTER_SUSPEITO] 
	@id_suspeito int,
	@nm_suspeito VARCHAR(100),
	@fl_excluir INT
AS
BEGIN
	SET NOCOUNT ON;

	IF (@id_suspeito = 0)
	BEGIN 
		INSERT INTO [dbo].[suspeito]
                    ([nm_suspeito])
             VALUES
                    (@nm_suspeito)

		SELECT SCOPE_IDENTITY()
	END
	ELSE
	BEGIN
		IF (@fl_excluir = 1)
		BEGIN
			DELETE FROM [dbo].[suspeito]
				  WHERE [id_suspeito] = @id_suspeito
		END
		ELSE
		BEGIN
			UPDATE [dbo].[suspeito]
			   SET [nm_suspeito] = @nm_suspeito
			 WHERE [id_suspeito] = @id_suspeito
		END
	END	  
END
GO
