USE [Siteyönetim]
GO

/****** Object:  Table [dbo].[kisibilgi]    Script Date: 29.05.2019 19:45:02 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE kisibilgi
(
	id int IDENTITY(1,1) NOT NULL,
	Ad nchar(20) NOT NULL,
	Soyad nchar(20) NOT NULL,
	Blok nchar(1) NOT NULL,
	Daire nchar(1) NOT NULL,
	Telefon nchar(12) NOT NULL,
	Mail nchar(40) NOT NULL,
	Borclar nchar (10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


