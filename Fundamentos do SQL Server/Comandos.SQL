CREATE DATABASE [Curso_Balta]

GO

USE [Curso_Balta]

GO

CREATE TABLE [Categoria](
    [Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    [Nome] NVARCHAR(50) NOT NULL
)

CREATE TABLE [Aluno](
    [Id_Aluno] INT NOT NULL IDENTITY(1,1),
    [Nome] NVARCHAR(80) NOT NULL,
    [Email] NVARCHAR(180) NOT NULL UNIQUE,
    [Nascimento] DATETIME NULL,
    [Ativo] BIT NOT NULL DEFAULT(0)

--  NOMEANDO A PK                  CRIANDO PK COMPOSTA
    CONSTRAINT [PK_ID_EMAIL_ALUNO] PRIMARY KEY([Id_Aluno] , [Email])
)

GO

-- Pode usar ADD, DROP, ALTER
ALTER TABLE [Aluno]
ADD [Documento] NVARCHAR(11)

GO 

CREATE TABLE [Curso](
    [Id_Curso] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
    [Nome] NVARCHAR(80),
    [CategoriaId] INT NOT NULL

    CONSTRAINT [FK_CategoriaId] FOREIGN KEY ([CategoriaId])
    REFERENCES [Categoria]([Id])
)

GO

CREATE TABLE [ProgessoCurso](
    [AlunoId] INT NOT NULL,
    [CursoId] INT NOT NULL,
    [Progresso] INT NOT NULL,
    [UltimaAtualizacao] DATETIME NOT NULL DEFAULT(GETDATE())

    CONSTRAINT PK_ProgressoCurso PRIMARY KEY ([AlunoId], [CursoId])
)

GO

CREATE INDEX [IX_Aluno_Email] ON [Aluno]([Email])

GO

-- INSERINDO DADOS NAS TABELAS

INSERT INTO [Categoria]([Nome]) VALUES ('Backend')
INSERT INTO [Categoria]([Nome]) VALUES ('Frontend')
INSERT INTO [Categoria]([Nome]) VALUES ('Mobile')

INSERT INTO [Curso]([Nome], [CategoriaId]) VALUES ('Fundamentos do C#', 1)
INSERT INTO [Curso]([Nome], [CategoriaId]) VALUES ('Fundamentos do OOP', 1)
INSERT INTO [Curso]([Nome], [CategoriaId]) VALUES ('Angular', 2)
INSERT INTO [Curso]([Nome], [CategoriaId]) VALUES ('Flutter', 3)

GO

-- SELECTS:

SELECT * FROM [Categoria]
SELECT * FROM [Curso]
SELECT TOP 100
[Id_Curso], [Nome]
FROM [Curso]

GO

-- 