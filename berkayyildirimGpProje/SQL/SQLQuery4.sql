USE [Siteyönetim]
GO

/****** Object:  Table [dbo].[Personeller]    Script Date: 29.05.2019 19:49:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE Personeller 
(
	id int IDENTITY(1,1) NOT NULL,
	Adi nchar(20) NULL,
	Soyadi nchar(20) NULL,
	Adres nchar(40) NULL,
	Telefon nchar(10) NULL,
	ÝS nchar(20) NULL
) ON PRIMARY

GO


