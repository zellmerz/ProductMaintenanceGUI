# ProductMaintenanceGUI
Application for customer to manage products and update database

Below is code to create SQL database

--------------------------------------------------------------------------------

IF DB_ID('TechSupport') IS NOT NULL
	DROP DATABASE TechSupport

CREATE DATABASE TechSupport
GO

USE [TechSupport]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 2/10/2016 4:47:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerID] [int] IDENTITY(1000,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Address] [varchar](50) NOT NULL,
	[City] [varchar](20) NOT NULL,
	[State] [char](2) NOT NULL,
	[ZipCode] [varchar](9) NOT NULL,
	[Phone] [varchar](20) NULL,
	[Email] [varchar](50) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Incidents]    Script Date: 2/10/2016 4:47:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Incidents](
	[IncidentID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[ProductCode] [char](10) NOT NULL,
	[TechID] [int] NULL,
	[DateOpened] [datetime] NOT NULL,
	[DateClosed] [datetime] NULL,
	[Title] [varchar](50) NOT NULL,
	[Description] [varchar](2000) NOT NULL,
 CONSTRAINT [PK_Incidents] PRIMARY KEY CLUSTERED 
(
	[IncidentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Products]    Script Date: 2/10/2016 4:47:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductCode] [char](10) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Version] [decimal](18, 1) NOT NULL,
	[ReleaseDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Registrations]    Script Date: 2/10/2016 4:47:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registrations](
	[CustomerID] [int] NOT NULL,
	[ProductCode] [char](10) NOT NULL,
	[RegistrationDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Registrations] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC,
	[ProductCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[States]    Script Date: 2/10/2016 4:47:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[States](
	[StateCode] [char](2) NOT NULL,
	[StateName] [varchar](20) NOT NULL,
	[FirstZipCode] [int] NOT NULL,
	[LastZipCode] [int] NOT NULL,
 CONSTRAINT [PK_States] PRIMARY KEY CLUSTERED 
(
	[StateCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Technicians]    Script Date: 2/10/2016 4:47:41 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Technicians](
	[TechID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Phone] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Technicians] PRIMARY KEY CLUSTERED 
(
	[TechID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1002, N'Ania Irvin', N'PO Box 96621', N'Washington', N'DC', N'20090', N'(301) 555-8950', N'ania@mma.nidc.com')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1004, N'Kenzie Quinn', N'1990 Westwood Blvd Ste 260', N'Los Angeles', N'CA', N'90025', N'(800) 555-8725', N'kenzie@mma.jobtrak.com')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1006, N'Anton Mauro', N'3255 Ramos Cir', N'Sacramento', N'CA', N'95827', N'(916) 555-6670', N'amauro@mma.ccc.org')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1008, N'Kaitlyn Anthoni', N'Box 52001', N'San Francisco', N'CA', N'94152', N'(800) 555-6081', N'kanthoni@mma.pge.com')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1010, N'Kendall Mayte', N'PO Box 2069', N'Fresno', N'CA', N'93718', N'(559) 555-9999', N'kmayte@mma.fresno.ca.gov')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1012, N'Marvin Quintin', N'4420 N. First Street, Suite 108', N'Fresno', N'CA', N'93726', N'(559) 555-9586', N'marvin@mma.expedata.com')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1015, N'Gonzalo Keeton', N'27371 Valderas', N'Mission Viejo', N'CA', N'92691', N'(214) 555-3647', N'')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1016, N'Derek Chaddick', N'1952 "H" Street', N'Fresno', N'CA', N'93718', N'(559) 555-3005', N'dChaddick@mma.fresnophoto.com')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1017, N'Malia Marques', N'7700 Forsyth', N'St Louis', N'MO', N'63105', N'(314) 555-8834', N'malia@mma.TheLibraryLtd.com')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1018, N'Emily Evan', N'1555 W Lane Ave', N'Columbus', N'OH', N'43221', N'(614) 555-4435', N'Emily@mma.MicroCenter.com')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1019, N'Alexandro Alexis', N'3711 W Franklin', N'Fresno', N'CA', N'93706', N'(559) 555-2993', N'alal@mma.yaleindustries.com')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1023, N'Ingrid Neil', N'12 Daniel Road', N'Fairfield', N'NJ', N'07004', N'(201) 555-9742', N'Ingrid@mma.richadvertizing.com')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1026, N'Eileen Lawrence', N'1483 Chain Bridge Rd, Ste 202', N'Mclean', N'VA', N'22101', N'(770) 555-9558', N'eLawrence@mma.ecomm.com')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1027, N'Marjorie Essence', N'PO Box 31', N'East Brunswick', N'NJ', N'08810', N'(800) 555-8110', N'messence@mma.rrbowker.com')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1029, N'Trentin Camron', N'PO Box 61000', N'San Francisco', N'CA', N'94161', N'(800) 555-4426', N'tCamron@mma.ibm.com')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1030, N'Demetrius Hunter', N'PO Box 956', N'Selma', N'CA', N'93662', N'(559) 555-1534', N'demetrius@mma.termite.com')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1033, N'Thalia Neftaly', N'60 Madison Ave', N'New York', N'NY', N'10010', N'(212) 555-4800', N'tneftaly@mma.venture.com')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1034, N'Harley Myles', N'PO Box 7028', N'St Louis', N'MO', N'63177', N'(301) 555-1494', N'harley@mma.cprinting.com')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1037, N'Gideon Paris', N'1033 N Sycamore Ave.', N'Los Angeles', N'CA', N'90038', N'(213) 555-4322', N'gideon@mma.opamp.com')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1038, N'Jayda Maxwell', N'PO Box 39046', N'Minneapolis', N'MN', N'55439', N'(612) 555-0057', N'jmaxwell@mma.ccredit.com')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1040, N'Kristofer Gerald', N'PO Box 40513', N'Jacksonville', N'FL', N'32231', N'(800) 555-6041', N'kgerald@mma.naylorpub.com')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1045, N'Priscilla Carrollton', N'Box 1979', N'Marion', N'OH', N'43305', N'(800) 555-1669', N'pcarrollton@mma.pw.com')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1047, N'Brian Griffin', N'1150 N Tustin Ave', N'Anaheim', N'CA', N'92807', N'(714) 555-9000', N'bgriffin@mma.azteklabel.com')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1049, N'Kaylea Cheyenne', N'2384 E Gettysburg', N'Fresno', N'CA', N'93726', N'(559) 555-0765', N'kaylea@mma.phphoto.com')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1050, N'Kayle Misael', N'PO Box 95857', N'Chicago', N'IL', N'60694', N'(800) 555-5811', N'misael@mma.qualityeducation.com')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1051, N'Clarence Maeve', N'PO Box 7247-7051', N'Philadelphia', N'PA', N'19170', N'(215) 555-8700', N'cmaeve@mma.springhouse.com')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1054, N'Jovon Walker', N'627 Aviation Way', N'Manhatttan Beach', N'CA', N'90266', N'(310) 555-2732', N'jovon@mma.ama.org')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1056, N'Nashalie Angelica', N'828 S Broadway', N'Tarrytown', N'NY', N'10591', N'(800) 555-0037', N'nangelica@mma.aba.org')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1063, N'Leroy Aryn', N'3502 W Greenway #7', N'Phoenix', N'AZ', N'85023', N'(602) 547-0331', N'laryn@mma.computerliteracy.com')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1065, N'Anne Braydon', N'PO Box 942', N'Fresno', N'CA', N'93714', N'(559) 555-7900', N'anne@mma.fcb.com')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1066, N'Leah Colton', N'1626 E Street', N'Fresno', N'CA', N'93786', N'(559) 555-4442', N'lcolton@mma.fresnobee.com')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1067, N'Cesar Arodondo', N'4545 Glenmeade Lane', N'Auburn Hills', N'MI', N'48326', N'(810) 555-3700', N'arododo@mma.drc.com')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1068, N'Rachael Danielson', N'353 E Shaw Ave', N'Fresno', N'CA', N'93710', N'(559) 555-1704', N'rdanielson@mma.eop.com')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1070, N'Salina Edgardo', N'6435 North Palm Ave, Ste 101', N'Fresno', N'CA', N'93704', N'(559) 555-7070', N'sadgardo@mma.rpc.com')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1071, N'Daniel Bradlee', N'4 Cornwall Dr Ste 102', N'East Brunswick', N'NJ', N'08816', N'(908) 555-7222', N'dbradlee@mma.simondirect.com')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1074, N'Quentin Warren', N'PO Box 12332', N'Fresno', N'CA', N'93777', N'(559) 555-3112', N'quentin@mma.valprint.com')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1080, N'Jillian Clifford', N'3250 Spring Grove Ave', N'Cincinnati', N'OH', N'45225', N'(800) 555-1957', N'jillian@mma.champion.com')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1081, N'Angel Lloyd', N'Department #1872', N'San Francisco', N'CA', N'94161', N'(617) 555-0700', N'alloyd@mma.cw.com')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1083, N'Jeanette Helena', N'4775 E Miami River Rd', N'Cleves', N'OH', N'45002', N'(513) 555-3043', N'jhelena@mma.eds.com')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1086, N'Luciano Destin', N'P O Box 7126', N'Pasadena', N'CA', N'91109', N'(800) 555-7009', N'ldestin@mma.mwp.com')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1089, N'Kyra Francis', N'4150 W Shaw Ave ', N'Fresno', N'CA', N'93722', N'(559) 555-8300', N'kyra@mma.abbey.com')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1094, N'Lance Potter', N'28210 N Avenue Stanford', N'Valencia', N'CA', N'91355', N'(805) 555-0584', N'lpotter@mma.bis.com')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1097, N'Jeffrey Smitzen', N'PO Box 1091', N'Fresno', N'CA', N'93714', N'(559) 555-8700', N'jeffrey@mma.coffee.com')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1098, N'Vance Johnson', N'9 River Pk Pl E 400', N'Boston', N'MA', N'02134', N'(508) 555-8737', N'vjohnson@mma.dwr.com')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1100, N'Thom Aaronsen', N'7112 N Fresno St Ste 200', N'Fresno', N'CA', N'93720', N'(559) 555-8484', N'taaronsen@mma.dgm.com')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1112, N'Harold Spivak', N'2874 S Cherry Ave', N'Fresno', N'CA', N'93706', N'(559) 555-2770', N'harold@mma.propane.com')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1113, N'Rachael Bluzinski', N'P.O. Box 860070', N'Pasadena', N'CA', N'91186', N'(415) 555-7600', N'rachael@mma.unocal.com')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1114, N'Reba Hernandez', N'PO Box 2061', N'Fresno', N'CA', N'93718', N'(559) 555-0600', N'rhernandez@mma.yesmed.com')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1116, N'Jaime Ronaldsen', N'3467 W Shaw Ave #103', N'Fresno', N'CA', N'93711', N'(559) 555-8625', N'jronaldsen@mma.zylka.com')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1117, N'Violet Beauregard', N'P.O. Box 505820', N'Reno', N'NV', N'88905', N'(800) 555-0855', N'vbeauregard@mma.ups.com')
INSERT [dbo].[Customers] ([CustomerID], [Name], [Address], [City], [State], [ZipCode], [Phone], [Email]) VALUES (1118, N'Charlie Bucket', N'P.O. Box 1140', N'Memphis', N'TN', N'38101', N'(800) 555-4091', N'cbucket@mma.fedex.com')
SET IDENTITY_INSERT [dbo].[Customers] OFF
SET IDENTITY_INSERT [dbo].[Incidents] ON 

INSERT [dbo].[Incidents] ([IncidentID], [CustomerID], [ProductCode], [TechID], [DateOpened], [DateClosed], [Title], [Description]) VALUES (27, 1010, N'LEAG10    ', 11, CAST(N'2015-12-07 00:00:00.000' AS DateTime), CAST(N'2015-12-08 00:00:00.000' AS DateTime), N'Could not install', N'Media appears to be bad.')
INSERT [dbo].[Incidents] ([IncidentID], [CustomerID], [ProductCode], [TechID], [DateOpened], [DateClosed], [Title], [Description]) VALUES (28, 1117, N'TRNY20    ', 11, CAST(N'2015-12-16 00:00:00.000' AS DateTime), NULL, N'Error importing data', N'Received error message 415 while trying to import data from previous version.')
INSERT [dbo].[Incidents] ([IncidentID], [CustomerID], [ProductCode], [TechID], [DateOpened], [DateClosed], [Title], [Description]) VALUES (29, 1116, N'DRAFT10   ', 13, CAST(N'2015-12-22 00:00:00.000' AS DateTime), NULL, N'Could not install', N'Setup failed with code 104.')
INSERT [dbo].[Incidents] ([IncidentID], [CustomerID], [ProductCode], [TechID], [DateOpened], [DateClosed], [Title], [Description]) VALUES (30, 1010, N'TEAM10    ', 14, CAST(N'2015-12-23 00:00:00.000' AS DateTime), CAST(N'2015-12-24 00:00:00.000' AS DateTime), N'Error launching program', N'Program fails with error code 510, unable to open database.')
INSERT [dbo].[Incidents] ([IncidentID], [CustomerID], [ProductCode], [TechID], [DateOpened], [DateClosed], [Title], [Description]) VALUES (31, 1010, N'TRNY20    ', 14, CAST(N'2015-12-23 00:00:00.000' AS DateTime), NULL, N'Unable to activate product', N'Customer''s product activation key does not work.')
INSERT [dbo].[Incidents] ([IncidentID], [CustomerID], [ProductCode], [TechID], [DateOpened], [DateClosed], [Title], [Description]) VALUES (32, 1056, N'TRNY20    ', 12, CAST(N'2015-12-26 00:00:00.000' AS DateTime), NULL, N'Product activation error', N'Customer could not activate product because of an invalid product activation code.')
INSERT [dbo].[Incidents] ([IncidentID], [CustomerID], [ProductCode], [TechID], [DateOpened], [DateClosed], [Title], [Description]) VALUES (34, 1018, N'DRAFT10   ', 13, CAST(N'2016-01-04 00:00:00.000' AS DateTime), CAST(N'2016-01-04 00:00:00.000' AS DateTime), N'Error launching program', N'Program fails with error code 340: Database exceeds size limit.')
INSERT [dbo].[Incidents] ([IncidentID], [CustomerID], [ProductCode], [TechID], [DateOpened], [DateClosed], [Title], [Description]) VALUES (36, 1065, N'LEAG10    ', NULL, CAST(N'2016-01-06 00:00:00.000' AS DateTime), NULL, N'Error adding data', N'Received error message 201 when trying to add records: database must be reorganized.')
INSERT [dbo].[Incidents] ([IncidentID], [CustomerID], [ProductCode], [TechID], [DateOpened], [DateClosed], [Title], [Description]) VALUES (42, 1097, N'TRNY20    ', NULL, CAST(N'2016-01-10 00:00:00.000' AS DateTime), NULL, N'Unable to import data', N'Import command not available for importing data from previous version.')
INSERT [dbo].[Incidents] ([IncidentID], [CustomerID], [ProductCode], [TechID], [DateOpened], [DateClosed], [Title], [Description]) VALUES (44, 1063, N'LEAG10    ', NULL, CAST(N'2016-01-11 00:00:00.000' AS DateTime), NULL, N'Installation error', N'Error during installation: cmd.exe not found.')
INSERT [dbo].[Incidents] ([IncidentID], [CustomerID], [ProductCode], [TechID], [DateOpened], [DateClosed], [Title], [Description]) VALUES (45, 1089, N'LEAGD10   ', NULL, CAST(N'2016-01-11 00:00:00.000' AS DateTime), NULL, N'Problem upgrading from League Scheduler 1.0', N'Program fails with error 303 when trying to install upgrade.')
INSERT [dbo].[Incidents] ([IncidentID], [CustomerID], [ProductCode], [TechID], [DateOpened], [DateClosed], [Title], [Description]) VALUES (46, 1016, N'TEAM10    ', NULL, CAST(N'2016-01-11 00:00:00.000' AS DateTime), NULL, N'Unable to restore data from backup', N'Error 405 encountered while restoring backup: File not found.')
INSERT [dbo].[Incidents] ([IncidentID], [CustomerID], [ProductCode], [TechID], [DateOpened], [DateClosed], [Title], [Description]) VALUES (47, 1034, N'DRAFT10   ', NULL, CAST(N'2016-01-11 00:00:00.000' AS DateTime), NULL, N'Can''t activate product', N'Product activation code invalid.')
INSERT [dbo].[Incidents] ([IncidentID], [CustomerID], [ProductCode], [TechID], [DateOpened], [DateClosed], [Title], [Description]) VALUES (48, 1049, N'TRNY20    ', NULL, CAST(N'2016-01-11 00:00:00.000' AS DateTime), NULL, N'Unable to print brackets', N'Program doesn''t recognize printer.')
INSERT [dbo].[Incidents] ([IncidentID], [CustomerID], [ProductCode], [TechID], [DateOpened], [DateClosed], [Title], [Description]) VALUES (49, 1083, N'LEAGD10   ', NULL, CAST(N'2016-01-12 00:00:00.000' AS DateTime), NULL, N'Can''t start application', N'Error 521 on startup: database must be reorganized.')
INSERT [dbo].[Incidents] ([IncidentID], [CustomerID], [ProductCode], [TechID], [DateOpened], [DateClosed], [Title], [Description]) VALUES (50, 1116, N'DRAFT10   ', NULL, CAST(N'2016-01-12 00:00:00.000' AS DateTime), NULL, N'Error during data file backup', N'Program abends with error 228 during database backup ')
INSERT [dbo].[Incidents] ([IncidentID], [CustomerID], [ProductCode], [TechID], [DateOpened], [DateClosed], [Title], [Description]) VALUES (51, 1067, N'LEAGD10   ', NULL, CAST(N'2016-01-12 00:00:00.000' AS DateTime), NULL, N'Error when adding new records', N'Received error 340: database exceeds size limit.')
INSERT [dbo].[Incidents] ([IncidentID], [CustomerID], [ProductCode], [TechID], [DateOpened], [DateClosed], [Title], [Description]) VALUES (52, 1066, N'TEAM10    ', NULL, CAST(N'2016-01-13 00:00:00.000' AS DateTime), NULL, N'Installation problem', N'Customer states that the setup program failed with code 203 during configuration.')
SET IDENTITY_INSERT [dbo].[Incidents] OFF
INSERT [dbo].[Products] ([ProductCode], [Name], [Version], [ReleaseDate]) VALUES (N'DRAFT10   ', N'Draft Manager 1.0', CAST(1.0 AS Decimal(18, 1)), CAST(N'2013-09-03 00:00:00.000' AS DateTime))
INSERT [dbo].[Products] ([ProductCode], [Name], [Version], [ReleaseDate]) VALUES (N'DRAFT20   ', N'Draft Manager 2.0', CAST(2.0 AS Decimal(18, 1)), CAST(N'2016-01-17 00:00:00.000' AS DateTime))
INSERT [dbo].[Products] ([ProductCode], [Name], [Version], [ReleaseDate]) VALUES (N'LEAG10    ', N'League Scheduler 1.0', CAST(1.0 AS Decimal(18, 1)), CAST(N'2012-12-03 00:00:00.000' AS DateTime))
INSERT [dbo].[Products] ([ProductCode], [Name], [Version], [ReleaseDate]) VALUES (N'LEAGD10   ', N'League Scheduler Deluxe 1.0', CAST(1.0 AS Decimal(18, 1)), CAST(N'2013-03-03 00:00:00.000' AS DateTime))
INSERT [dbo].[Products] ([ProductCode], [Name], [Version], [ReleaseDate]) VALUES (N'TEAM10    ', N'Team Manager Version 1.0', CAST(1.0 AS Decimal(18, 1)), CAST(N'2013-12-03 00:00:00.000' AS DateTime))
INSERT [dbo].[Products] ([ProductCode], [Name], [Version], [ReleaseDate]) VALUES (N'TRNY10    ', N'Tournament Master Version 1.0', CAST(1.0 AS Decimal(18, 1)), CAST(N'2012-07-03 00:00:00.000' AS DateTime))
INSERT [dbo].[Products] ([ProductCode], [Name], [Version], [ReleaseDate]) VALUES (N'TRNY20    ', N'Tournament Master Version 2.0', CAST(2.0 AS Decimal(18, 1)), CAST(N'2014-09-17 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1002, N'LEAG10    ', CAST(N'2014-05-01 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1004, N'DRAFT10   ', CAST(N'2014-07-11 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1004, N'LEAG10    ', CAST(N'2013-03-19 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1004, N'TRNY10    ', CAST(N'2014-07-13 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1006, N'TRNY10    ', CAST(N'2015-05-18 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1008, N'DRAFT10   ', CAST(N'2014-02-03 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1008, N'LEAG10    ', CAST(N'2013-04-29 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1008, N'TEAM10    ', CAST(N'2014-09-01 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1008, N'TRNY10    ', CAST(N'2012-10-02 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1010, N'LEAG10    ', CAST(N'2013-07-29 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1012, N'DRAFT10   ', CAST(N'2013-09-19 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1015, N'TRNY10    ', CAST(N'2012-11-19 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1016, N'TEAM10    ', CAST(N'2014-08-14 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1017, N'TRNY10    ', CAST(N'2014-11-09 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1018, N'TEAM10    ', CAST(N'2013-12-03 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1018, N'TRNY10    ', CAST(N'2013-06-25 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1019, N'TRNY20    ', CAST(N'2014-12-20 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1023, N'LEAGD10   ', CAST(N'2013-11-12 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1026, N'LEAG10    ', CAST(N'2013-07-02 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1027, N'LEAGD10   ', CAST(N'2013-09-14 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1029, N'LEAGD10   ', CAST(N'2015-04-18 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1029, N'TEAM10    ', CAST(N'2014-09-28 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1030, N'LEAG10    ', CAST(N'2013-07-04 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1033, N'DRAFT10   ', CAST(N'2014-01-20 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1034, N'DRAFT10   ', CAST(N'2013-09-20 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1034, N'LEAGD10   ', CAST(N'2014-08-21 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1034, N'TEAM10    ', CAST(N'2014-08-22 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1037, N'LEAGD10   ', CAST(N'2013-09-10 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1038, N'LEAG10    ', CAST(N'2013-07-03 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1038, N'TRNY10    ', CAST(N'2012-10-03 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1040, N'TRNY10    ', CAST(N'2012-10-07 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1045, N'LEAGD10   ', CAST(N'2013-07-14 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1047, N'LEAGD10   ', CAST(N'2013-08-14 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1047, N'TEAM10    ', CAST(N'2014-04-27 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1047, N'TRNY20    ', CAST(N'2015-08-27 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1049, N'DRAFT10   ', CAST(N'2014-07-11 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1049, N'LEAGD10   ', CAST(N'2014-01-12 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1049, N'TRNY10    ', CAST(N'2015-03-21 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1049, N'TRNY20    ', CAST(N'2015-01-12 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1050, N'LEAGD10   ', CAST(N'2014-02-24 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1051, N'TEAM10    ', CAST(N'2014-09-18 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1054, N'DRAFT10   ', CAST(N'2014-01-07 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1054, N'TRNY20    ', CAST(N'2014-11-09 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1056, N'TRNY20    ', CAST(N'2015-01-06 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1063, N'LEAG10    ', CAST(N'2013-07-02 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1063, N'TEAM10    ', CAST(N'2015-05-05 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1065, N'LEAG10    ', CAST(N'2013-07-21 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1065, N'LEAGD10   ', CAST(N'2014-01-04 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1065, N'TEAM10    ', CAST(N'2014-09-14 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1066, N'LEAGD10   ', CAST(N'2013-06-22 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1066, N'TEAM10    ', CAST(N'2014-04-01 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1066, N'TRNY10    ', CAST(N'2012-12-22 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1067, N'LEAGD10   ', CAST(N'2014-07-04 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1068, N'DRAFT10   ', CAST(N'2013-09-03 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1070, N'DRAFT10   ', CAST(N'2014-01-28 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1070, N'LEAGD10   ', CAST(N'2013-12-09 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1070, N'TEAM10    ', CAST(N'2014-01-29 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1070, N'TRNY20    ', CAST(N'2015-03-13 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1071, N'TRNY10    ', CAST(N'2013-04-15 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1074, N'LEAG10    ', CAST(N'2013-05-02 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1080, N'DRAFT10   ', CAST(N'2014-07-24 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1080, N'LEAGD10   ', CAST(N'2013-07-05 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1080, N'TRNY10    ', CAST(N'2014-11-28 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1081, N'LEAGD10   ', CAST(N'2013-08-09 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1083, N'LEAG10    ', CAST(N'2013-05-07 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1083, N'LEAGD10   ', CAST(N'2013-09-27 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1083, N'TEAM10    ', CAST(N'2014-11-26 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1086, N'LEAG10    ', CAST(N'2013-11-01 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1089, N'LEAG10    ', CAST(N'2015-04-12 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1089, N'LEAGD10   ', CAST(N'2014-04-10 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1089, N'TRNY10    ', CAST(N'2012-12-03 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1094, N'TEAM10    ', CAST(N'2015-07-08 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1097, N'TRNY20    ', CAST(N'2015-03-18 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1098, N'LEAG10    ', CAST(N'2013-06-03 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1098, N'TRNY10    ', CAST(N'2012-10-11 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1100, N'LEAG10    ', CAST(N'2013-02-07 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1112, N'DRAFT10   ', CAST(N'2014-03-27 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1112, N'TRNY10    ', CAST(N'2013-05-12 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1112, N'TRNY20    ', CAST(N'2015-06-13 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1113, N'LEAGD10   ', CAST(N'2013-08-18 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1114, N'TRNY10    ', CAST(N'2015-01-06 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1116, N'DRAFT10   ', CAST(N'2013-12-09 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1117, N'DRAFT10   ', CAST(N'2014-11-06 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1117, N'TRNY10    ', CAST(N'2012-09-04 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1117, N'TRNY20    ', CAST(N'2015-02-22 00:00:00.000' AS DateTime))
INSERT [dbo].[Registrations] ([CustomerID], [ProductCode], [RegistrationDate]) VALUES (1118, N'DRAFT10   ', CAST(N'2014-05-23 00:00:00.000' AS DateTime))
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'AK', N'Alaska', 99500, 99999)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'AL', N'Alabama', 35000, 36999)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'AR', N'Arkansas', 71600, 72999)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'AZ', N'Arizona', 85000, 86599)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'CA', N'California', 90000, 96699)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'CO', N'Colorado', 80000, 81699)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'CT', N'Connecticut', 6000, 6999)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'DC', N'District of Columbia', 20000, 20599)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'DE', N'Delaware', 19700, 19999)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'FL', N'Florida', 32000, 34999)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'GA', N'Georgia', 30000, 31999)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'HI', N'Hawaii', 96700, 96899)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'IA', N'Iowa', 50000, 52899)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'ID', N'Idaho', 83200, 83899)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'IL', N'Illinois', 60000, 62999)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'IN', N'Indiana', 46000, 47999)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'KS', N'Kansas', 66000, 67999)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'KY', N'Kentucky', 40000, 42799)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'LA', N'Lousiana', 70000, 71499)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'MA', N'Massachusetts', 1000, 2799)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'MD', N'Maryland', 20600, 21999)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'ME', N'Maine', 3900, 4999)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'MI', N'Michigan', 48000, 49999)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'MN', N'Minnesota', 55000, 56799)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'MO', N'Missouri', 63000, 65899)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'MS', N'Mississippi', 38600, 39799)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'MT', N'Montana', 59000, 59999)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'NC', N'North Carolina', 27000, 28999)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'ND', N'North Dakota', 58000, 58899)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'NE', N'Nebraska', 68000, 69399)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'NH', N'New Hampshire', 3000, 3899)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'NJ', N'New Jersey', 7000, 8999)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'NM', N'New Mexico', 87000, 88499)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'NV', N'Nevada', 89000, 89899)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'NY', N'New York', 9000, 14999)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'OH', N'Ohio', 43000, 45899)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'OK', N'Oklahoma', 73000, 74999)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'OR', N'Oregon', 97000, 97999)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'PA', N'Pennsylvania', 15000, 19699)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'RI', N'Rhode Island', 2800, 2999)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'SC', N'South Carolina', 29000, 29999)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'SD', N'South Dakota', 57000, 57799)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'TN', N'Tennessee', 37000, 38599)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'TX', N'Texas', 75000, 79999)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'UT', N'Utah', 84000, 84799)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'VA', N'Virginia', 22000, 24699)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'VI', N'Virgin Islands', 801, 850)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'VT', N'Vermont', 5000, 5999)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'WA', N'Washington', 98000, 99499)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'WI', N'Wisconsin', 53000, 54999)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'WV', N'West Virginia', 24700, 26899)
INSERT [dbo].[States] ([StateCode], [StateName], [FirstZipCode], [LastZipCode]) VALUES (N'WY', N'Wyoming', 82000, 83199)
SET IDENTITY_INSERT [dbo].[Technicians] ON 

INSERT [dbo].[Technicians] ([TechID], [Name], [Email], [Phone]) VALUES (11, N'Alison Diaz ', N'alison@sportsprosoftware.com', N'800-555-0443')
INSERT [dbo].[Technicians] ([TechID], [Name], [Email], [Phone]) VALUES (12, N'Jason Lee', N'jason@sportsprosoftware.com', N'800-555-0444')
INSERT [dbo].[Technicians] ([TechID], [Name], [Email], [Phone]) VALUES (13, N'Andrew Wilson', N'awilson@sportsprosoftware.com', N'800-555-0449')
INSERT [dbo].[Technicians] ([TechID], [Name], [Email], [Phone]) VALUES (14, N'Gunter Wendt', N'gunter@sportsprosoftware.com', N'800-555-0400')
INSERT [dbo].[Technicians] ([TechID], [Name], [Email], [Phone]) VALUES (15, N'Gina Fiori', N'gfiori@sportsprosoftware.com', N'800-555-0459')
SET IDENTITY_INSERT [dbo].[Technicians] OFF
ALTER TABLE [dbo].[Customers]  WITH CHECK ADD  CONSTRAINT [FK_States_Customers] FOREIGN KEY([State])
REFERENCES [dbo].[States] ([StateCode])
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [FK_States_Customers]
GO
ALTER TABLE [dbo].[Incidents]  WITH CHECK ADD  CONSTRAINT [FK_Incidents_Customers] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerID])
GO
ALTER TABLE [dbo].[Incidents] CHECK CONSTRAINT [FK_Incidents_Customers]
GO
ALTER TABLE [dbo].[Incidents]  WITH NOCHECK ADD  CONSTRAINT [FK_Incidents_Products] FOREIGN KEY([ProductCode])
REFERENCES [dbo].[Products] ([ProductCode])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Incidents] CHECK CONSTRAINT [FK_Incidents_Products]
GO
ALTER TABLE [dbo].[Incidents]  WITH NOCHECK ADD  CONSTRAINT [FK_Incidents_Technicians] FOREIGN KEY([TechID])
REFERENCES [dbo].[Technicians] ([TechID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Incidents] CHECK CONSTRAINT [FK_Incidents_Technicians]
GO
ALTER TABLE [dbo].[Registrations]  WITH CHECK ADD  CONSTRAINT [FK_Registrations_Customers] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerID])
GO
ALTER TABLE [dbo].[Registrations] CHECK CONSTRAINT [FK_Registrations_Customers]
GO
ALTER TABLE [dbo].[Registrations]  WITH NOCHECK ADD  CONSTRAINT [FK_Registrations_Products] FOREIGN KEY([ProductCode])
REFERENCES [dbo].[Products] ([ProductCode])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Registrations] CHECK CONSTRAINT [FK_Registrations_Products]
GO
