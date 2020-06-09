USE [master]
GO
/****** Object:  Database [Chatbot]    Script Date: 09/06/2020 18:33:47 ******/
CREATE DATABASE [Chatbot]
GO
USE [Chatbot]
GO
/****** Object:  Table [dbo].[Preguntas]    Script Date: 09/06/2020 18:33:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Preguntas](
	[IdPregunta] [int] IDENTITY(1,1) NOT NULL,
	[Pregunta] [varchar](500) NULL,
	[Respuesta] [varchar](500) NULL,
	[Aleatorio] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdPregunta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[SP_FIND_RESPONSE]    Script Date: 09/06/2020 18:33:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_FIND_RESPONSE]
	@question VARCHAR(500)
AS
 
BEGIN
	IF @question IS NOT NULL
		BEGIN
			IF NOT EXISTS (SELECT TOP 1 Respuesta FROM Preguntas WHERE Pregunta LIKE '%'+@question+'%')
				BEGIN
					SELECT TOP 1 Respuesta FROM Preguntas WHERE Aleatorio = 1 ORDER BY NEWID()
				END
			ELSE
				BEGIN
					SELECT TOP 1 Respuesta FROM Preguntas WHERE Pregunta LIKE '%'+@question+'%'
				END
		END
END
GO
/****** Object:  StoredProcedure [dbo].[SP_INSERT_QUESTION]    Script Date: 09/06/2020 18:33:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_INSERT_QUESTION]
	@question VARCHAR(200),
	@answer VARCHAR(200)
AS

BEGIN
	IF @question IS NOT NULL AND @answer IS NOT NULL
		BEGIN 
			INSERT INTO Preguntas(Pregunta, Respuesta)
			VALUES (@question,@answer)
		END
	ELSE
		BEGIN
			RAISERROR(N'Ningun campo puede ser nulo',10,1)

		END
END
GO
USE [master]
GO
ALTER DATABASE [Chatbot] SET  READ_WRITE 
GO
