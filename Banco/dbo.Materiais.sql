CREATE TABLE [dbo].[Materiais] (
    [Id]        INT             IDENTITY (1, 1) NOT NULL,
    [nome]      NCHAR (30)      NULL,
    [descricao] VARCHAR (MAX)   NULL,
    [foto]      VARBINARY (MAX) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
