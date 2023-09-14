CREATE DATABASE inlock_games_dbFirst_manha

USE inlock_games_dbFirst_manha

CREATE TABLE Estudio
(
	IdEstudio UNIQUEIDENTIFIER PRIMARY KEY,
	Nome VARCHAR(100) NOT NULL,
)

CREATE TABLE Jogo
(
	IdJogo UNIQUEIDENTIFIER PRIMARY KEY,
	IdEstudio UNIQUEIDENTIFIER FOREIGN KEY REFERENCES Estudio(IdEstudio),
	Nome VARCHAR(100) NOT NULL,
	Descricao VARCHAR(100) NOT NULL,
	DataLancamento VARCHAR(100) NOT NULL,
	Valor SMALLMONEY NOT NULL
)

CREATE TABLE TipoUsuario
(
	IdTipoUsuario UNIQUEIDENTIFIER PRIMARY KEY,
	Titulo VARCHAR(100) NOT NULL
)

CREATE TABLE Usuario
(
	IdUsuario UNIQUEIDENTIFIER PRIMARY KEY,
	IdTipoUsuario UNIQUEIDENTIFIER FOREIGN KEY REFERENCES TipoUsuario(IdTipoUsuario),
	Email VARCHAR(100) NOT NULL,
	Senha VARCHAR(100) NOT NULL
)

INSERT INTO Estudio
VALUES (NEWID(), 'SENAI'), (NEWID(), 'SESI'),(NEWID(), 'SEBRAE')

SELECT * FROM Estudio


INSERT INTO Jogo
VALUES  (NEWID(), '2B77A340-9F0D-4AD5-AC2C-6A9382220AA8', 'PING PONG', 'JOGO LEGAL', '2023-01-01',500), 
		(NEWID(), '2B77A340-9F0D-4AD5-AC2C-6A9382220AA8', 'JUCAMOM', 'CA�A POKEMON', '2022-02-1',2.99)

SELECT * FROM Jogo


INSERT INTO TipoUsuario
VALUES (NEWID(),'adiministrador'), (NEWID(),'Comum')

SELECT * FROM TipoUsuario


INSERT INTO Usuario
VALUES (NEWID(),'66D0205D-44BE-43CA-A912-B40681C00A2D','adm@adm.com','admin'), 
		(NEWID(),'5388729A-BEB1-46FF-8B85-A07D8B848E4F','comum@comum.com','comum')

SELECT * FROM Usuario