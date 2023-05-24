
CREATE DATABASE CTTDB;

USE CTTDB;

CREATE TABLE [dbo].[Items] (
    [ID]          INT             IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (50)   NOT NULL,
    [Description] NVARCHAR (500)  NOT NULL,
    [IMG]         NVARCHAR (100)  NOT NULL,
    [Price]       DECIMAL (18, 2) NOT NULL,
    [Stock]       INT             NOT NULL,
    CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED ([ID] ASC)
);

CREATE TABLE [dbo].[Users] (
    [Id]       INT  IDENTITY(1,1) PRIMARY Key NOT NULL,
    [Email]    NVARCHAR (50)  NOT NULL,
    [Password] NVARCHAR (200) NOT NULL,
    [Admin]    BIT            NOT NULL,
    [Staff]    BIT            NOT NULL,
    
);

SET IDENTITY_INSERT [dbo].[Users] ON
INSERT INTO [dbo].[Users] ([Id], [Email], [Password], [Admin], [Staff]) VALUES (1, N'chilterntalkingtherapies@gmail.com', N'AQAAAAEAACcQAAAAEMBg5UqcaZ3Sri2w9wHq3Q0x1tRY0O4MuLDjeGfbqT7fNHUj+a74SUZ5rnODSWo8Xw==', 1, 1)
INSERT INTO [dbo].[Users] ([Id], [Email], [Password], [Admin], [Staff]) VALUES (2, N'testStaff@email.com', N'AQAAAAEAACcQAAAAENZYFKnVVaZL/WqElO2cJrvLG1dux27EuLDGeItdsej658VaehzNFYiStbN6tkdGCg==', 0, 1)
INSERT INTO [dbo].[Users] ([Id], [Email], [Password], [Admin], [Staff]) VALUES (3, N'testClient@email.com', N'AQAAAAEAACcQAAAAEFoGoawVtV/X1DFEmG7MklX5CbL1SpsRu8S44M77tKUy1A+H7GQe1cuB9L3vgQpF/g==', 0, 0)
INSERT INTO [dbo].[Users] ([Id], [Email], [Password], [Admin], [Staff]) VALUES (4, N'CTT_Test@outlook.com', N'AQAAAAEAACcQAAAAEJGKSqdbn0cfW9cN8qrs/q47Qfpw/rdGp3fQIS1J+B3STESCRgjNym+DevlL5z2G8g==', 0, 1)
SET IDENTITY_INSERT [dbo].[Users] OFF


SET IDENTITY_INSERT [dbo].[Items] ON
INSERT INTO [dbo].[Items] ([ID], [Name], [Description], [IMG], [Price], [Stock]) VALUES (1, N'Gift Basket', N'Handmade bee bombs, handmade soap, mini notepade, handmade bracelet, hot chocolate sachet, tealight candle, fiddle toy, dried lavender, prepackaged sweets, photoframe, gloss stickers, mindful coluring sheets, doodle sheets and CBT information sheets', N'/ShopImages/Wellness.png', CAST(25.00 AS Decimal(18, 2)), 15)
INSERT INTO [dbo].[Items] ([ID], [Name], [Description], [IMG], [Price], [Stock]) VALUES (2, N'Scented candles', N'These scented candles gives a lovely and relaxing aroma.', N'/shopImages/Candle.png', CAST(10.50 AS Decimal(18, 2)), 56)
INSERT INTO [dbo].[Items] ([ID], [Name], [Description], [IMG], [Price], [Stock]) VALUES (3, N'Little book of hygge', N'Great book to take with you everywhere for a quick read.', N'/shopImages/HyggeBook.png', CAST(29.00 AS Decimal(18, 2)), 75)
INSERT INTO [dbo].[Items] ([ID], [Name], [Description], [IMG], [Price], [Stock]) VALUES (4, N'Paint kit', N'Cozy plaint kit to get your thoughts and emotions out on a canvas.', N'/shopImages/Paint.png', CAST(12.00 AS Decimal(18, 2)), 28)
INSERT INTO [dbo].[Items] ([ID], [Name], [Description], [IMG], [Price], [Stock]) VALUES (5, N'Blanket', N'Soft and Fluffy', N'/shopImages/Blanket.png', CAST(50.99 AS Decimal(18, 2)), 12)
SET IDENTITY_INSERT [dbo].[Items] OFF
