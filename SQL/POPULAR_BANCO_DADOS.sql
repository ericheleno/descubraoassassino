USE [DescubraAssassino]
GO

-- CRIMES

INSERT INTO [dbo].[crime] ([nm_crime],[ds_crime]) 
	 VALUES ('Assassinato de Sean Bean','O empresário Sean Bean foi assassinado e o corpo dele foi deixado na frente da delegacia de polícia.');

INSERT INTO [dbo].[crime] ([nm_crime] ,[ds_crime])
     VALUES ('Assassinato de Don Alguém','Don Alguém foi assassinado e o corpo dele nunca foi encontrado.');

-- SUSPEITOS

INSERT INTO [dbo].[suspeito]([nm_suspeito])
     VALUES ('Esqueleto');

INSERT INTO [dbo].[suspeito]([nm_suspeito])
     VALUES ('Khan');

INSERT INTO [dbo].[suspeito]([nm_suspeito])
     VALUES ('Darth vader');

INSERT INTO [dbo].[suspeito]([nm_suspeito])
     VALUES ('Sideshow Bob');

INSERT INTO [dbo].[suspeito]([nm_suspeito])
     VALUES ('Coringa');

INSERT INTO [dbo].[suspeito]([nm_suspeito])
     VALUES ('Duende Verde');

-- LOCAIS

INSERT INTO [dbo].[local]([nm_local])
     VALUES ('Etérnia');

INSERT INTO [dbo].[local]([nm_local])
     VALUES ('Vulcano');

INSERT INTO [dbo].[local]([nm_local])
     VALUES ('Tatooine');

INSERT INTO [dbo].[local]([nm_local])
     VALUES ('Springfield');

INSERT INTO [dbo].[local]([nm_local])
     VALUES ('Gotham');

INSERT INTO [dbo].[local]([nm_local])
     VALUES ('Nova York');

INSERT INTO [dbo].[local]([nm_local])
     VALUES ('Sibéria');

INSERT INTO [dbo].[local]([nm_local])
     VALUES ('Machu Picchu');

INSERT INTO [dbo].[local]([nm_local])
     VALUES ('Show do Katinguele');

INSERT INTO [dbo].[local]([nm_local])
     VALUES ('São Paulo');

-- ARMAS

INSERT INTO [dbo].[arma]([nm_arma])
     VALUES ('Cajado Devastador');

INSERT INTO [dbo].[arma]([nm_arma])
     VALUES ('Phaser');

INSERT INTO [dbo].[arma]([nm_arma])
     VALUES ('Peixeira');

INSERT INTO [dbo].[arma]([nm_arma])
     VALUES ('Trezoitão');

INSERT INTO [dbo].[arma]([nm_arma])
     VALUES ('Sabre de Luz');

INSERT INTO [dbo].[arma]([nm_arma])
     VALUES ('Bomba');


GO

SELECT *
  FROM crime

SELECT *
  FROM suspeito

SELECT *
  FROM local

SELECT *
  FROM arma