CREATE TABLE [dbo].[Cars](
  [id] [int] IDENTITY(1,1) NOT NULL,
  [CarModel] [nvarchar](max) NOT NULL,
  [Brand] [nvarchar](max) NOT NULL,
CONSTRAINT [PK_Cars] PRIMARY KEY CLUSTERED
(
  [id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF,
  ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cars] ON
GO
INSERT [dbo].[Cars] ([id], [CarModel], [Brand]) VALUES (1, N'Mustang', N'Ford')
GO
INSERT [dbo].[Cars] ([id], [CarModel], [Brand]) VALUES (2, N'500', N'Fiat')
GO
INSERT [dbo].[Cars] ([id], [CarModel], [Brand]) VALUES (3, N'Giulia', N'Alfa Romeo')
GO
SET IDENTITY_INSERT [dbo].[Cars] OFF
GO
USE [master]
GO
ALTER DATABASE [CARS] SET  READ_WRITE
GO