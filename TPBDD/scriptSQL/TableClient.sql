USE [TPBDD]
GO

/****** Object:  Table [dbo].[PROFIL]    Script Date: 11/11/2018 17:19:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [client](
	[Pseudo] [nvarchar](25) NOT NULL,
	[MotDePasse] [nvarchar](20) NOT NULL,
	[Nom] [nvarchar](50) NOT NULL,
	[Prenom] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](320) NOT NULL,
	[QSecrete] [nvarchar](100),
	[index] [int] NOT NULL IDENTITY(1000,1),
 CONSTRAINT [PK_PROFIL] PRIMARY KEY CLUSTERED 
(
	[index] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


