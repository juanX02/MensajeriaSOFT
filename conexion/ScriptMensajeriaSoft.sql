CREATE DATABASE MensajeriaSoft
GO
USE MensajeriaSoft;
GO

CREATE TABLE [Estados]
(
	[Id] INT NOT NULL IDENTITY (1, 1),
	[Nombre] NVARCHAR(50) NOT NULL,
	CONSTRAINT [PK_Estados] PRIMARY KEY CLUSTERED ([Id])
)
GO

CREATE TABLE [Grupos]
(
	[Id] INT NOT NULL IDENTITY (1, 1),
	[Nombre] NVARCHAR(50) NOT NULL UNIQUE,
	CONSTRAINT [PK_Grupos] PRIMARY KEY CLUSTERED ([Id])
)
GO

CREATE TABLE [Personas]
(
	[Id] INT NOT NULL IDENTITY (1, 1),
	[Cedula] NVARCHAR(15) NOT NULL UNIQUE,
	[Nombre] NVARCHAR(50) NOT NULL,
	CONSTRAINT [PK_Personas] PRIMARY KEY CLUSTERED ([Id])
)
GO

INSERT INTO [Estados] ([Nombre]) VALUES ('Enviado');
INSERT INTO [Estados] ([Nombre]) VALUES ('Recibido');
INSERT INTO [Estados] ([Nombre]) VALUES ('Leido');

Select * from [Estados];