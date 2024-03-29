USE [master]
GO
/****** Object:  Database [InformationData]    Script Date: 2022/12/23 19:30:59 ******/
CREATE DATABASE [InformationData]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'InformationData', FILENAME = N'D:\黄油\informationdata\InformationData\InformationData.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'InformationData_log', FILENAME = N'D:\黄油\informationdata\InformationData\InformationData_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [InformationData] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [InformationData].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [InformationData] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [InformationData] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [InformationData] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [InformationData] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [InformationData] SET ARITHABORT OFF 
GO
ALTER DATABASE [InformationData] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [InformationData] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [InformationData] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [InformationData] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [InformationData] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [InformationData] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [InformationData] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [InformationData] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [InformationData] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [InformationData] SET  DISABLE_BROKER 
GO
ALTER DATABASE [InformationData] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [InformationData] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [InformationData] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [InformationData] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [InformationData] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [InformationData] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [InformationData] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [InformationData] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [InformationData] SET  MULTI_USER 
GO
ALTER DATABASE [InformationData] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [InformationData] SET DB_CHAINING OFF 
GO
ALTER DATABASE [InformationData] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [InformationData] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [InformationData] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [InformationData] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'InformationData', N'ON'
GO
ALTER DATABASE [InformationData] SET QUERY_STORE = OFF
GO
USE [InformationData]
GO
/****** Object:  User [user_1]    Script Date: 2022/12/23 19:30:59 ******/
CREATE USER [user_1] WITHOUT LOGIN WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_datareader] ADD MEMBER [user_1]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [user_1]
GO
/****** Object:  Table [dbo].[employee]    Script Date: 2022/12/23 19:30:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employee](
	[id] [nchar](5) NOT NULL,
	[name] [nchar](20) NOT NULL,
	[sex] [nchar](2) NULL,
	[age] [smallint] NULL,
	[dept] [nchar](20) NULL,
 CONSTRAINT [PK_employee] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[employee_education]    Script Date: 2022/12/23 19:30:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employee_education](
	[edu_id] [nchar](5) NOT NULL,
	[education] [nchar](30) NOT NULL,
	[major] [nchar](30) NULL,
	[edu_time] [datetime] NULL,
	[edu_school] [nchar](100) NULL,
	[foreign] [nchar](30) NULL,
 CONSTRAINT [PK_employee_education] PRIMARY KEY CLUSTERED 
(
	[edu_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[employee_marry]    Script Date: 2022/12/23 19:30:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employee_marry](
	[em_id] [nchar](5) NOT NULL,
	[married] [tinyint] NULL,
	[partner_id] [nchar](5) NULL,
 CONSTRAINT [PK_employee_marry] PRIMARY KEY CLUSTERED 
(
	[em_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sys_dept]    Script Date: 2022/12/23 19:30:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sys_dept](
	[dept_id] [nchar](3) NOT NULL,
	[dept_name] [nchar](20) NOT NULL,
 CONSTRAINT [PK_sys_dept] PRIMARY KEY CLUSTERED 
(
	[dept_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sys_job]    Script Date: 2022/12/23 19:30:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sys_job](
	[job_id] [nchar](3) NOT NULL,
	[job_dept_id] [nchar](3) NOT NULL,
	[job_name] [nchar](30) NULL,
	[job_location] [geography] NULL,
 CONSTRAINT [PK_sys_job] PRIMARY KEY CLUSTERED 
(
	[job_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[部门]    Script Date: 2022/12/23 19:30:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[部门](
	[部门编号] [varchar](40) NOT NULL,
	[部门名称] [varchar](40) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[部门编号] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[岗位]    Script Date: 2022/12/23 19:30:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[岗位](
	[岗位编号] [varchar](40) NOT NULL,
	[岗位名称] [varchar](40) NOT NULL,
	[部门编号] [varchar](40) NOT NULL,
	[员工编号] [varchar](40) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[岗位编号] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[员工婚姻信息]    Script Date: 2022/12/23 19:30:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[员工婚姻信息](
	[婚姻编号] [varchar](40) NOT NULL,
	[配偶姓名] [varchar](40) NOT NULL,
	[配偶性别] [varchar](40) NOT NULL,
	[配偶年龄] [varchar](40) NOT NULL,
	[配偶生日] [varchar](40) NOT NULL,
	[员工编号] [varchar](40) NOT NULL,
	[婚姻状况] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[婚姻编号] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[员工基本信息]    Script Date: 2022/12/23 19:30:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[员工基本信息](
	[员工编号] [varchar](40) NOT NULL,
	[姓名] [varchar](40) NOT NULL,
	[性别] [varchar](40) NOT NULL,
	[生日] [varchar](40) NOT NULL,
	[电话] [varchar](40) NOT NULL,
	[入职时间] [varchar](30) NULL,
	[学历编号] [varchar](50) NULL,
	[密码] [nchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[员工编号] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[员工学历信息]    Script Date: 2022/12/23 19:30:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[员工学历信息](
	[学历编号] [varchar](40) NOT NULL,
	[学历] [varchar](40) NOT NULL,
	[专业] [varchar](40) NOT NULL,
	[学校] [varchar](40) NOT NULL,
	[毕业时间] [varchar](40) NOT NULL,
	[外语情况] [varchar](40) NOT NULL,
	[员工编号] [varchar](40) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[学历编号] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [InformationData] SET  READ_WRITE 
GO
