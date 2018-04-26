
-- CRIAÇÃO BANCO DE DADOS

IF((SELECT COUNT(*) FROM sys.databases WHERE name = 'DescubraAssassino') = 0)
BEGIN
	CREATE DATABASE DescubraAssassino
END

GO

-- CRIAR TABELAS

USE DescubraAssassino



CREATE TABLE arma
(
	id_arma              integer IDENTITY (1,1) ,
	nm_arma              varchar(100)  NULL 
)
go


ALTER TABLE arma
	ADD CONSTRAINT PKarma PRIMARY KEY  CLUSTERED (id_arma ASC)
go


CREATE NONCLUSTERED INDEX ix_arma ON arma
(
	nm_arma               ASC
)
go


CREATE TABLE crime
(
	id_crime             integer IDENTITY (1,1) ,
	nm_crime             varchar(100)  NULL ,
	ds_crime             varchar(250)  NULL 
)
go


ALTER TABLE crime
	ADD CONSTRAINT PKcrime PRIMARY KEY  CLUSTERED (id_crime ASC)
go


CREATE NONCLUSTERED INDEX ix_crime ON crime
(
	nm_crime              ASC
)
go


CREATE TABLE local
(
	id_local             integer IDENTITY (1,1) ,
	nm_local             varchar(100)  NULL 
)
go


ALTER TABLE local
	ADD CONSTRAINT PKlocal PRIMARY KEY  CLUSTERED (id_local ASC)
go


CREATE NONCLUSTERED INDEX ix_local ON local
(
	nm_local              ASC
)
go


CREATE TABLE suspeito
(
	id_suspeito          integer IDENTITY (1,1) ,
	nm_suspeito          varchar(100)  NULL 
)
go


ALTER TABLE suspeito
	ADD CONSTRAINT PKsuspeito PRIMARY KEY  CLUSTERED (id_suspeito ASC)
go


CREATE NONCLUSTERED INDEX ix_suspeito ON suspeito
(
	nm_suspeito           ASC
)
go

