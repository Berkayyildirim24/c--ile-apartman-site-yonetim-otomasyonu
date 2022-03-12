USE [Siteyönetim]
GO

/****** Object:  Table [dbo].[Mesajlar]    Script Date: 29.05.2019 19:47:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE Mesajlar
(
	id int IDENTITY(1,1) NOT NULL,
	AdSoyad varchar(50) NULL,
	Mesaj varchar (1000) NULL
) ON PRIMARY

GO

SET ANSI_PADDING OFF
GO


