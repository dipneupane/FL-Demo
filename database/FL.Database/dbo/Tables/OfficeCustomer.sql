CREATE TABLE [dbo].[OfficeCustomer] (
    [Id]                      BIGINT IDENTITY (1, 1) NOT NULL,
    [CompanyName]             NVARCHAR (256) NOT NULL,
    [CompanyAddress]          NVARCHAR (256) NOT NULL,
    [CompanyFax]              NVARCHAR (256) NOT NULL,
    [BuyerName]               NVARCHAR (256) NOT NULL,
    [AspNetUserId]            BIGINT,

    CONSTRAINT [PK_OfficeCustomer] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_OfficeCustomer_AspNetUsers_AspNetUserId] FOREIGN KEY ([AspNetUserId]) REFERENCES [auth].[AspNetUsers] ([Id]) ON DELETE NO ACTION,
);