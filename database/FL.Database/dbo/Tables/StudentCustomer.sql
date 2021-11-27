CREATE TABLE [dbo].[StudentCustomer] (
    [Id]               BIGINT IDENTITY (1, 1) NOT NULL,
    [Name]             NVARCHAR (256) NOT NULL,
    [School]           NVARCHAR (256) NOT NULL,
    [Address]          NVARCHAR (256) NOT NULL,
    [AspNetUserId]     BIGINT NOT NULL,

    CONSTRAINT [PK_StudentCustomer] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_StudentCustomer_AspNetUsers_AspNetUserId] FOREIGN KEY ([AspNetUserId]) REFERENCES [auth].[AspNetUsers] ([Id]) ON DELETE NO ACTION,
);