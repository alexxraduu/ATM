USE [master]
GO
/****** Object:  Database [atm_db]    Script Date: 2/16/2023 1:26:04 PM ******/
CREATE DATABASE [atm_db]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'atm_db', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\atm_db.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'atm_db_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\atm_db_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [atm_db] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [atm_db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [atm_db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [atm_db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [atm_db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [atm_db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [atm_db] SET ARITHABORT OFF 
GO
ALTER DATABASE [atm_db] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [atm_db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [atm_db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [atm_db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [atm_db] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [atm_db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [atm_db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [atm_db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [atm_db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [atm_db] SET  ENABLE_BROKER 
GO
ALTER DATABASE [atm_db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [atm_db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [atm_db] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [atm_db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [atm_db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [atm_db] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [atm_db] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [atm_db] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [atm_db] SET  MULTI_USER 
GO
ALTER DATABASE [atm_db] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [atm_db] SET DB_CHAINING OFF 
GO
ALTER DATABASE [atm_db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [atm_db] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [atm_db] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [atm_db] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [atm_db] SET QUERY_STORE = ON
GO
ALTER DATABASE [atm_db] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [atm_db]
GO
/****** Object:  Table [dbo].[TransactionTable]    Script Date: 2/16/2023 1:26:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TransactionTable](
	[transaction_id] [int] IDENTITY(1,1) NOT NULL,
	[account_id] [varchar](50) NOT NULL,
	[date] [varchar](50) NOT NULL,
	[type] [varchar](50) NOT NULL,
	[amount] [int] NOT NULL,
 CONSTRAINT [PK_TransactionTable] PRIMARY KEY CLUSTERED 
(
	[transaction_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 2/16/2023 1:26:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[account_id] [varchar](50) NOT NULL,
	[first_name] [varchar](50) NOT NULL,
	[last_name] [varchar](50) NOT NULL,
	[address] [varchar](150) NOT NULL,
	[phone] [varchar](10) NOT NULL,
	[pin] [varchar](4) NOT NULL,
	[date_of_birth] [varchar](10) NOT NULL,
	[balance] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[account_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TransactionTable] ON 

INSERT [dbo].[TransactionTable] ([transaction_id], [account_id], [date], [type], [amount]) VALUES (7, N'12213', N'16-02-2023', N'DEPOSIT', 100)
INSERT [dbo].[TransactionTable] ([transaction_id], [account_id], [date], [type], [amount]) VALUES (8, N'12213', N'16-02-2023', N'DEPOSIT', 500)
INSERT [dbo].[TransactionTable] ([transaction_id], [account_id], [date], [type], [amount]) VALUES (9, N'12213', N'16-02-2023', N'WITHDRAW', 50)
INSERT [dbo].[TransactionTable] ([transaction_id], [account_id], [date], [type], [amount]) VALUES (10, N'44211', N'16-02-2023', N'DEPOSIT', 1000)
INSERT [dbo].[TransactionTable] ([transaction_id], [account_id], [date], [type], [amount]) VALUES (11, N'44211', N'16-02-2023', N'WITHDRAW', 200)
INSERT [dbo].[TransactionTable] ([transaction_id], [account_id], [date], [type], [amount]) VALUES (12, N'22312', N'16-02-2023', N'DEPOSIT', 500)
INSERT [dbo].[TransactionTable] ([transaction_id], [account_id], [date], [type], [amount]) VALUES (13, N'22312', N'16-02-2023', N'WITHDRAW', 100)
INSERT [dbo].[TransactionTable] ([transaction_id], [account_id], [date], [type], [amount]) VALUES (14, N'22312', N'16-02-2023', N'WITHDRAW', 50)
SET IDENTITY_INSERT [dbo].[TransactionTable] OFF
GO
INSERT [dbo].[Users] ([account_id], [first_name], [last_name], [address], [phone], [pin], [date_of_birth], [balance]) VALUES (N'12213', N'Radu', N'Alexandru', N'Ploiesti', N'0723424532', N'2222', N'06-09-2000', 550)
INSERT [dbo].[Users] ([account_id], [first_name], [last_name], [address], [phone], [pin], [date_of_birth], [balance]) VALUES (N'22312', N'Voicu', N'Andrei', N'Ploiesti', N'0723459960', N'3366', N'15-06-1995', 350)
INSERT [dbo].[Users] ([account_id], [first_name], [last_name], [address], [phone], [pin], [date_of_birth], [balance]) VALUES (N'32122', N'Popescu', N'Andrei', N'Brasov', N'0723324678', N'1234', N'27-08-1990', 0)
INSERT [dbo].[Users] ([account_id], [first_name], [last_name], [address], [phone], [pin], [date_of_birth], [balance]) VALUES (N'44211', N'Vasile', N'Ion', N'Bucuresti', N'0723456765', N'0000', N'09-07-1990', 800)
GO
USE [master]
GO
ALTER DATABASE [atm_db] SET  READ_WRITE 
GO
