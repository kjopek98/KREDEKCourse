USE [master]
GO
/****** Object:  Database [Hospital]    Script Date: 09.12.2019 17:54:56 ******/
CREATE DATABASE [Hospital]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ShoeStore', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.JOPEKSQL\MSSQL\DATA\ShoeStore.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ShoeStore_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.JOPEKSQL\MSSQL\DATA\ShoeStore_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Hospital] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Hospital].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Hospital] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Hospital] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Hospital] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Hospital] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Hospital] SET ARITHABORT OFF 
GO
ALTER DATABASE [Hospital] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Hospital] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Hospital] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Hospital] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Hospital] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Hospital] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Hospital] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Hospital] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Hospital] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Hospital] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Hospital] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Hospital] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Hospital] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Hospital] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Hospital] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Hospital] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Hospital] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Hospital] SET RECOVERY FULL 
GO
ALTER DATABASE [Hospital] SET  MULTI_USER 
GO
ALTER DATABASE [Hospital] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Hospital] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Hospital] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Hospital] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Hospital] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Hospital', N'ON'
GO
ALTER DATABASE [Hospital] SET QUERY_STORE = OFF
GO
USE [Hospital]
GO
/****** Object:  Table [dbo].[Specialization]    Script Date: 09.12.2019 17:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Specialization](
	[SpecializationId] [int] IDENTITY(1,1) NOT NULL,
	[SpecializationName] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SpecializationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctor]    Script Date: 09.12.2019 17:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctor](
	[DoctorId] [int] IDENTITY(1,1) NOT NULL,
	[DoctorName] [nvarchar](30) NOT NULL,
	[SpecializationId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DoctorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patient]    Script Date: 09.12.2019 17:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient](
	[PatientId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](30) NOT NULL,
	[Surname] [nvarchar](30) NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
	[ZipCode] [int] NOT NULL,
	[City] [nvarchar](30) NOT NULL,
	[Country] [nvarchar](30) NOT NULL,
	[Email] [nvarchar](30) NOT NULL,
	[NumberPhone] [int] NOT NULL,
	[UserId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[PatientId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Visit]    Script Date: 09.12.2019 17:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Visit](
	[VisitId] [int] IDENTITY(1,1) NOT NULL,
	[PatientId] [int] NOT NULL,
	[DoctorId] [int] NOT NULL,
	[VisitData] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[VisitId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[Wizyty_VIEW]    Script Date: 09.12.2019 17:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[Wizyty_VIEW] AS
SELECT v.VisitId, v.VisitData, p.Name, p.Surname, s.SpecializationName, d.DoctorName
FROM     Doctor d INNER JOIN
                Specialization s ON d.SpecializationId = s.SpecializationId INNER JOIN
                   Visit v ON d.DoctorId = v.DoctorId INNER JOIN
                   Patient p ON p.PatientId = v.PatientId ;
GO
/****** Object:  View [dbo].[DoctorsView]    Script Date: 09.12.2019 17:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[DoctorsView] AS
SELECT d.DoctorName AS Doktor, s.SpecializationName AS Specjalizacja
FROM Doctor d JOIN Specialization s ON d.SpecializationId = s.SpecializationId ;
GO
/****** Object:  Table [dbo].[Role]    Script Date: 09.12.2019 17:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserLogin]    Script Date: 09.12.2019 17:54:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserLogin](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](30) NOT NULL,
	[Password] [nvarchar](30) NOT NULL,
	[RoleId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Doctor] ON 

INSERT [dbo].[Doctor] ([DoctorId], [DoctorName], [SpecializationId]) VALUES (1, N'A. Żarczyńska', 1)
INSERT [dbo].[Doctor] ([DoctorId], [DoctorName], [SpecializationId]) VALUES (2, N'Ł. Noculak', 2)
INSERT [dbo].[Doctor] ([DoctorId], [DoctorName], [SpecializationId]) VALUES (3, N'A. Żórawik', 3)
INSERT [dbo].[Doctor] ([DoctorId], [DoctorName], [SpecializationId]) VALUES (4, N'D.Kumięga', 4)
INSERT [dbo].[Doctor] ([DoctorId], [DoctorName], [SpecializationId]) VALUES (5, N'J.Caliński', 5)
INSERT [dbo].[Doctor] ([DoctorId], [DoctorName], [SpecializationId]) VALUES (6, N'K.Cichecka', 6)
INSERT [dbo].[Doctor] ([DoctorId], [DoctorName], [SpecializationId]) VALUES (7, N'K.Wawrzała', 7)
INSERT [dbo].[Doctor] ([DoctorId], [DoctorName], [SpecializationId]) VALUES (8, N'W.Hajdusianek', 5)
INSERT [dbo].[Doctor] ([DoctorId], [DoctorName], [SpecializationId]) VALUES (9, N'U.Szydełko', 1)
SET IDENTITY_INSERT [dbo].[Doctor] OFF
SET IDENTITY_INSERT [dbo].[Patient] ON 

INSERT [dbo].[Patient] ([PatientId], [Name], [Surname], [Address], [ZipCode], [City], [Country], [Email], [NumberPhone], [UserId]) VALUES (1, N'Krzysztof', N'Jopek', N'Irysowa 1', 55200, N'Stanowice', N'Polska', N'kjopek@gmail.com', 884607988, NULL)
INSERT [dbo].[Patient] ([PatientId], [Name], [Surname], [Address], [ZipCode], [City], [Country], [Email], [NumberPhone], [UserId]) VALUES (2, N'Piotr', N'Jopek', N'Irysowa 1', 55200, N'Stanowice', N'Polska', N'pjopek@gmail.com', 982738412, NULL)
INSERT [dbo].[Patient] ([PatientId], [Name], [Surname], [Address], [ZipCode], [City], [Country], [Email], [NumberPhone], [UserId]) VALUES (3, N'Agnieszka', N'Jopek', N'Irysowa 1', 55200, N'Stanowice', N'Polska', N'ajopek@gmail.com', 76757988, 8)
INSERT [dbo].[Patient] ([PatientId], [Name], [Surname], [Address], [ZipCode], [City], [Country], [Email], [NumberPhone], [UserId]) VALUES (4, N'Bartosz', N'Jopek', N'Irysowa 1', 55200, N'Stanowice', N'Polska', N'bjopek@gmail.com', 45321412, 7)
SET IDENTITY_INSERT [dbo].[Patient] OFF
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([RoleId], [RoleName]) VALUES (1, N'Client')
INSERT [dbo].[Role] ([RoleId], [RoleName]) VALUES (2, N'Doctor')
INSERT [dbo].[Role] ([RoleId], [RoleName]) VALUES (3, N'Admin')
SET IDENTITY_INSERT [dbo].[Role] OFF
SET IDENTITY_INSERT [dbo].[Specialization] ON 

INSERT [dbo].[Specialization] ([SpecializationId], [SpecializationName]) VALUES (1, N'Okulista')
INSERT [dbo].[Specialization] ([SpecializationId], [SpecializationName]) VALUES (2, N'Psychiatra')
INSERT [dbo].[Specialization] ([SpecializationId], [SpecializationName]) VALUES (3, N'Ginekolog')
INSERT [dbo].[Specialization] ([SpecializationId], [SpecializationName]) VALUES (4, N'Kardiolog')
INSERT [dbo].[Specialization] ([SpecializationId], [SpecializationName]) VALUES (5, N'Anestezjolog')
INSERT [dbo].[Specialization] ([SpecializationId], [SpecializationName]) VALUES (6, N'Neurolog')
INSERT [dbo].[Specialization] ([SpecializationId], [SpecializationName]) VALUES (7, N'Endokrynolog')
SET IDENTITY_INSERT [dbo].[Specialization] OFF
SET IDENTITY_INSERT [dbo].[UserLogin] ON 

INSERT [dbo].[UserLogin] ([UserID], [UserName], [Password], [RoleId]) VALUES (1, N'admin', N'admin', 3)
INSERT [dbo].[UserLogin] ([UserID], [UserName], [Password], [RoleId]) VALUES (2, N'Krzysztof', N'KR121518', 1)
INSERT [dbo].[UserLogin] ([UserID], [UserName], [Password], [RoleId]) VALUES (3, N'Piotr', N'PI121518', 1)
INSERT [dbo].[UserLogin] ([UserID], [UserName], [Password], [RoleId]) VALUES (4, N'Anna', N'AN121518', 2)
INSERT [dbo].[UserLogin] ([UserID], [UserName], [Password], [RoleId]) VALUES (5, N'Łukasz', N'ŁU121518', 2)
INSERT [dbo].[UserLogin] ([UserID], [UserName], [Password], [RoleId]) VALUES (6, N'Aleksandra', N'AL121518', 2)
INSERT [dbo].[UserLogin] ([UserID], [UserName], [Password], [RoleId]) VALUES (7, N'Bartosz', N'BR121518', 1)
INSERT [dbo].[UserLogin] ([UserID], [UserName], [Password], [RoleId]) VALUES (8, N'Agnieszka', N'AG121518', 1)
SET IDENTITY_INSERT [dbo].[UserLogin] OFF
SET IDENTITY_INSERT [dbo].[Visit] ON 

INSERT [dbo].[Visit] ([VisitId], [PatientId], [DoctorId], [VisitData]) VALUES (1, 1, 1, CAST(N'2019-12-08T00:00:00.000' AS DateTime))
INSERT [dbo].[Visit] ([VisitId], [PatientId], [DoctorId], [VisitData]) VALUES (2, 2, 1, CAST(N'2019-12-19T00:00:00.000' AS DateTime))
INSERT [dbo].[Visit] ([VisitId], [PatientId], [DoctorId], [VisitData]) VALUES (3, 2, 2, CAST(N'2019-12-17T00:00:00.000' AS DateTime))
INSERT [dbo].[Visit] ([VisitId], [PatientId], [DoctorId], [VisitData]) VALUES (4, 4, 3, CAST(N'2019-12-13T00:00:00.000' AS DateTime))
INSERT [dbo].[Visit] ([VisitId], [PatientId], [DoctorId], [VisitData]) VALUES (5, 3, 3, CAST(N'2019-12-18T00:00:00.000' AS DateTime))
INSERT [dbo].[Visit] ([VisitId], [PatientId], [DoctorId], [VisitData]) VALUES (6, 3, 2, CAST(N'2019-12-20T00:00:00.000' AS DateTime))
INSERT [dbo].[Visit] ([VisitId], [PatientId], [DoctorId], [VisitData]) VALUES (7, 2, 3, CAST(N'2019-12-09T00:00:00.000' AS DateTime))
INSERT [dbo].[Visit] ([VisitId], [PatientId], [DoctorId], [VisitData]) VALUES (8, 3, 7, CAST(N'2019-12-20T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Visit] OFF
ALTER TABLE [dbo].[Doctor]  WITH CHECK ADD FOREIGN KEY([SpecializationId])
REFERENCES [dbo].[Specialization] ([SpecializationId])
GO
ALTER TABLE [dbo].[Patient]  WITH CHECK ADD FOREIGN KEY([UserId])
REFERENCES [dbo].[UserLogin] ([UserID])
GO
ALTER TABLE [dbo].[UserLogin]  WITH CHECK ADD FOREIGN KEY([RoleId])
REFERENCES [dbo].[Role] ([RoleId])
GO
ALTER TABLE [dbo].[Visit]  WITH CHECK ADD FOREIGN KEY([DoctorId])
REFERENCES [dbo].[Doctor] ([DoctorId])
GO
ALTER TABLE [dbo].[Visit]  WITH CHECK ADD FOREIGN KEY([PatientId])
REFERENCES [dbo].[Patient] ([PatientId])
GO
USE [master]
GO
ALTER DATABASE [Hospital] SET  READ_WRITE 
GO
