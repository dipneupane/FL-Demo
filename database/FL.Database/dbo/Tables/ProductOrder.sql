CREATE TABLE [dbo].[ProductOrder] (
    [Id]               BIGINT IDENTITY (1, 1) NOT NULL,
    [ProductItemId]    BIGINT NOT NULL,
    [Quantity]         INT NOT NULL,
    [Price]            DECIMAL NOT NULL,
    [VAT]              DECIMAL NOT NULL,
    [DISCOUNT]         DECIMAL NOT NULL,
    [AspNetUserId]     BIGINT NOT NULL

    CONSTRAINT [PK_ProductOrder] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ProductOrder_ProductItem_ProductItemId] FOREIGN KEY ([ProductItemId]) REFERENCES [dbo].[ProductItem] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_ProductOrder_AspNetUsers_AspNetUserId] FOREIGN KEY ([AspNetUserId]) REFERENCES [auth].[AspNetUsers] ([Id]) ON DELETE NO ACTION
);