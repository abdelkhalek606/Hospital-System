USE [master]
GO
/****** Object:  Database [project1]    Script Date: 1/10/2022 7:59:51 AM ******/
CREATE DATABASE [project1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'project1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\project1.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'project1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\project1_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [project1] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [project1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [project1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [project1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [project1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [project1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [project1] SET ARITHABORT OFF 
GO
ALTER DATABASE [project1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [project1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [project1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [project1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [project1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [project1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [project1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [project1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [project1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [project1] SET  DISABLE_BROKER 
GO
ALTER DATABASE [project1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [project1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [project1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [project1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [project1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [project1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [project1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [project1] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [project1] SET  MULTI_USER 
GO
ALTER DATABASE [project1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [project1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [project1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [project1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [project1] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [project1] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'project1', N'ON'
GO
ALTER DATABASE [project1] SET QUERY_STORE = OFF
GO
USE [project1]
GO
/****** Object:  Table [dbo].[administrator]    Script Date: 1/10/2022 7:59:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[administrator](
	[name] [nvarchar](50) NOT NULL,
	[Id] [nvarchar](50) NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_administrator] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ambulance]    Script Date: 1/10/2022 7:59:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ambulance](
	[driver] [varchar](50) NULL,
	[place] [varchar](50) NULL,
	[Id] [varchar](50) NOT NULL,
	[avaliable] [bit] NOT NULL,
	[patient_ssn] [int] NULL,
 CONSTRAINT [PK_ambulance] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[appointment]    Script Date: 1/10/2022 7:59:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[appointment](
	[starttime] [float] NOT NULL,
	[endtime] [float] NOT NULL,
	[day] [nvarchar](50) NOT NULL,
	[patient_ssn] [int] NOT NULL,
	[clinic_id] [int] NOT NULL,
 CONSTRAINT [PK_appointment] PRIMARY KEY CLUSTERED 
(
	[starttime] ASC,
	[day] ASC,
	[patient_ssn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[care]    Script Date: 1/10/2022 7:59:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[care](
	[patient_ssn] [int] NOT NULL,
	[Doctor_id] [int] NOT NULL,
	[rate] [int] NULL,
	[available] [bit] NULL,
 CONSTRAINT [PK_care] PRIMARY KEY CLUSTERED 
(
	[patient_ssn] ASC,
	[Doctor_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[clinic]    Script Date: 1/10/2022 7:59:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clinic](
	[id] [int] NOT NULL,
	[doctor_id] [int] NOT NULL,
 CONSTRAINT [PK_clinic] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Department]    Script Date: 1/10/2022 7:59:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[Dnumber] [int] NOT NULL,
	[Dname] [nvarchar](50) NOT NULL,
	[Mng_id] [int] NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[Dnumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctor]    Script Date: 1/10/2022 7:59:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctor](
	[id] [int] NOT NULL,
	[DNO] [int] NULL,
	[name] [nvarchar](50) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [int] NOT NULL,
 CONSTRAINT [PK_Doctor] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nurses]    Script Date: 1/10/2022 7:59:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nurses](
	[name] [nvarchar](50) NOT NULL,
	[Id] [int] NOT NULL,
	[room_id] [int] NULL,
 CONSTRAINT [PK_nurses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[patient]    Script Date: 1/10/2022 7:59:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[patient](
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[SSN] [int] NOT NULL,
	[fname] [nvarchar](50) NOT NULL,
	[mint] [varchar](50) NOT NULL,
	[lname] [nvarchar](50) NOT NULL,
	[DOB] [date] NOT NULL,
	[phone_number] [int] NOT NULL,
	[gender] [nchar](10) NOT NULL,
 CONSTRAINT [PK_patient] PRIMARY KEY CLUSTERED 
(
	[SSN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[patient_visitlog]    Script Date: 1/10/2022 7:59:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[patient_visitlog](
	[ssn] [int] NOT NULL,
	[date_in] [date] NOT NULL,
	[date_out] [date] NULL,
 CONSTRAINT [PK_patient_visitlog] PRIMARY KEY CLUSTERED 
(
	[ssn] ASC,
	[date_in] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Question]    Script Date: 1/10/2022 7:59:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Question](
	[sender_ssn] [int] NOT NULL,
	[question] [nvarchar](100) NOT NULL,
	[doctor_id] [int] NOT NULL,
	[response] [nvarchar](100) NULL,
	[sendtime] [datetime] NULL,
	[response_time] [datetime] NULL,
 CONSTRAINT [PK_Question_1] PRIMARY KEY CLUSTERED 
(
	[sender_ssn] ASC,
	[question] ASC,
	[doctor_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[receptionist]    Script Date: 1/10/2022 7:59:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[receptionist](
	[Id] [int] NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_receptionist] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[relatives]    Script Date: 1/10/2022 7:59:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[relatives](
	[Name] [nvarchar](50) NOT NULL,
	[Sex] [nvarchar](50) NULL,
	[Relationship] [nvarchar](50) NULL,
	[Birthdate] [date] NULL,
	[patient_SSN] [int] NOT NULL,
	[phonenumber] [int] NOT NULL,
	[relative_ssn] [int] NOT NULL,
 CONSTRAINT [PK_relatives] PRIMARY KEY CLUSTERED 
(
	[patient_SSN] ASC,
	[relative_ssn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[requsted_rooms]    Script Date: 1/10/2022 7:59:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[requsted_rooms](
	[room_id] [int] NOT NULL,
	[patient_requst] [int] NOT NULL,
 CONSTRAINT [PK_requsted_rooms] PRIMARY KEY CLUSTERED 
(
	[room_id] ASC,
	[patient_requst] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rooms]    Script Date: 1/10/2022 7:59:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rooms](
	[Id] [int] NOT NULL,
	[patient_ssn] [int] NULL,
 CONSTRAINT [PK_rooms] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[schedule]    Script Date: 1/10/2022 7:59:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[schedule](
	[doctor_id] [int] NOT NULL,
	[starttime] [int] NOT NULL,
	[day] [nvarchar](50) NOT NULL,
	[endtime] [int] NOT NULL,
 CONSTRAINT [PK_schedule_1] PRIMARY KEY CLUSTERED 
(
	[doctor_id] ASC,
	[starttime] ASC,
	[day] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_administrator]    Script Date: 1/10/2022 7:59:51 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_administrator] ON [dbo].[administrator]
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Doctor]    Script Date: 1/10/2022 7:59:51 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Doctor] ON [dbo].[Doctor]
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_patient]    Script Date: 1/10/2022 7:59:51 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_patient] ON [dbo].[patient]
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_receptionist]    Script Date: 1/10/2022 7:59:51 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_receptionist] ON [dbo].[receptionist]
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ambulance]  WITH CHECK ADD  CONSTRAINT [FK_ambulance_patient] FOREIGN KEY([patient_ssn])
REFERENCES [dbo].[patient] ([SSN])
GO
ALTER TABLE [dbo].[ambulance] CHECK CONSTRAINT [FK_ambulance_patient]
GO
ALTER TABLE [dbo].[appointment]  WITH CHECK ADD  CONSTRAINT [FK_appointment_clinic] FOREIGN KEY([clinic_id])
REFERENCES [dbo].[clinic] ([id])
GO
ALTER TABLE [dbo].[appointment] CHECK CONSTRAINT [FK_appointment_clinic]
GO
ALTER TABLE [dbo].[appointment]  WITH CHECK ADD  CONSTRAINT [FK_appointment_patient] FOREIGN KEY([patient_ssn])
REFERENCES [dbo].[patient] ([SSN])
GO
ALTER TABLE [dbo].[appointment] CHECK CONSTRAINT [FK_appointment_patient]
GO
ALTER TABLE [dbo].[care]  WITH CHECK ADD  CONSTRAINT [FK_care_Doctor] FOREIGN KEY([Doctor_id])
REFERENCES [dbo].[Doctor] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[care] CHECK CONSTRAINT [FK_care_Doctor]
GO
ALTER TABLE [dbo].[care]  WITH CHECK ADD  CONSTRAINT [FK_care_patient] FOREIGN KEY([patient_ssn])
REFERENCES [dbo].[patient] ([SSN])
GO
ALTER TABLE [dbo].[care] CHECK CONSTRAINT [FK_care_patient]
GO
ALTER TABLE [dbo].[clinic]  WITH CHECK ADD  CONSTRAINT [FK_clinic_doctor] FOREIGN KEY([doctor_id])
REFERENCES [dbo].[Doctor] ([id])
GO
ALTER TABLE [dbo].[clinic] CHECK CONSTRAINT [FK_clinic_doctor]
GO
ALTER TABLE [dbo].[Department]  WITH CHECK ADD  CONSTRAINT [FK_Department_Doctor] FOREIGN KEY([Mng_id])
REFERENCES [dbo].[Doctor] ([id])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Department] CHECK CONSTRAINT [FK_Department_Doctor]
GO
ALTER TABLE [dbo].[Doctor]  WITH CHECK ADD  CONSTRAINT [FK_Doctor_Department] FOREIGN KEY([DNO])
REFERENCES [dbo].[Department] ([Dnumber])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Doctor] CHECK CONSTRAINT [FK_Doctor_Department]
GO
ALTER TABLE [dbo].[nurses]  WITH CHECK ADD  CONSTRAINT [FK_nurses_rooms] FOREIGN KEY([room_id])
REFERENCES [dbo].[rooms] ([Id])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[nurses] CHECK CONSTRAINT [FK_nurses_rooms]
GO
ALTER TABLE [dbo].[patient_visitlog]  WITH CHECK ADD  CONSTRAINT [FK_patient_visitlog_patient_visitlog] FOREIGN KEY([ssn])
REFERENCES [dbo].[patient] ([SSN])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[patient_visitlog] CHECK CONSTRAINT [FK_patient_visitlog_patient_visitlog]
GO
ALTER TABLE [dbo].[Question]  WITH CHECK ADD  CONSTRAINT [FK_Question_doctor] FOREIGN KEY([doctor_id])
REFERENCES [dbo].[Doctor] ([id])
GO
ALTER TABLE [dbo].[Question] CHECK CONSTRAINT [FK_Question_doctor]
GO
ALTER TABLE [dbo].[Question]  WITH CHECK ADD  CONSTRAINT [FK_Question_patient] FOREIGN KEY([sender_ssn])
REFERENCES [dbo].[patient] ([SSN])
GO
ALTER TABLE [dbo].[Question] CHECK CONSTRAINT [FK_Question_patient]
GO
ALTER TABLE [dbo].[relatives]  WITH CHECK ADD  CONSTRAINT [FK_relatives_relatives] FOREIGN KEY([patient_SSN])
REFERENCES [dbo].[patient] ([SSN])
GO
ALTER TABLE [dbo].[relatives] CHECK CONSTRAINT [FK_relatives_relatives]
GO
ALTER TABLE [dbo].[requsted_rooms]  WITH CHECK ADD  CONSTRAINT [FK_requsted_rooms_patient] FOREIGN KEY([patient_requst])
REFERENCES [dbo].[patient] ([SSN])
GO
ALTER TABLE [dbo].[requsted_rooms] CHECK CONSTRAINT [FK_requsted_rooms_patient]
GO
ALTER TABLE [dbo].[requsted_rooms]  WITH CHECK ADD  CONSTRAINT [FK_requsted_rooms_rooms] FOREIGN KEY([room_id])
REFERENCES [dbo].[rooms] ([Id])
GO
ALTER TABLE [dbo].[requsted_rooms] CHECK CONSTRAINT [FK_requsted_rooms_rooms]
GO
ALTER TABLE [dbo].[rooms]  WITH CHECK ADD  CONSTRAINT [FK_rooms_patient] FOREIGN KEY([patient_ssn])
REFERENCES [dbo].[patient] ([SSN])
GO
ALTER TABLE [dbo].[rooms] CHECK CONSTRAINT [FK_rooms_patient]
GO
ALTER TABLE [dbo].[schedule]  WITH CHECK ADD  CONSTRAINT [FK_schedule_Docto] FOREIGN KEY([doctor_id])
REFERENCES [dbo].[Doctor] ([id])
GO
ALTER TABLE [dbo].[schedule] CHECK CONSTRAINT [FK_schedule_Docto]
GO
USE [master]
GO
ALTER DATABASE [project1] SET  READ_WRITE 
GO
