CREATE TABLE [dbo].[ProductItem] (
    [Id]               BIGINT IDENTITY (1, 1) NOT NULL,
    [ProductCategoryId]   INT NOT NULL,
    [Slug]           NVARCHAR (256) NOT NULL,
    [Name]          NVARCHAR (256) NOT NULL,
    [Description]          NVARCHAR (1000) NOT NULL,
    [Size]          NVARCHAR (256) NOT NULL,
    [Weight]          NVARCHAR (256) NOT NULL,
    [Price]         DECIMAL NOT NULL,

    CONSTRAINT [PK_ProductItem] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ProductItem_ProductCategory_ProductCategoryId] FOREIGN KEY ([ProductCategoryId]) REFERENCES [master].[ProductCategory] ([Id]) ON DELETE NO ACTION
);