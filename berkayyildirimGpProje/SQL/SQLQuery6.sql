USE [Siteyönetim]
GO

/****** Object:  Table [dbo].[Yonetici]    Script Date: 29.05.2019 19:53:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE Yonetici
(
	id int IDENTITY(1,1) NOT NULL,
	Adi nchar (20) NULL,
	Soyadi nchar (20) NULL,
	Mail nchar (25) NULL,
	Telefon nchar (11) NULL,
	Tc nchar (11) NULL,
	iban nchar (20) NULL
) ON PRIMARY

GO


