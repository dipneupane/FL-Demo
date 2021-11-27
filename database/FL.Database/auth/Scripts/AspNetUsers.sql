Print 'Inserting AspNetUsers'
IF NOT EXISTS (SELECT * FROM [auth].[AspNetUsers]  WHERE [UserName] = 'fl-admin@gmail.com')
BEGIN
INSERT INTO [auth].[AspNetUsers] ([UserName],[NormalizedUserName],[Email],[NormalizedEmail], [EmailConfirmed],[PhoneNumberConfirmed],[TwoFactorEnabled],[LockoutEnabled],[AccessFailedCount], [PasswordHash], [SecurityStamp]) VALUES 
('fl-admin@gmail.com','FL-ADMIN@GMAIL.COM', 'fl-admin@gmail.com','FL-ADMIN@GMAIL.COM', 1, 1, 0, 0, 0, 'AQAAAAEAACcQAAAAEOMQum/FfDzkClwE+UtuDlSse0wwp4Ncjv4watkRJcOH8De1DJiKQi5siEknrwqFCw==', '27KRQBTZRUKFX6J7OFCEM6BN2N3CNXR4')
END

IF NOT EXISTS (SELECT * FROM [auth].[AspNetUsers]  WHERE [UserName] = 'fl-customer@gmail.com')
BEGIN
INSERT INTO [auth].[AspNetUsers] ([UserName],[NormalizedUserName],[Email],[NormalizedEmail], [EmailConfirmed],[PhoneNumberConfirmed],[TwoFactorEnabled],[LockoutEnabled],[AccessFailedCount], [PasswordHash], [SecurityStamp]) VALUES 
('fl-customer@gmail.com','FL-CUSTOMER@GMAIL.COM', 'fl-customer@gmail.com','FL-CUSTOMER@GMAIL.COM', 1, 1, 0, 0, 0, 'AQAAAAEAACcQAAAAEOMQum/FfDzkClwE+UtuDlSse0wwp4Ncjv4watkRJcOH8De1DJiKQi5siEknrwqFCw==', '27KRQBTZRUKFX6J7OFCEM6BN2N3CNXR4')
END