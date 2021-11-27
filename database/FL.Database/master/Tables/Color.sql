CREATE TABLE [master].[Color] (
    [Id]           INT IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (256)     NOT NULL,
    [ColorCode]         NVARCHAR (256)     NOT NULL,

    CONSTRAINT [PK_Color] PRIMARY KEY CLUSTERED ([Id] ASC),
);