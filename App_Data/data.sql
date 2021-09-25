USE [master]
GO

/****** Object:  Database [EmployeeRecords]    Script Date: 9/25/2021 12:11:12 AM ******/

-- =============================================
-- Author	  : Md. Badruzzaman Liton
-- Purpose    : Create EmployeeRecords Database
-- Create date: 23-09-2021
-- =============================================

CREATE DATABASE [EmployeeRecords]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EmployeeRecords', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\EmployeeRecords.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EmployeeRecords_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\EmployeeRecords_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EmployeeRecords].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [EmployeeRecords] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [EmployeeRecords] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [EmployeeRecords] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [EmployeeRecords] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [EmployeeRecords] SET ARITHABORT OFF 
GO

ALTER DATABASE [EmployeeRecords] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [EmployeeRecords] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [EmployeeRecords] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [EmployeeRecords] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [EmployeeRecords] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [EmployeeRecords] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [EmployeeRecords] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [EmployeeRecords] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [EmployeeRecords] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [EmployeeRecords] SET  DISABLE_BROKER 
GO

ALTER DATABASE [EmployeeRecords] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [EmployeeRecords] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [EmployeeRecords] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [EmployeeRecords] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [EmployeeRecords] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [EmployeeRecords] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [EmployeeRecords] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [EmployeeRecords] SET RECOVERY FULL 
GO

ALTER DATABASE [EmployeeRecords] SET  MULTI_USER 
GO

ALTER DATABASE [EmployeeRecords] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [EmployeeRecords] SET DB_CHAINING OFF 
GO

ALTER DATABASE [EmployeeRecords] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [EmployeeRecords] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [EmployeeRecords] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [EmployeeRecords] SET QUERY_STORE = OFF
GO

ALTER DATABASE [EmployeeRecords] SET  READ_WRITE 
GO

USE [EmployeeRecords1]
GO

/****** Object:  Table [dbo].[EmployeeRecords]    Script Date: 9/23/2021 8:27:18 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author	  : Md. Badruzzaman Liton
-- Purpose    : Create Employee Table
-- Create date: 23-09-2021
-- =============================================

CREATE TABLE [dbo].[Employee](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](30) NULL,
	[MiddleName] [nvarchar](30) NULL,
	[LastName] [nvarchar](30) NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO