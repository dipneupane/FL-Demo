CREATE TABLE [dbo].[ProductStock] (
    [Id]               BIGINT IDENTITY (1, 1) NOT NULL,
    [ProductItemId]    BIGINT NOT NULL,
    [Quantity]         INT NOT NULL,
    [UpdatedDate]      DATETIME NOT NULL,

    CONSTRAINT [PK_ProductStock] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ProductStock_ProductItem_ProductItemId] FOREIGN KEY ([ProductItemId]) REFERENCES [dbo].[ProductItem] ([Id]) ON DELETE NO ACTION
);