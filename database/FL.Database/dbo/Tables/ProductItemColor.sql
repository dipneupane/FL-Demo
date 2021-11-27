CREATE TABLE [dbo].[ProductItemColor] (
    [Id]               BIGINT IDENTITY (1, 1) NOT NULL,
    [ProductItemId]   BIGINT NOT NULL,
    [ColorId]   INT NOT NULL,

    CONSTRAINT [PK_ProductItemColor] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ProductItemColor_ProductItem_ProductItemId] FOREIGN KEY ([ProductItemId]) REFERENCES [dbo].[ProductItem] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_ProductItemColor_Color_ColorId] FOREIGN KEY ([ColorId]) REFERENCES [master].[Color] ([Id]) ON DELETE NO ACTION
);