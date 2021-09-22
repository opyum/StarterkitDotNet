USE [master]
GO
/****** Object:  Database [RmConfig]    Script Date: 13/07/2021 10:36:15 ******/
CREATE DATABASE [RmConfig]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RmConfig', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\RmConfig.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RmConfig_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\RmConfig_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [RmConfig] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RmConfig].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RmConfig] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RmConfig] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RmConfig] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RmConfig] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RmConfig] SET ARITHABORT OFF 
GO
ALTER DATABASE [RmConfig] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [RmConfig] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RmConfig] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RmConfig] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RmConfig] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RmConfig] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RmConfig] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RmConfig] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RmConfig] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RmConfig] SET  DISABLE_BROKER 
GO
ALTER DATABASE [RmConfig] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RmConfig] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RmConfig] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RmConfig] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RmConfig] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RmConfig] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RmConfig] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RmConfig] SET RECOVERY FULL 
GO
ALTER DATABASE [RmConfig] SET  MULTI_USER 
GO
ALTER DATABASE [RmConfig] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RmConfig] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RmConfig] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RmConfig] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [RmConfig] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'RmConfig', N'ON'
GO
ALTER DATABASE [RmConfig] SET QUERY_STORE = OFF
GO
USE [RmConfig]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [RmConfig]
GO
USE [RmConfig]
GO
/****** Object:  Sequence [dbo].[ApplicationGroupSeq]    Script Date: 13/07/2021 10:36:15 ******/
CREATE SEQUENCE [dbo].[ApplicationGroupSeq] 
 AS [bigint]
 START WITH 1
 INCREMENT BY 1
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 NO CACHE 
GO
USE [RmConfig]
GO
/****** Object:  Sequence [dbo].[ClientGroupSeq]    Script Date: 13/07/2021 10:36:15 ******/
CREATE SEQUENCE [dbo].[ClientGroupSeq] 
 AS [bigint]
 START WITH 1
 INCREMENT BY 1
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 NO CACHE 
GO
USE [RmConfig]
GO
/****** Object:  Sequence [dbo].[EnvironnementGroupSeq]    Script Date: 13/07/2021 10:36:15 ******/
CREATE SEQUENCE [dbo].[EnvironnementGroupSeq] 
 AS [bigint]
 START WITH 1
 INCREMENT BY 1
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 NO CACHE 
GO
USE [RmConfig]
GO
/****** Object:  Sequence [dbo].[InfraGroupSeq]    Script Date: 13/07/2021 10:36:15 ******/
CREATE SEQUENCE [dbo].[InfraGroupSeq] 
 AS [bigint]
 START WITH 1
 INCREMENT BY 1
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 NO CACHE 
GO
USE [RmConfig]
GO
/****** Object:  Sequence [dbo].[NumeroVersionGroupSeq]    Script Date: 13/07/2021 10:36:15 ******/
CREATE SEQUENCE [dbo].[NumeroVersionGroupSeq] 
 AS [bigint]
 START WITH 1
 INCREMENT BY 1
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 NO CACHE 
GO
/****** Object:  Table [dbo].[Application]    Script Date: 13/07/2021 10:36:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Application](
	[IdAppli] [int] IDENTITY(1,1) NOT NULL,
	[Label] [nvarchar](50) NOT NULL,
	[CreatedDateTime] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](50) NOT NULL,
	[ModifiedDateTime] [datetime] NOT NULL,
	[ModifiedBy] [nvarchar](50) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[IdGroup] [int] NULL,
 CONSTRAINT [PK_Application] PRIMARY KEY CLUSTERED 
(
	[IdAppli] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 13/07/2021 10:36:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[IdClient] [int] IDENTITY(1,1) NOT NULL,
	[Label] [nvarchar](50) NOT NULL,
	[CreatedDateTime] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](50) NOT NULL,
	[ModifiedDateTime] [datetime] NOT NULL,
	[ModifiedBy] [nvarchar](50) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[IdGroup] [int] NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[IdClient] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ConfigFile]    Script Date: 13/07/2021 10:36:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ConfigFile](
	[IdConfigFile] [int] IDENTITY(1,1) NOT NULL,
	[Path] [nvarchar](300) NOT NULL,
	[Extension] [nvarchar](50) NOT NULL,
	[IdAppli] [int] NULL,
	[FileName] [nvarchar](100) NULL,
 CONSTRAINT [PK_ConfigFile] PRIMARY KEY CLUSTERED 
(
	[IdConfigFile] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ConfigFileVariable]    Script Date: 13/07/2021 10:36:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ConfigFileVariable](
	[IdConfigFileVariable] [int] NOT NULL,
	[IdConfigFile] [int] NULL,
	[IdVariable] [int] NULL,
 CONSTRAINT [PK_ConfigFileVariable] PRIMARY KEY CLUSTERED 
(
	[IdConfigFileVariable] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Definition]    Script Date: 13/07/2021 10:36:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Definition](
	[IdDefinition] [int] IDENTITY(1,1) NOT NULL,
	[IdAppli] [int] NOT NULL,
	[IdInfra] [int] NOT NULL,
	[IdClient] [int] NOT NULL,
	[IdVersion] [int] NOT NULL,
	[IdEnvironnement] [int] NOT NULL,
 CONSTRAINT [PK_Definition] PRIMARY KEY CLUSTERED 
(
	[IdDefinition] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Deploiement]    Script Date: 13/07/2021 10:36:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Deploiement](
	[IdDeploy] [int] IDENTITY(1,1) NOT NULL,
	[DeployDate] [datetime] NOT NULL,
	[IdDefinition] [int] NOT NULL,
 CONSTRAINT [PK_Deploiement] PRIMARY KEY CLUSTERED 
(
	[IdDeploy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Environnement]    Script Date: 13/07/2021 10:36:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Environnement](
	[IdEnvironnement] [int] IDENTITY(1,1) NOT NULL,
	[Label] [nvarchar](50) NOT NULL,
	[CreatedDateTime] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](50) NOT NULL,
	[ModifiedDateTime] [datetime] NOT NULL,
	[ModifiedBy] [nvarchar](50) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[IdGroup] [int] NULL,
 CONSTRAINT [PK_Environnement] PRIMARY KEY CLUSTERED 
(
	[IdEnvironnement] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Environnement_Application]    Script Date: 13/07/2021 10:36:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Environnement_Application](
	[IdEnvAppli] [int] IDENTITY(1,1) NOT NULL,
	[IdEnvironnement] [int] NOT NULL,
	[IdAppli] [int] NOT NULL,
 CONSTRAINT [PK_Environnement_Application] PRIMARY KEY CLUSTERED 
(
	[IdEnvAppli] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Infrastructure]    Script Date: 13/07/2021 10:36:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Infrastructure](
	[IdInfra] [int] IDENTITY(1,1) NOT NULL,
	[Label] [nvarchar](50) NOT NULL,
	[CreatedDateTime] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](50) NOT NULL,
	[ModifiedDateTime] [datetime] NOT NULL,
	[ModifiedBy] [nvarchar](50) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[IdGroup] [int] NULL,
 CONSTRAINT [PK_Infrastructure] PRIMARY KEY CLUSTERED 
(
	[IdInfra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MetaEntity]    Script Date: 13/07/2021 10:36:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MetaEntity](
	[IdMetaEntity] [int] IDENTITY(1,1) NOT NULL,
	[IdMetaEntityType] [int] NOT NULL,
	[ExternalId] [int] NOT NULL,
 CONSTRAINT [PK_Entity] PRIMARY KEY CLUSTERED 
(
	[IdMetaEntity] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MetaEntityType]    Script Date: 13/07/2021 10:36:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MetaEntityType](
	[IdMetaEntityType] [int] IDENTITY(1,1) NOT NULL,
	[Label] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_MetaEntityType] PRIMARY KEY CLUSTERED 
(
	[IdMetaEntityType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MetaEntityVariable]    Script Date: 13/07/2021 10:36:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MetaEntityVariable](
	[IdMetaEntityVariable] [int] IDENTITY(1,1) NOT NULL,
	[IdMetaEntity] [int] NULL,
	[IdVariable] [int] NULL,
	[Value] [nvarchar](1000) NULL,
 CONSTRAINT [PK_MetaEntityVariable] PRIMARY KEY CLUSTERED 
(
	[IdMetaEntityVariable] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NumeroVersion]    Script Date: 13/07/2021 10:36:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NumeroVersion](
	[IdVersion] [int] IDENTITY(1,1) NOT NULL,
	[Numero] [nvarchar](25) NOT NULL,
	[CreatedDateTime] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](50) NOT NULL,
	[ModifiedDateTime] [datetime] NOT NULL,
	[ModifiedBy] [nvarchar](50) NOT NULL,
	[IdAppli] [int] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[IdGroup] [int] NULL,
 CONSTRAINT [PK_Version] PRIMARY KEY CLUSTERED 
(
	[IdVersion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Right]    Script Date: 13/07/2021 10:36:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Right](
	[IdRight] [int] IDENTITY(1,1) NOT NULL,
	[Label] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Right_1] PRIMARY KEY CLUSTERED 
(
	[IdRight] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 13/07/2021 10:36:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[IdRole] [int] IDENTITY(1,1) NOT NULL,
	[Label] [nvarchar](50) NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[IdRole] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoleRight]    Script Date: 13/07/2021 10:36:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoleRight](
	[IdRoleRIght] [int] IDENTITY(1,1) NOT NULL,
	[IdRole] [int] NOT NULL,
	[IdRight] [int] NOT NULL,
	[IdMetaEntityType] [int] NOT NULL,
	[IdEnvironnement] [int] NOT NULL,
 CONSTRAINT [PK_RoleRight] PRIMARY KEY CLUSTERED 
(
	[IdRoleRIght] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypeVariable]    Script Date: 13/07/2021 10:36:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeVariable](
	[IdTypeVariable] [int] IDENTITY(1,1) NOT NULL,
	[Label] [nvarchar](50) NULL,
 CONSTRAINT [PK_TypeVariable] PRIMARY KEY CLUSTERED 
(
	[IdTypeVariable] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 13/07/2021 10:36:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[IdUser] [int] IDENTITY(1,1) NOT NULL,
	[DisplayName] [nvarchar](100) NULL,
	[LastName] [nvarchar](50) NULL,
	[FirstName] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[UserPrincipalName] [nvarchar](50) NULL,
	[SamAccountName] [nvarchar](50) NULL,
	[AzureObjectIdentifier] [uniqueidentifier] NULL,
	[CreatedDateTime] [datetime] NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[ModifiedDateTime] [datetime] NOT NULL,
	[ModifiedBy] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[IdUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserRole]    Script Date: 13/07/2021 10:36:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRole](
	[IdUserRole] [int] IDENTITY(1,1) NOT NULL,
	[IdRole] [int] NOT NULL,
	[IdUser] [int] NOT NULL,
 CONSTRAINT [PK_UserRole] PRIMARY KEY CLUSTERED 
(
	[IdUserRole] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Variable]    Script Date: 13/07/2021 10:36:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Variable](
	[IdVariable] [int] IDENTITY(1,1) NOT NULL,
	[Token] [nvarchar](50) NOT NULL,
	[IsMandatory] [bit] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[IsSensitive] [bit] NOT NULL,
	[CreatedDateTime] [datetime] NOT NULL,
	[CreatedBy] [nvarchar](50) NOT NULL,
	[ModifiedDateTime] [datetime] NOT NULL,
	[ModifiedBy] [nvarchar](50) NOT NULL,
	[IdMetaEntityType] [int] NOT NULL,
	[IdTypeVariable] [int] NOT NULL,
 CONSTRAINT [PK_Variable] PRIMARY KEY CLUSTERED 
(
	[IdVariable] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Application] ADD  CONSTRAINT [DF_Application_IsActive]  DEFAULT ((0)) FOR [IsActive]
GO
ALTER TABLE [dbo].[Application] ADD  CONSTRAINT [DF__Applicati__IdGro__03BB8E22]  DEFAULT (NEXT VALUE FOR [ApplicationGroupSeq]) FOR [IdGroup]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF_Client_IdGroup]  DEFAULT (NEXT VALUE FOR [ClientGroupSeq]) FOR [IdGroup]
GO
ALTER TABLE [dbo].[Environnement] ADD  CONSTRAINT [DF_Environnement_IdGroup]  DEFAULT (NEXT VALUE FOR [EnvironnementGroupSeq]) FOR [IdGroup]
GO
ALTER TABLE [dbo].[Infrastructure] ADD  CONSTRAINT [DF_Infrastructure_IdGroup]  DEFAULT (NEXT VALUE FOR [InfraGroupSeq]) FOR [IdGroup]
GO
ALTER TABLE [dbo].[NumeroVersion] ADD  CONSTRAINT [DF_NumeroVersion_IdGroup]  DEFAULT (NEXT VALUE FOR [NumeroVersionGroupSeq]) FOR [IdGroup]
GO
ALTER TABLE [dbo].[ConfigFile]  WITH CHECK ADD  CONSTRAINT [FK_ConfigFile_Application] FOREIGN KEY([IdAppli])
REFERENCES [dbo].[Application] ([IdAppli])
GO
ALTER TABLE [dbo].[ConfigFile] CHECK CONSTRAINT [FK_ConfigFile_Application]
GO
ALTER TABLE [dbo].[ConfigFileVariable]  WITH CHECK ADD  CONSTRAINT [FK_ConfigFileVariable_ConfigFile] FOREIGN KEY([IdConfigFile])
REFERENCES [dbo].[ConfigFile] ([IdConfigFile])
GO
ALTER TABLE [dbo].[ConfigFileVariable] CHECK CONSTRAINT [FK_ConfigFileVariable_ConfigFile]
GO
ALTER TABLE [dbo].[ConfigFileVariable]  WITH CHECK ADD  CONSTRAINT [FK_ConfigFileVariable_Variable] FOREIGN KEY([IdVariable])
REFERENCES [dbo].[Variable] ([IdVariable])
GO
ALTER TABLE [dbo].[ConfigFileVariable] CHECK CONSTRAINT [FK_ConfigFileVariable_Variable]
GO
ALTER TABLE [dbo].[Definition]  WITH CHECK ADD  CONSTRAINT [FK_Definition_Application] FOREIGN KEY([IdAppli])
REFERENCES [dbo].[Application] ([IdAppli])
GO
ALTER TABLE [dbo].[Definition] CHECK CONSTRAINT [FK_Definition_Application]
GO
ALTER TABLE [dbo].[Definition]  WITH CHECK ADD  CONSTRAINT [FK_Definition_Client] FOREIGN KEY([IdClient])
REFERENCES [dbo].[Client] ([IdClient])
GO
ALTER TABLE [dbo].[Definition] CHECK CONSTRAINT [FK_Definition_Client]
GO
ALTER TABLE [dbo].[Definition]  WITH CHECK ADD  CONSTRAINT [FK_Definition_Environnement1] FOREIGN KEY([IdEnvironnement])
REFERENCES [dbo].[Environnement] ([IdEnvironnement])
GO
ALTER TABLE [dbo].[Definition] CHECK CONSTRAINT [FK_Definition_Environnement1]
GO
ALTER TABLE [dbo].[Definition]  WITH CHECK ADD  CONSTRAINT [FK_Definition_Infrastructure] FOREIGN KEY([IdInfra])
REFERENCES [dbo].[Infrastructure] ([IdInfra])
GO
ALTER TABLE [dbo].[Definition] CHECK CONSTRAINT [FK_Definition_Infrastructure]
GO
ALTER TABLE [dbo].[Definition]  WITH CHECK ADD  CONSTRAINT [FK_Definition_NumeroVersion] FOREIGN KEY([IdVersion])
REFERENCES [dbo].[NumeroVersion] ([IdVersion])
GO
ALTER TABLE [dbo].[Definition] CHECK CONSTRAINT [FK_Definition_NumeroVersion]
GO
ALTER TABLE [dbo].[Deploiement]  WITH CHECK ADD  CONSTRAINT [FK_Deploiement_Definition] FOREIGN KEY([IdDefinition])
REFERENCES [dbo].[Definition] ([IdDefinition])
GO
ALTER TABLE [dbo].[Deploiement] CHECK CONSTRAINT [FK_Deploiement_Definition]
GO
ALTER TABLE [dbo].[Environnement_Application]  WITH CHECK ADD  CONSTRAINT [FK_Environnement_Application_Application] FOREIGN KEY([IdAppli])
REFERENCES [dbo].[Application] ([IdAppli])
GO
ALTER TABLE [dbo].[Environnement_Application] CHECK CONSTRAINT [FK_Environnement_Application_Application]
GO
ALTER TABLE [dbo].[Environnement_Application]  WITH CHECK ADD  CONSTRAINT [FK_Environnement_Application_Environnement] FOREIGN KEY([IdEnvironnement])
REFERENCES [dbo].[Environnement] ([IdEnvironnement])
GO
ALTER TABLE [dbo].[Environnement_Application] CHECK CONSTRAINT [FK_Environnement_Application_Environnement]
GO
ALTER TABLE [dbo].[MetaEntity]  WITH CHECK ADD  CONSTRAINT [FK_MetaEntity_MetaEntityType] FOREIGN KEY([IdMetaEntityType])
REFERENCES [dbo].[MetaEntityType] ([IdMetaEntityType])
GO
ALTER TABLE [dbo].[MetaEntity] CHECK CONSTRAINT [FK_MetaEntity_MetaEntityType]
GO
ALTER TABLE [dbo].[MetaEntityVariable]  WITH CHECK ADD  CONSTRAINT [FK_MetaEntityVariable_MetaEntity] FOREIGN KEY([IdMetaEntity])
REFERENCES [dbo].[MetaEntity] ([IdMetaEntity])
GO
ALTER TABLE [dbo].[MetaEntityVariable] CHECK CONSTRAINT [FK_MetaEntityVariable_MetaEntity]
GO
ALTER TABLE [dbo].[MetaEntityVariable]  WITH CHECK ADD  CONSTRAINT [FK_MetaEntityVariable_Variable] FOREIGN KEY([IdVariable])
REFERENCES [dbo].[Variable] ([IdVariable])
GO
ALTER TABLE [dbo].[MetaEntityVariable] CHECK CONSTRAINT [FK_MetaEntityVariable_Variable]
GO
ALTER TABLE [dbo].[NumeroVersion]  WITH CHECK ADD  CONSTRAINT [FK_Version_Application] FOREIGN KEY([IdAppli])
REFERENCES [dbo].[Application] ([IdAppli])
GO
ALTER TABLE [dbo].[NumeroVersion] CHECK CONSTRAINT [FK_Version_Application]
GO
ALTER TABLE [dbo].[RoleRight]  WITH CHECK ADD  CONSTRAINT [FK_RoleRight_Environnement] FOREIGN KEY([IdEnvironnement])
REFERENCES [dbo].[Environnement] ([IdEnvironnement])
GO
ALTER TABLE [dbo].[RoleRight] CHECK CONSTRAINT [FK_RoleRight_Environnement]
GO
ALTER TABLE [dbo].[RoleRight]  WITH CHECK ADD  CONSTRAINT [FK_RoleRight_MetaEntityType] FOREIGN KEY([IdMetaEntityType])
REFERENCES [dbo].[MetaEntityType] ([IdMetaEntityType])
GO
ALTER TABLE [dbo].[RoleRight] CHECK CONSTRAINT [FK_RoleRight_MetaEntityType]
GO
ALTER TABLE [dbo].[RoleRight]  WITH CHECK ADD  CONSTRAINT [FK_RoleRight_Right1] FOREIGN KEY([IdRight])
REFERENCES [dbo].[Right] ([IdRight])
GO
ALTER TABLE [dbo].[RoleRight] CHECK CONSTRAINT [FK_RoleRight_Right1]
GO
ALTER TABLE [dbo].[RoleRight]  WITH CHECK ADD  CONSTRAINT [FK_RoleRight_Role] FOREIGN KEY([IdRole])
REFERENCES [dbo].[Role] ([IdRole])
GO
ALTER TABLE [dbo].[RoleRight] CHECK CONSTRAINT [FK_RoleRight_Role]
GO
ALTER TABLE [dbo].[UserRole]  WITH CHECK ADD  CONSTRAINT [FK_UserRole_Role] FOREIGN KEY([IdRole])
REFERENCES [dbo].[Role] ([IdRole])
GO
ALTER TABLE [dbo].[UserRole] CHECK CONSTRAINT [FK_UserRole_Role]
GO
ALTER TABLE [dbo].[UserRole]  WITH CHECK ADD  CONSTRAINT [FK_UserRole_User] FOREIGN KEY([IdUser])
REFERENCES [dbo].[User] ([IdUser])
GO
ALTER TABLE [dbo].[UserRole] CHECK CONSTRAINT [FK_UserRole_User]
GO
ALTER TABLE [dbo].[Variable]  WITH CHECK ADD  CONSTRAINT [FK_Variable_MetaEntityType] FOREIGN KEY([IdMetaEntityType])
REFERENCES [dbo].[MetaEntityType] ([IdMetaEntityType])
GO
ALTER TABLE [dbo].[Variable] CHECK CONSTRAINT [FK_Variable_MetaEntityType]
GO
ALTER TABLE [dbo].[Variable]  WITH CHECK ADD  CONSTRAINT [FK_Variable_TypeVariable] FOREIGN KEY([IdTypeVariable])
REFERENCES [dbo].[TypeVariable] ([IdTypeVariable])
GO
ALTER TABLE [dbo].[Variable] CHECK CONSTRAINT [FK_Variable_TypeVariable]
GO
USE [master]
GO
ALTER DATABASE [RmConfig] SET  READ_WRITE 
GO
