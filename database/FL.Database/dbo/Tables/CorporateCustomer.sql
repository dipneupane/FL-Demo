CREATE TABLE [dbo].[CorporateCustomer] (
    [Id]                      BIGINT IDENTITY (1, 1) NOT NULL,
    [CompanyName]             NVARCHAR (256) NOT NULL,
    [CompanyAddress]          NVARCHAR (256) NOT NULL,
    [CompanyPhone]            NVARCHAR (256) NOT NULL,
    [CompanyFax]              NVARCHAR (256) NOT NULL,
    [ShippingMethodTypeId]    INT     NOT NULL,
    [BuyerName]               NVARCHAR (256) NOT NULL,
    [AspNetUserId]            BIGINT,

    CONSTRAINT [PK_CorporateCustomer] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_CorporateCustomer_AspNetUsers_AspNetUserId] FOREIGN KEY ([AspNetUserId]) REFERENCES [auth].[AspNetUsers] ([Id]) ON DELETE NO ACTION,
);