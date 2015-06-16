USE [MasrafOtomasyonuDB]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Personel_PersonelTuru]') AND parent_object_id = OBJECT_ID(N'[dbo].[Personel]'))
ALTER TABLE [dbo].[Personel] DROP CONSTRAINT [FK_Personel_PersonelTuru]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Personel_Personel]') AND parent_object_id = OBJECT_ID(N'[dbo].[Personel]'))
ALTER TABLE [dbo].[Personel] DROP CONSTRAINT [FK_Personel_Personel]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Masraf_Personel]') AND parent_object_id = OBJECT_ID(N'[dbo].[Masraf]'))
ALTER TABLE [dbo].[Masraf] DROP CONSTRAINT [FK_Masraf_Personel]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Masraf_Durum]') AND parent_object_id = OBJECT_ID(N'[dbo].[Masraf]'))
ALTER TABLE [dbo].[Masraf] DROP CONSTRAINT [FK_Masraf_Durum]
GO
/****** Object:  Table [dbo].[PersonelTuru]    Script Date: 9.6.2015 23:42:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PersonelTuru]') AND type in (N'U'))
DROP TABLE [dbo].[PersonelTuru]
GO
/****** Object:  Table [dbo].[Personel]    Script Date: 9.6.2015 23:42:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Personel]') AND type in (N'U'))
DROP TABLE [dbo].[Personel]
GO
/****** Object:  Table [dbo].[Masraf]    Script Date: 9.6.2015 23:42:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Masraf]') AND type in (N'U'))
DROP TABLE [dbo].[Masraf]
GO
/****** Object:  Table [dbo].[Durum]    Script Date: 9.6.2015 23:42:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Durum]') AND type in (N'U'))
DROP TABLE [dbo].[Durum]
GO
USE [master]
GO
/****** Object:  Database [MasrafOtomasyonuDB]    Script Date: 9.6.2015 23:42:51 ******/
IF  EXISTS (SELECT name FROM sys.databases WHERE name = N'MasrafOtomasyonuDB')
DROP DATABASE [MasrafOtomasyonuDB]
GO
/****** Object:  Database [MasrafOtomasyonuDB]    Script Date: 9.6.2015 23:42:51 ******/
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'MasrafOtomasyonuDB')
BEGIN
CREATE DATABASE [MasrafOtomasyonuDB]
GO
END

GO
ALTER DATABASE [MasrafOtomasyonuDB] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MasrafOtomasyonuDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET RECOVERY FULL 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET  MULTI_USER 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET DELAYED_DURABILITY = DISABLED 
GO
USE [MasrafOtomasyonuDB]
GO
/****** Object:  Table [dbo].[Durum]    Script Date: 9.6.2015 23:42:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Durum]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Durum](
	[Id] [tinyint] IDENTITY(1,1) NOT NULL,
	[DurumMetni] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Durum] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Masraf]    Script Date: 9.6.2015 23:42:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Masraf]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Masraf](
	[Id] [uniqueidentifier] NOT NULL,
	[Baslik] [nvarchar](50) NOT NULL,
	[Tarih] [date] NOT NULL,
	[Tutar] [decimal](8, 2) NOT NULL,
	[Aciklama] [nvarchar](150) NOT NULL,
	[PersonelId] [int] NOT NULL,
	[DurumId] [tinyint] NOT NULL,
 CONSTRAINT [PK_Masraf] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Personel]    Script Date: 9.6.2015 23:42:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Personel]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Personel](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Adi] [nvarchar](20) NOT NULL,
	[Soyadi] [nvarchar](20) NOT NULL,
	[EPosta] [nvarchar](150) NOT NULL,
	[KullaniciAdi] [nvarchar](20) NOT NULL,
	[Sifre] [nvarchar](10) NOT NULL,
	[AktifMi] [bit] NOT NULL,
	[SorumlusuId] [int] NULL,
	[PersonelTurId] [tinyint] NOT NULL,
 CONSTRAINT [PK_Personel] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[PersonelTuru]    Script Date: 9.6.2015 23:42:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PersonelTuru]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PersonelTuru](
	[Id] [tinyint] IDENTITY(1,1) NOT NULL,
	[Tur] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_PersonelTuru] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET IDENTITY_INSERT [dbo].[Durum] ON 

INSERT [dbo].[Durum] ([Id], [DurumMetni]) VALUES (1, N'Onay Bekliyor')
INSERT [dbo].[Durum] ([Id], [DurumMetni]) VALUES (2, N'Reddedildi')
INSERT [dbo].[Durum] ([Id], [DurumMetni]) VALUES (3, N'Düzeltilecek')
INSERT [dbo].[Durum] ([Id], [DurumMetni]) VALUES (4, N'Ödendi')
INSERT [dbo].[Durum] ([Id], [DurumMetni]) VALUES (5, N'Onaylandı')
SET IDENTITY_INSERT [dbo].[Durum] OFF
INSERT [dbo].[Masraf] ([Id], [Baslik], [Tarih], [Tutar], [Aciklama], [PersonelId], [DurumId]) VALUES (N'4ba96ac4-17f4-4c23-915c-5280c9612e7c', N'test 11', CAST(N'2015-07-04' AS Date), CAST(18.00 AS Decimal(8, 2)), N'deneme 11', 4, 3)
INSERT [dbo].[Masraf] ([Id], [Baslik], [Tarih], [Tutar], [Aciklama], [PersonelId], [DurumId]) VALUES (N'4d6ccb14-f773-4a3e-876b-632f0e4f3405', N'Yemek 2', CAST(N'2015-05-31' AS Date), CAST(24.00 AS Decimal(8, 2)), N'Öğlen yemeği 2', 6, 1)
INSERT [dbo].[Masraf] ([Id], [Baslik], [Tarih], [Tutar], [Aciklama], [PersonelId], [DurumId]) VALUES (N'5245ee3c-1f54-4811-af31-8a2dd6b545a7', N'test 9', CAST(N'2015-06-28' AS Date), CAST(11.00 AS Decimal(8, 2)), N'deneme 9', 4, 4)
INSERT [dbo].[Masraf] ([Id], [Baslik], [Tarih], [Tutar], [Aciklama], [PersonelId], [DurumId]) VALUES (N'b618838d-26f6-4df5-9c25-96dff4e83171', N'Test1', CAST(N'2015-05-29' AS Date), CAST(12.00 AS Decimal(8, 2)), N'Deneme1 ', 3, 4)
INSERT [dbo].[Masraf] ([Id], [Baslik], [Tarih], [Tutar], [Aciklama], [PersonelId], [DurumId]) VALUES (N'0910644f-ae3d-4ebf-8245-97d1c218c960', N'masraf s1', CAST(N'2015-06-09' AS Date), CAST(100.00 AS Decimal(8, 2)), N'yemek', 5, 1)
INSERT [dbo].[Masraf] ([Id], [Baslik], [Tarih], [Tutar], [Aciklama], [PersonelId], [DurumId]) VALUES (N'd17680a3-f70a-42ba-a143-9cc3b78b4172', N'Test 7', CAST(N'2015-05-31' AS Date), CAST(13.00 AS Decimal(8, 2)), N'77777', 3, 4)
INSERT [dbo].[Masraf] ([Id], [Baslik], [Tarih], [Tutar], [Aciklama], [PersonelId], [DurumId]) VALUES (N'50b6e566-0e44-40fe-a148-a7fb4d19839e', N'test 10', CAST(N'2015-07-01' AS Date), CAST(22.00 AS Decimal(8, 2)), N'deneme 10', 4, 2)
INSERT [dbo].[Masraf] ([Id], [Baslik], [Tarih], [Tutar], [Aciklama], [PersonelId], [DurumId]) VALUES (N'5dcdf2e3-9920-4286-aeb0-aa68f09f034f', N'taksi', CAST(N'2015-05-31' AS Date), CAST(34.00 AS Decimal(8, 2)), N'yol', 3, 4)
INSERT [dbo].[Masraf] ([Id], [Baslik], [Tarih], [Tutar], [Aciklama], [PersonelId], [DurumId]) VALUES (N'7c28cc88-873b-4d4a-97b1-bebd154314f1', N'Test 8', CAST(N'2015-05-31' AS Date), CAST(99.00 AS Decimal(8, 2)), N'Bu bir deneme masrafıdır.8', 3, 4)
INSERT [dbo].[Masraf] ([Id], [Baslik], [Tarih], [Tutar], [Aciklama], [PersonelId], [DurumId]) VALUES (N'4226477a-ab40-4db8-9d91-c1e325cf3c46', N'Yemek', CAST(N'2015-05-30' AS Date), CAST(15.00 AS Decimal(8, 2)), N'Öğlen yemeği', 6, 1)
INSERT [dbo].[Masraf] ([Id], [Baslik], [Tarih], [Tutar], [Aciklama], [PersonelId], [DurumId]) VALUES (N'a1b0e692-7d71-41c6-ab07-d5f0f8fee82f', N'Test 2', CAST(N'2015-05-29' AS Date), CAST(29.00 AS Decimal(8, 2)), N'Bu bir deneme masrafıdır.', 3, 4)
INSERT [dbo].[Masraf] ([Id], [Baslik], [Tarih], [Tutar], [Aciklama], [PersonelId], [DurumId]) VALUES (N'5cc67257-e3cb-4736-a203-e77808749bfc', N'Test3', CAST(N'2015-05-27' AS Date), CAST(27.00 AS Decimal(8, 2)), N'Deneme3', 3, 4)
SET IDENTITY_INSERT [dbo].[Personel] ON 

INSERT [dbo].[Personel] ([Id], [Adi], [Soyadi], [EPosta], [KullaniciAdi], [Sifre], [AktifMi], [SorumlusuId], [PersonelTurId]) VALUES (3, N'Murat', N'Başeren', N'abc@abc.com', N'murat', N'123', 1, NULL, 3)
INSERT [dbo].[Personel] ([Id], [Adi], [Soyadi], [EPosta], [KullaniciAdi], [Sifre], [AktifMi], [SorumlusuId], [PersonelTurId]) VALUES (4, N'Belinay', N'Başeren', N'aaa@aaa.com', N'belinay', N'123', 1, 3, 2)
INSERT [dbo].[Personel] ([Id], [Adi], [Soyadi], [EPosta], [KullaniciAdi], [Sifre], [AktifMi], [SorumlusuId], [PersonelTurId]) VALUES (5, N'Şükran', N'Başeren', N'ccc@ccc.com', N'sukran', N'123', 1, 4, 1)
INSERT [dbo].[Personel] ([Id], [Adi], [Soyadi], [EPosta], [KullaniciAdi], [Sifre], [AktifMi], [SorumlusuId], [PersonelTurId]) VALUES (6, N'Kadir', N'Başeren', N'bbb@bbb.com', N'kadir', N'123', 1, NULL, 4)
SET IDENTITY_INSERT [dbo].[Personel] OFF
SET IDENTITY_INSERT [dbo].[PersonelTuru] ON 

INSERT [dbo].[PersonelTuru] ([Id], [Tur]) VALUES (1, N'Çalışan')
INSERT [dbo].[PersonelTuru] ([Id], [Tur]) VALUES (2, N'Birim Yöneticisi')
INSERT [dbo].[PersonelTuru] ([Id], [Tur]) VALUES (3, N'Yönetici')
INSERT [dbo].[PersonelTuru] ([Id], [Tur]) VALUES (4, N'Muhasebe')
SET IDENTITY_INSERT [dbo].[PersonelTuru] OFF
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Masraf_Durum]') AND parent_object_id = OBJECT_ID(N'[dbo].[Masraf]'))
ALTER TABLE [dbo].[Masraf]  WITH CHECK ADD  CONSTRAINT [FK_Masraf_Durum] FOREIGN KEY([DurumId])
REFERENCES [dbo].[Durum] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Masraf_Durum]') AND parent_object_id = OBJECT_ID(N'[dbo].[Masraf]'))
ALTER TABLE [dbo].[Masraf] CHECK CONSTRAINT [FK_Masraf_Durum]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Masraf_Personel]') AND parent_object_id = OBJECT_ID(N'[dbo].[Masraf]'))
ALTER TABLE [dbo].[Masraf]  WITH CHECK ADD  CONSTRAINT [FK_Masraf_Personel] FOREIGN KEY([PersonelId])
REFERENCES [dbo].[Personel] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Masraf_Personel]') AND parent_object_id = OBJECT_ID(N'[dbo].[Masraf]'))
ALTER TABLE [dbo].[Masraf] CHECK CONSTRAINT [FK_Masraf_Personel]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Personel_Personel]') AND parent_object_id = OBJECT_ID(N'[dbo].[Personel]'))
ALTER TABLE [dbo].[Personel]  WITH CHECK ADD  CONSTRAINT [FK_Personel_Personel] FOREIGN KEY([SorumlusuId])
REFERENCES [dbo].[Personel] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Personel_Personel]') AND parent_object_id = OBJECT_ID(N'[dbo].[Personel]'))
ALTER TABLE [dbo].[Personel] CHECK CONSTRAINT [FK_Personel_Personel]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Personel_PersonelTuru]') AND parent_object_id = OBJECT_ID(N'[dbo].[Personel]'))
ALTER TABLE [dbo].[Personel]  WITH CHECK ADD  CONSTRAINT [FK_Personel_PersonelTuru] FOREIGN KEY([PersonelTurId])
REFERENCES [dbo].[PersonelTuru] ([Id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Personel_PersonelTuru]') AND parent_object_id = OBJECT_ID(N'[dbo].[Personel]'))
ALTER TABLE [dbo].[Personel] CHECK CONSTRAINT [FK_Personel_PersonelTuru]
GO
USE [master]
GO
ALTER DATABASE [MasrafOtomasyonuDB] SET  READ_WRITE 
GO
