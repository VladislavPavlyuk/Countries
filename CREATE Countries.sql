USE [master]
GO
/****** Object:  Database [CountriesDB]    Script Date: 10/9/2023 2:35:01 PM ******/
CREATE DATABASE [CountriesDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CountriesDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\CountriesDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CountriesDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\CountriesDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [CountriesDB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CountriesDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CountriesDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CountriesDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CountriesDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CountriesDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CountriesDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [CountriesDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CountriesDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CountriesDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CountriesDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CountriesDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CountriesDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CountriesDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CountriesDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CountriesDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CountriesDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [CountriesDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CountriesDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CountriesDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CountriesDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CountriesDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CountriesDB] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [CountriesDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CountriesDB] SET RECOVERY FULL 
GO
ALTER DATABASE [CountriesDB] SET  MULTI_USER 
GO
ALTER DATABASE [CountriesDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CountriesDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CountriesDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CountriesDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CountriesDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CountriesDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'CountriesDB', N'ON'
GO
ALTER DATABASE [CountriesDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [CountriesDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [CountriesDB]
GO
/****** Object:  Table [dbo].[Countries]    Script Date: 10/9/2023 2:35:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CountryName] [nvarchar](max) NOT NULL,
	[CapitalName] [nvarchar](max) NOT NULL,
	[Population] [int] NULL,
	[Square] [int] NULL,
	[ContinentName] [nvarchar](max) NULL,
 CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Countries] ON 

INSERT [dbo].[Countries] ([Id], [CountryName], [CapitalName], [Population], [Square], [ContinentName]) VALUES (20, N'Hungary', N'Budapest', 9678000, 93030, N'Europe')
INSERT [dbo].[Countries] ([Id], [CountryName], [CapitalName], [Population], [Square], [ContinentName]) VALUES (21, N'Slovakia', N'Bratislava', 5460185, 49035, N'Europe')
INSERT [dbo].[Countries] ([Id], [CountryName], [CapitalName], [Population], [Square], [ContinentName]) VALUES (22, N'Bulgaria', N'Cofia', 6447710, 110993, N'Europe')
INSERT [dbo].[Countries] ([Id], [CountryName], [CapitalName], [Population], [Square], [ContinentName]) VALUES (23, N'Romania', N'Buharest', 19051562, 238397, N'Europe')
INSERT [dbo].[Countries] ([Id], [CountryName], [CapitalName], [Population], [Square], [ContinentName]) VALUES (24, N'Poland', N'Warsaw', 120733, 312696, N'Europe')
INSERT [dbo].[Countries] ([Id], [CountryName], [CapitalName], [Population], [Square], [ContinentName]) VALUES (25, N'Austria', N'Vienna', 9027999, 83871, N'Europe')
INSERT [dbo].[Countries] ([Id], [CountryName], [CapitalName], [Population], [Square], [ContinentName]) VALUES (26, N'Bangladesh', N'Dhaka', 169828911, 148460, N'Asia')
INSERT [dbo].[Countries] ([Id], [CountryName], [CapitalName], [Population], [Square], [ContinentName]) VALUES (27, N'India', N'Delhi', 1428627663, 3287263, N'Asia')
INSERT [dbo].[Countries] ([Id], [CountryName], [CapitalName], [Population], [Square], [ContinentName]) VALUES (28, N'China', N'Beijin', 1411750000, 9596961, N'Asia')
INSERT [dbo].[Countries] ([Id], [CountryName], [CapitalName], [Population], [Square], [ContinentName]) VALUES (29, N'Pakistan', N'Karachi', 241499431, 881913, N'Asia')
INSERT [dbo].[Countries] ([Id], [CountryName], [CapitalName], [Population], [Square], [ContinentName]) VALUES (30, N'Singapore', N'Singapore', 5637000, 734, N'Asia')
INSERT [dbo].[Countries] ([Id], [CountryName], [CapitalName], [Population], [Square], [ContinentName]) VALUES (31, N'Malaysia', N'Kuala-Lumpur', 33200000, 330803, N'Asia')
INSERT [dbo].[Countries] ([Id], [CountryName], [CapitalName], [Population], [Square], [ContinentName]) VALUES (33, N'Canada', N'Ottawa', 40097761, 9984670, N'North America')
INSERT [dbo].[Countries] ([Id], [CountryName], [CapitalName], [Population], [Square], [ContinentName]) VALUES (34, N'Egypt', N'Cairo', 109546720, 1010408, N'Africa')
INSERT [dbo].[Countries] ([Id], [CountryName], [CapitalName], [Population], [Square], [ContinentName]) VALUES (35, N'Turkey', N'Istambul', 85279553, 783562, N'Asia')
SET IDENTITY_INSERT [dbo].[Countries] OFF
GO
USE [master]
GO
ALTER DATABASE [CountriesDB] SET  READ_WRITE 
GO
