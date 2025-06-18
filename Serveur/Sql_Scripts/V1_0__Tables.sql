-- Création des tables de la base de données

USE SimpsonsEpisodeGenerator;
GO

CREATE TABLE Episodes (
	Id INT IDENTITY(1,1) NOT NULL,
	SeasonNumber INT NOT NULL,
	EpisodeNumber INT NOT NULL,
	Title NVARCHAR(255) NOT NULL,
	Description NVARCHAR(MAX) NULL,
	CONSTRAINT PK_Id PRIMARY KEY (Id)
);