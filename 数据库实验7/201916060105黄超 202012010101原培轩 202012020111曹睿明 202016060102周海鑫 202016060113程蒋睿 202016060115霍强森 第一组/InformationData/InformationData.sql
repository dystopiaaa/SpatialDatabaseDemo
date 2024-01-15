USE [InformationData]
GO
/****** Object:  User [user_1]    Script Date: 2022/12/24 20:50:59 ******/
CREATE USER [user_1] FOR LOGIN [user_1] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_datareader] ADD MEMBER [user_1]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [user_1]
GO
/****** Object:  Table [dbo].[employee]    Script Date: 2022/12/24 20:51:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employee](
	[id] [nchar](5) NOT NULL,
	[name] [nchar](20) NOT NULL,
	[sex] [nchar](2) NULL,
	[age] [smallint] NULL,
	[job_id] [nchar](3) NOT NULL,
	[work_time] [datetime] NULL,
	[title] [nchar](6) NULL,
 CONSTRAINT [PK_employee] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[employee_education]    Script Date: 2022/12/24 20:51:00 ******/
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
/****** Object:  Table [dbo].[employee_marry]    Script Date: 2022/12/24 20:51:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employee_marry](
	[em_id] [nchar](5) NOT NULL,
	[married] [tinyint] NOT NULL,
	[partner_id] [nchar](5) NULL,
 CONSTRAINT [PK_employee_marry] PRIMARY KEY CLUSTERED 
(
	[em_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[sys_dept]    Script Date: 2022/12/24 20:51:00 ******/
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
/****** Object:  Table [dbo].[sys_job]    Script Date: 2022/12/24 20:51:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[sys_job](
	[job_id] [nchar](3) NOT NULL,
	[dept_id] [nchar](3) NOT NULL,
	[job_name] [nchar](30) NULL,
	[job_location] [geography] NULL,
 CONSTRAINT [PK_sys_job] PRIMARY KEY CLUSTERED 
(
	[job_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[employee] ([id], [name], [sex], [age], [job_id], [work_time], [title]) VALUES (N'00001', N'张三                  ', N'男 ', 30, N'1  ', CAST(N'2027-03-05T00:00:00.000' AS DateTime), N'中级    ')
INSERT [dbo].[employee] ([id], [name], [sex], [age], [job_id], [work_time], [title]) VALUES (N'00002', N'李四                  ', N'女 ', 23, N'1  ', CAST(N'2039-12-27T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[employee] ([id], [name], [sex], [age], [job_id], [work_time], [title]) VALUES (N'00003', N'王五                  ', N'男 ', 37, N'1  ', CAST(N'2048-05-12T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[employee] ([id], [name], [sex], [age], [job_id], [work_time], [title]) VALUES (N'00004', N'熊大                  ', N'女 ', 19, N'2  ', CAST(N'2030-03-03T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[employee] ([id], [name], [sex], [age], [job_id], [work_time], [title]) VALUES (N'00005', N'赵上                  ', N'男 ', 20, N'2  ', CAST(N'2025-02-25T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[employee] ([id], [name], [sex], [age], [job_id], [work_time], [title]) VALUES (N'00006', N'邹睿德                 ', N'男 ', 22, N'6  ', CAST(N'2032-12-12T00:00:00.000' AS DateTime), N'初级    ')
INSERT [dbo].[employee] ([id], [name], [sex], [age], [job_id], [work_time], [title]) VALUES (N'00007', N'邵正文                 ', N'男 ', 21, N'5  ', CAST(N'2045-04-07T00:00:00.000' AS DateTime), N'初级    ')
INSERT [dbo].[employee] ([id], [name], [sex], [age], [job_id], [work_time], [title]) VALUES (N'00008', N'张飞昂                 ', N'男 ', 21, N'5  ', CAST(N'2046-04-05T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[employee] ([id], [name], [sex], [age], [job_id], [work_time], [title]) VALUES (N'00009', N'赖瀚玥                 ', N'女 ', 19, N'3  ', CAST(N'2041-04-19T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[employee] ([id], [name], [sex], [age], [job_id], [work_time], [title]) VALUES (N'00010', N'孙一南                 ', N'女 ', 25, N'4  ', CAST(N'2032-12-06T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[employee] ([id], [name], [sex], [age], [job_id], [work_time], [title]) VALUES (N'00011', N'薛春琳                 ', N'女 ', 27, N'3  ', CAST(N'2041-04-09T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[employee] ([id], [name], [sex], [age], [job_id], [work_time], [title]) VALUES (N'00012', N'陆代芙                 ', N'女 ', 23, N'6  ', CAST(N'2044-04-14T00:00:00.000' AS DateTime), N'正高级   ')
INSERT [dbo].[employee] ([id], [name], [sex], [age], [job_id], [work_time], [title]) VALUES (N'00013', N'薛迎梦                 ', N'女 ', 30, N'4  ', CAST(N'2030-11-26T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[employee] ([id], [name], [sex], [age], [job_id], [work_time], [title]) VALUES (N'00014', N'程访云                 ', N'男 ', 46, N'4  ', CAST(N'2050-10-05T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[employee] ([id], [name], [sex], [age], [job_id], [work_time], [title]) VALUES (N'00015', N'康馨欣                 ', N'女 ', 43, N'4  ', CAST(N'2060-08-13T00:00:00.000' AS DateTime), N'副高级   ')
INSERT [dbo].[employee] ([id], [name], [sex], [age], [job_id], [work_time], [title]) VALUES (N'00016', N'唐羽彤                 ', N'女 ', 32, N'6  ', CAST(N'2054-01-02T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[employee] ([id], [name], [sex], [age], [job_id], [work_time], [title]) VALUES (N'00017', N'梁芝宇                 ', N'男 ', 27, N'2  ', CAST(N'2037-07-17T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[employee] ([id], [name], [sex], [age], [job_id], [work_time], [title]) VALUES (N'00018', N'周琇云                 ', N'女 ', 20, N'1  ', CAST(N'2041-10-10T00:00:00.000' AS DateTime), N'初级    ')
INSERT [dbo].[employee] ([id], [name], [sex], [age], [job_id], [work_time], [title]) VALUES (N'00019', N'万若彤                 ', N'男 ', 21, N'1  ', CAST(N'2037-09-15T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[employee] ([id], [name], [sex], [age], [job_id], [work_time], [title]) VALUES (N'00020', N'任冲                  ', N'男 ', 30, N'5  ', CAST(N'1905-06-11T00:00:00.000' AS DateTime), N'中级    ')
GO
INSERT [dbo].[employee_education] ([edu_id], [education], [major], [edu_time], [edu_school], [foreign]) VALUES (N'00001', N'本科                            ', N'空信                            ', CAST(N'2020-12-01T00:00:00.000' AS DateTime), N'清华                                                                                                  ', N'六级                            ')
INSERT [dbo].[employee_education] ([edu_id], [education], [major], [edu_time], [edu_school], [foreign]) VALUES (N'00002', N'本科                            ', N'数学                            ', CAST(N'2021-05-03T00:00:00.000' AS DateTime), N'河工大                                                                                                 ', N'四级                            ')
INSERT [dbo].[employee_education] ([edu_id], [education], [major], [edu_time], [edu_school], [foreign]) VALUES (N'00003', N'专科                            ', N'文学                            ', CAST(N'2018-07-21T00:00:00.000' AS DateTime), N'深职院                                                                                                 ', NULL)
INSERT [dbo].[employee_education] ([edu_id], [education], [major], [edu_time], [edu_school], [foreign]) VALUES (N'00004', N'硕士                            ', N'计科                            ', CAST(N'2015-02-17T00:00:00.000' AS DateTime), NULL, N'四级                            ')
INSERT [dbo].[employee_education] ([edu_id], [education], [major], [edu_time], [edu_school], [foreign]) VALUES (N'00005', N'博士                            ', N'生物                            ', NULL, N'郑大                                                                                                  ', N'四级                            ')
INSERT [dbo].[employee_education] ([edu_id], [education], [major], [edu_time], [edu_school], [foreign]) VALUES (N'00006', N'院士                            ', N'电信                            ', CAST(N'2026-11-11T00:00:00.000' AS DateTime), N'河工大                                                                                                 ', N'六级                            ')
INSERT [dbo].[employee_education] ([edu_id], [education], [major], [edu_time], [edu_school], [foreign]) VALUES (N'00007', N'本科                            ', N'粮食                            ', CAST(N'2026-05-08T00:00:00.000' AS DateTime), N'北大                                                                                                  ', N'六级                            ')
INSERT [dbo].[employee_education] ([edu_id], [education], [major], [edu_time], [edu_school], [foreign]) VALUES (N'00008', N'大专                            ', N'动科                            ', CAST(N'2021-09-17T00:00:00.000' AS DateTime), N'广轻工                                                                                                 ', N'四级                            ')
INSERT [dbo].[employee_education] ([edu_id], [education], [major], [edu_time], [edu_school], [foreign]) VALUES (N'00009', N'本科                            ', N'电信                            ', CAST(N'2002-08-07T00:00:00.000' AS DateTime), N'河工大                                                                                                 ', N'六级                            ')
INSERT [dbo].[employee_education] ([edu_id], [education], [major], [edu_time], [edu_school], [foreign]) VALUES (N'00010', N'硕士                            ', N'空信                            ', NULL, N'河工大                                                                                                 ', N'四级                            ')
INSERT [dbo].[employee_education] ([edu_id], [education], [major], [edu_time], [edu_school], [foreign]) VALUES (N'00011', N'大专                            ', N'德语                            ', CAST(N'2029-12-08T00:00:00.000' AS DateTime), N'广轻工                                                                                                 ', N'四级                            ')
INSERT [dbo].[employee_education] ([edu_id], [education], [major], [edu_time], [edu_school], [foreign]) VALUES (N'00012', N'硕士                            ', N'法语                            ', CAST(N'2032-05-25T00:00:00.000' AS DateTime), N'哈佛                                                                                                  ', NULL)
INSERT [dbo].[employee_education] ([edu_id], [education], [major], [edu_time], [edu_school], [foreign]) VALUES (N'00013', N'本科                            ', N'机械                            ', CAST(N'2025-04-24T00:00:00.000' AS DateTime), N'麻省理工                                                                                                ', N'六级                            ')
INSERT [dbo].[employee_education] ([edu_id], [education], [major], [edu_time], [edu_school], [foreign]) VALUES (N'00014', N'本科                            ', N'土木                            ', CAST(N'2021-08-04T00:00:00.000' AS DateTime), N'同济                                                                                                  ', N'四级                            ')
INSERT [dbo].[employee_education] ([edu_id], [education], [major], [edu_time], [edu_school], [foreign]) VALUES (N'00015', N'大专                            ', N'化学                            ', CAST(N'2002-08-16T00:00:00.000' AS DateTime), N'广轻工                                                                                                 ', N'四级                            ')
INSERT [dbo].[employee_education] ([edu_id], [education], [major], [edu_time], [edu_school], [foreign]) VALUES (N'00016', N'院士                            ', N'金融                            ', CAST(N'2015-07-23T00:00:00.000' AS DateTime), N'合工大                                                                                                 ', N'四级                            ')
INSERT [dbo].[employee_education] ([edu_id], [education], [major], [edu_time], [edu_school], [foreign]) VALUES (N'00017', N'硕士                            ', N'计科                            ', CAST(N'2021-10-16T00:00:00.000' AS DateTime), N'河工大                                                                                                 ', N'四级                            ')
INSERT [dbo].[employee_education] ([edu_id], [education], [major], [edu_time], [edu_school], [foreign]) VALUES (N'00018', N'本科                            ', N'生物                            ', CAST(N'2007-01-07T00:00:00.000' AS DateTime), N'哈佛                                                                                                  ', N'六级                            ')
INSERT [dbo].[employee_education] ([edu_id], [education], [major], [edu_time], [edu_school], [foreign]) VALUES (N'00019', N'本科                            ', N'空信                            ', CAST(N'2022-12-02T00:00:00.000' AS DateTime), N'河工大                                                                                                 ', N'四级                            ')
INSERT [dbo].[employee_education] ([edu_id], [education], [major], [edu_time], [edu_school], [foreign]) VALUES (N'00020', N'本科                            ', N'粮食                            ', CAST(N'2020-02-02T00:00:00.000' AS DateTime), N'河工大                                                                                                 ', N'四级                            ')
GO
INSERT [dbo].[employee_marry] ([em_id], [married], [partner_id]) VALUES (N'00001', 1, N'00004')
INSERT [dbo].[employee_marry] ([em_id], [married], [partner_id]) VALUES (N'00002', 0, NULL)
INSERT [dbo].[employee_marry] ([em_id], [married], [partner_id]) VALUES (N'00003', 0, NULL)
INSERT [dbo].[employee_marry] ([em_id], [married], [partner_id]) VALUES (N'00004', 1, N'00001')
INSERT [dbo].[employee_marry] ([em_id], [married], [partner_id]) VALUES (N'00005', 0, NULL)
INSERT [dbo].[employee_marry] ([em_id], [married], [partner_id]) VALUES (N'00006', 0, NULL)
INSERT [dbo].[employee_marry] ([em_id], [married], [partner_id]) VALUES (N'00007', 1, NULL)
INSERT [dbo].[employee_marry] ([em_id], [married], [partner_id]) VALUES (N'00008', 1, NULL)
INSERT [dbo].[employee_marry] ([em_id], [married], [partner_id]) VALUES (N'00009', 1, N'00014')
INSERT [dbo].[employee_marry] ([em_id], [married], [partner_id]) VALUES (N'00010', 1, N'00020')
INSERT [dbo].[employee_marry] ([em_id], [married], [partner_id]) VALUES (N'00011', 0, NULL)
INSERT [dbo].[employee_marry] ([em_id], [married], [partner_id]) VALUES (N'00012', 0, NULL)
INSERT [dbo].[employee_marry] ([em_id], [married], [partner_id]) VALUES (N'00013', 0, NULL)
INSERT [dbo].[employee_marry] ([em_id], [married], [partner_id]) VALUES (N'00014', 1, N'00009')
INSERT [dbo].[employee_marry] ([em_id], [married], [partner_id]) VALUES (N'00015', 1, N'00017')
INSERT [dbo].[employee_marry] ([em_id], [married], [partner_id]) VALUES (N'00016', 0, NULL)
INSERT [dbo].[employee_marry] ([em_id], [married], [partner_id]) VALUES (N'00017', 1, N'00015')
INSERT [dbo].[employee_marry] ([em_id], [married], [partner_id]) VALUES (N'00018', 0, NULL)
INSERT [dbo].[employee_marry] ([em_id], [married], [partner_id]) VALUES (N'00019', 1, NULL)
INSERT [dbo].[employee_marry] ([em_id], [married], [partner_id]) VALUES (N'00020', 1, N'00010')
GO
INSERT [dbo].[sys_dept] ([dept_id], [dept_name]) VALUES (N'101', N'人事部                 ')
INSERT [dbo].[sys_dept] ([dept_id], [dept_name]) VALUES (N'102', N'会计部                 ')
INSERT [dbo].[sys_dept] ([dept_id], [dept_name]) VALUES (N'103', N'工程部                 ')
GO
INSERT [dbo].[sys_job] ([job_id], [dept_id], [job_name], [job_location]) VALUES (N'1  ', N'101', N'销售员                           ', 0xE6100000010C42CC2555DBE94740FF058200199B5E40)
INSERT [dbo].[sys_job] ([job_id], [dept_id], [job_name], [job_location]) VALUES (N'2  ', N'101', N'前台                            ', 0xE6100000010C39B35DA10F464140E5EFDE5163895B40)
INSERT [dbo].[sys_job] ([job_id], [dept_id], [job_name], [job_location]) VALUES (N'3  ', N'101', N'部门主管                          ', 0xE6100000010CC51C041DAD7A37405B96AFCBF0C05C40)
INSERT [dbo].[sys_job] ([job_id], [dept_id], [job_name], [job_location]) VALUES (N'4  ', N'102', N'会计                            ', 0xE6100000010C1AE1ED4108AC3640AE282504ABFC5840)
INSERT [dbo].[sys_job] ([job_id], [dept_id], [job_name], [job_location]) VALUES (N'5  ', N'102', N'设计师                           ', 0xE6100000010CC59107228B7047408D7BF31B26A35540)
INSERT [dbo].[sys_job] ([job_id], [dept_id], [job_name], [job_location]) VALUES (N'6  ', N'103', N'工程师                           ', 0xE6100000010CCAFE791A3080414012842BA050605C40)
GO
