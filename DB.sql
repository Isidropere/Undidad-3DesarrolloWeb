USE [master]
GO
/****** Object:  Database [EstudianteDiplomado]    Script Date: 8/11/2020 10:09:22 PM ******/
CREATE DATABASE [EstudianteDiplomado]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EstudianteDiplomado', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.ISD\MSSQL\DATA\EstudianteDiplomado.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EstudianteDiplomado_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.ISD\MSSQL\DATA\EstudianteDiplomado_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [EstudianteDiplomado] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EstudianteDiplomado].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EstudianteDiplomado] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EstudianteDiplomado] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EstudianteDiplomado] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EstudianteDiplomado] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EstudianteDiplomado] SET ARITHABORT OFF 
GO
ALTER DATABASE [EstudianteDiplomado] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EstudianteDiplomado] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EstudianteDiplomado] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EstudianteDiplomado] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EstudianteDiplomado] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EstudianteDiplomado] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EstudianteDiplomado] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EstudianteDiplomado] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EstudianteDiplomado] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EstudianteDiplomado] SET  DISABLE_BROKER 
GO
ALTER DATABASE [EstudianteDiplomado] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EstudianteDiplomado] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EstudianteDiplomado] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EstudianteDiplomado] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EstudianteDiplomado] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EstudianteDiplomado] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EstudianteDiplomado] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EstudianteDiplomado] SET RECOVERY FULL 
GO
ALTER DATABASE [EstudianteDiplomado] SET  MULTI_USER 
GO
ALTER DATABASE [EstudianteDiplomado] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EstudianteDiplomado] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EstudianteDiplomado] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EstudianteDiplomado] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [EstudianteDiplomado] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [EstudianteDiplomado] SET QUERY_STORE = OFF
GO
USE [EstudianteDiplomado]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [EstudianteDiplomado]
GO
/****** Object:  User [IIS]    Script Date: 8/11/2020 10:09:22 PM ******/
CREATE USER [IIS] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 8/11/2020 10:09:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cursoes]    Script Date: 8/11/2020 10:09:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cursoes](
	[CursoID] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Cursoes] PRIMARY KEY CLUSTERED 
(
	[CursoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estudiantes]    Script Date: 8/11/2020 10:09:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estudiantes](
	[EstudianteID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NULL,
	[Apellidos] [nvarchar](max) NULL,
	[Fecha_Inscripcion] [datetime] NULL,
 CONSTRAINT [PK_dbo.Estudiantes] PRIMARY KEY CLUSTERED 
(
	[EstudianteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inscripcions]    Script Date: 8/11/2020 10:09:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inscripcions](
	[InscripcionID] [int] IDENTITY(1,1) NOT NULL,
	[CursoID] [int] NOT NULL,
	[EstudianteID] [int] NOT NULL,
	[Semestre] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Inscripcions] PRIMARY KEY CLUSTERED 
(
	[InscripcionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [IX_CursoID]    Script Date: 8/11/2020 10:09:22 PM ******/
CREATE NONCLUSTERED INDEX [IX_CursoID] ON [dbo].[Inscripcions]
(
	[CursoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_EstudianteID]    Script Date: 8/11/2020 10:09:22 PM ******/
CREATE NONCLUSTERED INDEX [IX_EstudianteID] ON [dbo].[Inscripcions]
(
	[EstudianteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Inscripcions]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Inscripcions_dbo.Cursoes_CursoID] FOREIGN KEY([CursoID])
REFERENCES [dbo].[Cursoes] ([CursoID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Inscripcions] CHECK CONSTRAINT [FK_dbo.Inscripcions_dbo.Cursoes_CursoID]
GO
ALTER TABLE [dbo].[Inscripcions]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Inscripcions_dbo.Estudiantes_EstudianteID] FOREIGN KEY([EstudianteID])
REFERENCES [dbo].[Estudiantes] ([EstudianteID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Inscripcions] CHECK CONSTRAINT [FK_dbo.Inscripcions_dbo.Estudiantes_EstudianteID]
GO
USE [master]
GO
ALTER DATABASE [EstudianteDiplomado] SET  READ_WRITE 
GO
