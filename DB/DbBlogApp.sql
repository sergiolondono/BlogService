USE [master]
GO
/****** Object:  Database [dbBlogService]    Script Date: 3/3/2021 20:41:26 ******/
CREATE DATABASE [dbBlogService]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbBlogService', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\dbBlogService.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'dbBlogService_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\dbBlogService_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [dbBlogService] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbBlogService].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbBlogService] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbBlogService] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbBlogService] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbBlogService] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbBlogService] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbBlogService] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dbBlogService] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [dbBlogService] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbBlogService] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbBlogService] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbBlogService] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbBlogService] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbBlogService] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbBlogService] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbBlogService] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbBlogService] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dbBlogService] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbBlogService] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbBlogService] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbBlogService] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbBlogService] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbBlogService] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbBlogService] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbBlogService] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [dbBlogService] SET  MULTI_USER 
GO
ALTER DATABASE [dbBlogService] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbBlogService] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbBlogService] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbBlogService] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [dbBlogService]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 3/3/2021 20:41:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 3/3/2021 20:41:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 3/3/2021 20:41:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 3/3/2021 20:41:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 3/3/2021 20:41:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 3/3/2021 20:41:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 3/3/2021 20:41:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 3/3/2021 20:41:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Comments]    Script Date: 3/3/2021 20:41:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comments](
	[Id] [uniqueidentifier] NOT NULL,
	[PostId] [uniqueidentifier] NOT NULL,
	[Comment] [nvarchar](max) NULL,
 CONSTRAINT [PK_Comments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Posts]    Script Date: 3/3/2021 20:41:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Posts](
	[Id] [uniqueidentifier] NOT NULL,
	[AuthorName] [nvarchar](max) NULL,
	[SubmitDate] [datetime2](7) NOT NULL,
	[State] [int] NOT NULL,
	[PostDescription] [nvarchar](max) NULL,
 CONSTRAINT [PK_Posts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[States]    Script Date: 3/3/2021 20:41:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[States](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_States] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210301194010_InitialCreate', N'3.1.3')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210302013610_SeedPostsStates', N'3.1.3')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210302210342_Comments Seed', N'3.1.3')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210302210617_Comments Seed 2', N'3.1.3')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210302214549_Comments Seed 3', N'3.1.3')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210302215320_Comments Seed 4', N'3.1.3')
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210303015911_Update Model Posts', N'3.1.3')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'06665E47-5C21-49B2-8AFF-13880061BEF5', N'writer', N'Writer', NULL)
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'6F3F7037-0DA6-40E1-9201-FF46E87B18E5', N'editor', N'Editor', NULL)
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c883f880-9bbf-4ebf-9afd-3126cc51040c', N'06665E47-5C21-49B2-8AFF-13880061BEF5')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a040ffb9-0e21-4204-8c6d-26b6f65daa1e', N'6F3F7037-0DA6-40E1-9201-FF46E87B18E5')
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'a040ffb9-0e21-4204-8c6d-26b6f65daa1e', N'sergio.com', N'SERGIO.COM', N'sergio.com', N'SERGIO.COM', 0, N'AQAAAAEAACcQAAAAEDSkzDrK0N2QEEeQj83q+3URcUh/guBsR5a+XGlitr1ytn5NDibFyHvOf5p5dVxiiA==', N'RN3R27UOFJ35JC72AAKBMSNW5OEBWANW', N'cccc88c8-b913-4622-bef3-961932db64ab', NULL, 0, 0, NULL, 1, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'c883f880-9bbf-4ebf-9afd-3126cc51040c', N'ser.com', N'SER.COM', N'ser.com', N'SER.COM', 0, N'AQAAAAEAACcQAAAAECeK1C129e+QQ1iptnscba022o9wNpCWerJiGQZZmLX/s7FYYZ0rnxJlCVVa47WF1w==', N'POURQ2WWG6L2CW4ELH77O7LQPMLDKLU7', N'7cfad411-0ff8-4e54-b83c-72e219ac472a', NULL, 0, 0, NULL, 1, 0)
GO
INSERT [dbo].[Comments] ([Id], [PostId], [Comment]) VALUES (N'4cc40ec5-57cc-4ded-91c7-1886dc24656b', N'bd49151b-13f1-4fcd-8e1a-8c5f1db08dbc', N'Comment from Postman')
GO
INSERT [dbo].[Comments] ([Id], [PostId], [Comment]) VALUES (N'c5a6f484-0579-47ec-b84e-2910adbc60ee', N'8c8bffc2-9347-4958-a27d-1f3085e7e98d', N'Comment test 1')
GO
INSERT [dbo].[Comments] ([Id], [PostId], [Comment]) VALUES (N'8fe72fa2-d28d-43e3-9ded-2e9943d8dd28', N'946a1303-adc2-4ba7-9433-644d1f0102ee', N'Other comment.')
GO
INSERT [dbo].[Comments] ([Id], [PostId], [Comment]) VALUES (N'995b9c9d-e573-4e86-9a9e-6004fc909da9', N'dee7944c-d9da-4050-ac6e-2f4d50b94ec5', N'Comment added from Angular application.')
GO
INSERT [dbo].[Comments] ([Id], [PostId], [Comment]) VALUES (N'bd49151b-13f1-4fcd-8e1a-8c5f1db08dbc', N'bd49151b-13f1-4fcd-8e1a-8c5f1db08dbc', N'Comment from Postman')
GO
INSERT [dbo].[Comments] ([Id], [PostId], [Comment]) VALUES (N'2e2ea7f3-d44f-4797-a419-b1896d0ff658', N'98552a20-36ec-4b42-9f95-c9b6136dcce5', N'A new comment.')
GO
INSERT [dbo].[Comments] ([Id], [PostId], [Comment]) VALUES (N'63c4248d-ae75-48db-b862-bf869dc88ed3', N'bad5b4e7-b313-4b22-ab54-4c434c0d5a14', N'Comment test 2')
GO
INSERT [dbo].[Comments] ([Id], [PostId], [Comment]) VALUES (N'4e6f9f9d-1f26-4cd5-9898-c2b5be3e9314', N'dee7944c-d9da-4050-ac6e-2f4d50b94ec5', N'another comment.')
GO
INSERT [dbo].[Comments] ([Id], [PostId], [Comment]) VALUES (N'edb1e52f-0527-450c-8a84-cbf3a236a453', N'8c8bffc2-9347-4958-a27d-1f3085e7e98d', N'Comment test 2')
GO
INSERT [dbo].[Comments] ([Id], [PostId], [Comment]) VALUES (N'ef79da7b-87ce-491e-9886-fba5789c8210', N'6f0ccde5-8eef-4753-8cbb-f8c1d9a2c127', N'Comment added from application to ser.coms Post.')
GO
INSERT [dbo].[Comments] ([Id], [PostId], [Comment]) VALUES (N'ab3635c1-04d0-409d-bf63-fec5ec9bc48f', N'98552a20-36ec-4b42-9f95-c9b6136dcce5', N'New comment from angular application.')
GO
INSERT [dbo].[Posts] ([Id], [AuthorName], [SubmitDate], [State], [PostDescription]) VALUES (N'dee7944c-d9da-4050-ac6e-2f4d50b94ec5', N'sergio.com', CAST(0x078B2B3CE7AF3A420B AS DateTime2), 3, N'Web API with .Net Core')
GO
INSERT [dbo].[Posts] ([Id], [AuthorName], [SubmitDate], [State], [PostDescription]) VALUES (N'5a7fd291-e30e-40f0-ac91-3f1998560d13', N'Jhon Papa', CAST(0x070000000000000000 AS DateTime2), 2, N'test posts Jhon.....')
GO
INSERT [dbo].[Posts] ([Id], [AuthorName], [SubmitDate], [State], [PostDescription]) VALUES (N'946a1303-adc2-4ba7-9433-644d1f0102ee', N'ser.com', CAST(0x079CB73CE7AF3A420B AS DateTime2), 3, N'Python performance')
GO
INSERT [dbo].[Posts] ([Id], [AuthorName], [SubmitDate], [State], [PostDescription]) VALUES (N'9483864c-1edf-4376-be8a-78329d68f16d', N'Mosh Hamedani', CAST(0x070000000000000000 AS DateTime2), 2, N'Unit of work pattern 2.')
GO
INSERT [dbo].[Posts] ([Id], [AuthorName], [SubmitDate], [State], [PostDescription]) VALUES (N'301f640e-677f-4d33-a6e2-8d2a93147202', N'Hector Abadía', CAST(0x074FA7826A5A3B420B AS DateTime2), 1, N'post test Abadía.')
GO
INSERT [dbo].[Posts] ([Id], [AuthorName], [SubmitDate], [State], [PostDescription]) VALUES (N'ba853990-3ee9-484f-99a1-8d361b34c9f8', N'Jhon Papa', CAST(0x0718A2314D593B420B AS DateTime2), 1, N'Clean Architecture.')
GO
INSERT [dbo].[Posts] ([Id], [AuthorName], [SubmitDate], [State], [PostDescription]) VALUES (N'afacf8b9-ec38-442a-aea3-b2243c51b839', N'Mosh Hamedani', CAST(0x078EFA25E7583B420B AS DateTime2), 1, N'Unit of work pattern.')
GO
SET IDENTITY_INSERT [dbo].[States] ON 

GO
INSERT [dbo].[States] ([Id], [Description]) VALUES (1, N'PendingToApproval')
GO
INSERT [dbo].[States] ([Id], [Description]) VALUES (2, N'Reject')
GO
INSERT [dbo].[States] ([Id], [Description]) VALUES (3, N'Approval')
GO
SET IDENTITY_INSERT [dbo].[States] OFF
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 3/3/2021 20:41:26 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [RoleNameIndex]    Script Date: 3/3/2021 20:41:26 ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 3/3/2021 20:41:26 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 3/3/2021 20:41:26 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 3/3/2021 20:41:26 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [EmailIndex]    Script Date: 3/3/2021 20:41:26 ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UserNameIndex]    Script Date: 3/3/2021 20:41:26 ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
USE [master]
GO
ALTER DATABASE [dbBlogService] SET  READ_WRITE 
GO
