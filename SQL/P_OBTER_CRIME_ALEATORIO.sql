USE [DescubraAssassino]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Eric H. Silva
-- Create date: 25 Abr 2018
-- Description:	Procedure que crime, suspeito,
--              local e arma aleatórios
-- =============================================
CREATE PROCEDURE [dbo].[P_OBTER_CRIME_ALEATORIO] 
	
AS

DECLARE @nm_crime AS VARCHAR(100)
DECLARE @ds_crime AS VARCHAR(250)
DECLARE @nm_suspeito AS VARCHAR(100)
DECLARE @nm_local AS VARCHAR(100)
DECLARE @nm_arma AS VARCHAR(100)

BEGIN
	SET NOCOUNT ON;

	-- CRIME

	SELECT TOP 1 @nm_crime = nm_crime, @ds_crime = ds_crime 
	  FROM crime
  ORDER BY NEWID()

  	-- SUSPEITO

	SELECT TOP 1 @nm_suspeito = nm_suspeito
	  FROM suspeito
  ORDER BY NEWID()

	-- LOCAL

	SELECT TOP 1 @nm_local = nm_local
	  FROM local
  ORDER BY NEWID()

	-- ARMA

	SELECT TOP 1 @nm_arma = nm_arma
	  FROM arma
  ORDER BY NEWID()

	-- RETORNA OS DADOS
	SELECT	@nm_crime AS nm_crime
		    , @ds_crime AS ds_crime
			, @nm_suspeito AS nm_suspeito
			, @nm_local AS nm_local
			, @nm_arma AS nm_arma

END
GO
