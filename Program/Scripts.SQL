Using CTTSiteDB;
SET IDENTITY_INSERT [dbo].[Items] ON
INSERT INTO [dbo].[Items] ([ID], [Name], [Description], [IMG], [Price], [Stock]) VALUES (1, N'Gift Basket', N'Handmade bee bombs, handmade soap, mini notepade, handmade bracelet, hot chocolate sachet, tealight candle, fiddle toy, dried lavender, prepackaged sweets, photoframe, gloss stickers, mindful coluring sheets, doodle sheets and CBT information sheets', N'/ShopImages/Wellness.png', CAST(25.00 AS Decimal(18, 2)), 15)
INSERT INTO [dbo].[Items] ([ID], [Name], [Description], [IMG], [Price], [Stock]) VALUES (2, N'Scented candles', N'These scented candles gives a lovely and relaxing aroma.', N'/shopImages/Candle.png', CAST(10.50 AS Decimal(18, 2)), 56)
INSERT INTO [dbo].[Items] ([ID], [Name], [Description], [IMG], [Price], [Stock]) VALUES (3, N'Little book of hygge', N'Great book to take with you everywhere for a quick read.', N'/shopImages/HyggeBook.png', CAST(29.00 AS Decimal(18, 2)), 75)
INSERT INTO [dbo].[Items] ([ID], [Name], [Description], [IMG], [Price], [Stock]) VALUES (4, N'Paint kit', N'Cozy plaint kit to get your thoughts and emotions out on a canvas.', N'/shopImages/Paint.png', CAST(12.00 AS Decimal(18, 2)), 28)
INSERT INTO [dbo].[Items] ([ID], [Name], [Description], [IMG], [Price], [Stock]) VALUES (5, N'Blanket', N'Soft and Fluffy', N'/shopImages/Blanket.png', CAST(50.99 AS Decimal(18, 2)), 12)
SET IDENTITY_INSERT [dbo].[Items] OFF


SET IDENTITY_INSERT [dbo].[Users] ON
INSERT INTO [dbo].[Users] ([Id], [Email], [Password], [Admin], [Staff]) VALUES (1, N'chilterntalkingtherapies@gmail.com', N'AQAAAAEAACcQAAAAEMBg5UqcaZ3Sri2w9wHq3Q0x1tRY0O4MuLDjeGfbqT7fNHUj+a74SUZ5rnODSWo8Xw==', 1, 1)
INSERT INTO [dbo].[Users] ([Id], [Email], [Password], [Admin], [Staff]) VALUES (2, N'testStaff@email.com', N'AQAAAAEAACcQAAAAENZYFKnVVaZL/WqElO2cJrvLG1dux27EuLDGeItdsej658VaehzNFYiStbN6tkdGCg==', 0, 1)
INSERT INTO [dbo].[Users] ([Id], [Email], [Password], [Admin], [Staff]) VALUES (3, N'testClient@email.com', N'AQAAAAEAACcQAAAAEFoGoawVtV/X1DFEmG7MklX5CbL1SpsRu8S44M77tKUy1A+H7GQe1cuB9L3vgQpF/g==', 0, 0)
INSERT INTO [dbo].[Users] ([Id], [Email], [Password], [Admin], [Staff]) VALUES (4, N'CTT_Test@outlook.com', N'AQAAAAEAACcQAAAAEJGKSqdbn0cfW9cN8qrs/q47Qfpw/rdGp3fQIS1J+B3STESCRgjNym+DevlL5z2G8g==', 0, 1)
INSERT INTO [dbo].[Users] ([Id], [Email], [Password], [Admin], [Staff]) VALUES (5, N'Hifnh@live.dk', N'AQAAAAEAACcQAAAAEOn/g3X+8ydm9W6gOnJQDttoOsoAm+BHx5TsbZS3PUM8ba8/IEC27E/SM6i8IT2pmA==', 0, 0)
SET IDENTITY_INSERT [dbo].[Users] OFF

INSERT INTO [dbo].[RoomBookings] ([StartDateTime], [EndDateTime], [Description], [UserEmail])
VALUES
    (CONCAT(CAST(DATEADD(day, -3, GETDATE()) AS DATE), ' 11:30:00'), CONCAT(CAST(DATEADD(day, -3, GETDATE()) AS DATE), ' 12:00:00'), 'Lunch', 'chilterntalkingtherapies@gmail.com'),
    (CONCAT(CAST(DATEADD(day, -1, GETDATE()) AS DATE), ' 15:00:00'), CONCAT(CAST(DATEADD(day, -1, GETDATE()) AS DATE), ' 16:00:00'), 'Staff Meeting', 'chilterntalkingtherapies@gmail.com'),
    (CONCAT(CAST(DATEADD(day, -1, GETDATE()) AS DATE), ' 13:45:00'), CONCAT(CAST(DATEADD(day, -1, GETDATE()) AS DATE), ' 14:45:00'), 'Art Psychotherapy', 'testStaff@email.com'),

    (CONCAT(CAST(DATEADD(day, 1, GETDATE()) AS DATE), ' 12:00:00'), CONCAT(CAST(DATEADD(day, 1, GETDATE()) AS DATE), ' 12:30:00'), 'Counselling', 'testStaff@email.com'),
    (CONCAT(CAST(DATEADD(day, 2, GETDATE()) AS DATE), ' 13:00:00'), CONCAT(CAST(DATEADD(day, 2, GETDATE()) AS DATE), ' 13:45:00'), 'Cognitive Behavioural Therapy', 'chilterntalkingtherapies@gmail.com'),
    (CONCAT(CAST(DATEADD(day, 2, GETDATE()) AS DATE), ' 16:00:00'), CONCAT(CAST(DATEADD(day, 2, GETDATE()) AS DATE), ' 16:30:00'), 'Staff Meeting', 'chilterntalkingtherapies@gmail.com'),
    (CONCAT(CAST(DATEADD(day, 4, GETDATE()) AS DATE), ' 14:00:00'), CONCAT(CAST(DATEADD(day, 4, GETDATE()) AS DATE), ' 14:30:00'), 'Counselling', 'testStaff@email.com'),
    (CONCAT(CAST(DATEADD(day, 5, GETDATE()) AS DATE), ' 14:00:00'), CONCAT(CAST(DATEADD(day, 5, GETDATE()) AS DATE), ' 15:00:00'), 'Art Psychotherapy', 'testStaff@email.com')


INSERT INTO [dbo].[Consultations] ([Date], [StartTime], [EndTime], [UserID], [BookedNamed], [TelefonNumber], [BookedEmail], [Booked])
VALUES
    (CAST(DATEADD(day, -2, GETDATE()) AS DATE), '10:00:00', '11:00:00', 1, 'Mads', '61675837', 'Hifnh@live.dk', 1),
    (CAST(DATEADD(day, -2, GETDATE()) AS DATE), '12:00:00', '13:00:00', 1, 'Mille', '26859241', 'Mille@live.dk', 1),
    (CAST(DATEADD(day, -2, GETDATE()) AS DATE), '14:00:00', '15:00:00', 1, 'Canty', '28475281', 'Canty@live.dk', 1),
    (CAST(DATEADD(day, -1, GETDATE()) AS DATE), '10:00:00', '11:00:00', 1, '', '', '', 0),
    (CAST(DATEADD(day, -1, GETDATE()) AS DATE), '12:00:00', '13:00:00', 1, '', '', '', 0),
    (CAST(DATEADD(day, -1, GETDATE()) AS DATE), '14:00:00', '15:00:00', 1, '', '', '', 0),
    (CAST(GETDATE() AS DATE), '10:00:00', '11:00:00', 1, '', '', '', 0),
    (CAST(GETDATE() AS DATE), '12:00:00', '13:00:00', 1, '', '', '', 0),
    (CAST(GETDATE() AS DATE), '14:00:00', '15:00:00', 1, '', '', '', 0),
    (CAST(GETDATE() AS DATE), '16:00:00', '17:00:00', 1, '', '', '', 0),
    (CAST(GETDATE() AS DATE), '18:00:00', '19:00:00', 1, '', '', '', 0),
    (CAST(DATEADD(day, 1, GETDATE()) AS DATE), '10:00:00', '11:00:00', 1, '', '', '', 0),
    (CAST(DATEADD(day, 1, GETDATE()) AS DATE), '12:00:00', '13:00:00', 1, '', '', '', 0),
    (CAST(DATEADD(day, 1, GETDATE()) AS DATE), '14:00:00', '15:00:00', 1, '', '', '', 0),
    (CAST(DATEADD(day, 1, GETDATE()) AS DATE), '16:00:00', '17:00:00', 1, '', '', '', 0),
    (CAST(DATEADD(day, 1, GETDATE()) AS DATE), '18:00:00', '19:00:00', 1, '', '', '', 0),
    (CAST(DATEADD(day, 2, GETDATE()) AS DATE), '10:00:00', '11:00:00', 1, '', '', '', 0),
    (CAST(DATEADD(day, 2, GETDATE()) AS DATE), '12:00:00', '13:00:00', 1, '', '', '', 0),
    (CAST(DATEADD(day, 2, GETDATE()) AS DATE), '14:00:00', '15:00:00', 1, '', '', '', 0),
    (CAST(DATEADD(day, 2, GETDATE()) AS DATE), '16:00:00', '17:00:00', 1, '', '', '', 0),
    (CAST(DATEADD(day, 2, GETDATE()) AS DATE), '18:00:00', '19:00:00', 1, '', '', '', 0);