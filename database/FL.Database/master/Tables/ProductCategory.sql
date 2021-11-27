CREATE TABLE [master].[ProductCategory] (
    [Id]           INT IDENTITY (1, 1) NOT NULL,
    [Slug]         NVARCHAR (256)     NULL,
    [Name]         NVARCHAR (256)     NULL,

    CONSTRAINT [PK_ProductCategory] PRIMARY KEY CLUSTERED ([Id] ASC),
);