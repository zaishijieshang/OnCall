USE [OnCallDB]
GO
/****** Object:  Table [dbo].[MessageBox]    Script Date: 2019/9/13 星期五 上午 11:23:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MessageBox](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Sender] [nvarchar](50) NULL,
	[SenderID] [int] NULL,
	[Receiver] [nvarchar](50) NULL,
	[ReceiverID] [int] NULL,
	[SendTime] [datetime] NULL,
	[CreateTime] [datetime] NULL,
	[Title] [nvarchar](50) NULL,
	[Content] [nvarchar](500) NULL,
	[Type] [int] NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK_MessageBox] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MessageFault]    Script Date: 2019/9/13 星期五 上午 11:23:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MessageFault](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Content] [nvarchar](200) NULL,
	[CreateTime] [datetime] NULL,
	[FaultCount] [int] NULL,
	[Status] [int] NULL,
	[AlarmLevel] [nvarchar](20) NULL,
	[FactoryID] [nvarchar](250) NULL,
	[FanID] [nvarchar](250) NULL,
	[ToUserID] [int] NULL,
 CONSTRAINT [PK_MessageFault] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MessageHistory]    Script Date: 2019/9/13 星期五 上午 11:23:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MessageHistory](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Content] [nvarchar](200) NULL,
	[CreateTime] [datetime] NULL,
	[FaultCount] [int] NULL,
	[Status] [int] NULL,
	[AlarmLevel] [nvarchar](20) NULL,
	[FactoryID] [nvarchar](250) NULL,
	[FanID] [nvarchar](250) NULL,
	[ToUserID] [int] NULL,
 CONSTRAINT [PK_MessageHistory] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MessageQueue]    Script Date: 2019/9/13 星期五 上午 11:23:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MessageQueue](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Content] [nvarchar](200) NULL,
	[CreateTime] [datetime] NULL,
	[FaultCount] [int] NULL,
	[Status] [int] NULL,
	[AlarmLevel] [nvarchar](20) NULL,
	[FactoryID] [nvarchar](250) NULL,
	[FanID] [nvarchar](250) NULL,
 CONSTRAINT [PK_MessageQueue] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sys_AlarmLevel]    Script Date: 2019/9/13 星期五 上午 11:23:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sys_AlarmLevel](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AlarmLevel] [nvarchar](50) NULL,
 CONSTRAINT [PK_Sys_AlarmLevel] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sys_Configure]    Script Date: 2019/9/13 星期五 上午 11:23:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sys_Configure](
	[ID] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Sys_Configure] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sys_Keywords]    Script Date: 2019/9/13 星期五 上午 11:23:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sys_Keywords](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Keyword] [nvarchar](50) NULL,
	[ReplaceValue] [nvarchar](50) NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK_Sys_Keywords] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sys_Menu]    Script Date: 2019/9/13 星期五 上午 11:23:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sys_Menu](
	[MenuID] [int] IDENTITY(1,1) NOT NULL,
	[MenuTitle] [nvarchar](50) NULL,
	[MenuUrl] [nvarchar](50) NULL,
	[ParentID] [int] NULL,
	[Sort] [int] NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK_Sys_Menu] PRIMARY KEY CLUSTERED 
(
	[MenuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sys_Role]    Script Date: 2019/9/13 星期五 上午 11:23:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sys_Role](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](50) NULL,
	[Status] [int] NULL,
	[Mark] [nvarchar](200) NULL,
 CONSTRAINT [PK_Sys_Role] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sys_RoleAlarmLevel]    Script Date: 2019/9/13 星期五 上午 11:23:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sys_RoleAlarmLevel](
	[RoleID] [int] NULL,
	[AlarmLevel] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sys_RoleMenu]    Script Date: 2019/9/13 星期五 上午 11:23:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sys_RoleMenu](
	[RoleID] [int] NULL,
	[MenuID] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sys_UserInfo]    Script Date: 2019/9/13 星期五 上午 11:23:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sys_UserInfo](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](30) NULL,
	[RealName] [nvarchar](50) NULL,
	[Pwd] [nvarchar](50) NULL,
	[Mobile] [nvarchar](20) NULL,
	[Wechat] [nvarchar](50) NULL,
	[OpenId] [nvarchar](50) NULL,
	[Dept] [nvarchar](50) NULL,
	[Position] [nvarchar](50) NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK_Sys_UserInfo] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sys_UserRole]    Script Date: 2019/9/13 星期五 上午 11:23:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sys_UserRole](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[RoleID] [int] NULL,
	[UserID] [int] NULL,
	[UserName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Sys_UserRole] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Sys_AlarmLevel] ON 

INSERT [dbo].[Sys_AlarmLevel] ([ID], [AlarmLevel]) VALUES (1, N'A')
INSERT [dbo].[Sys_AlarmLevel] ([ID], [AlarmLevel]) VALUES (2, N'B')
INSERT [dbo].[Sys_AlarmLevel] ([ID], [AlarmLevel]) VALUES (3, N'C')
INSERT [dbo].[Sys_AlarmLevel] ([ID], [AlarmLevel]) VALUES (6, N'D')
SET IDENTITY_INSERT [dbo].[Sys_AlarmLevel] OFF
SET IDENTITY_INSERT [dbo].[Sys_Keywords] ON 

INSERT [dbo].[Sys_Keywords] ([ID], [Keyword], [ReplaceValue], [Status]) VALUES (1, N'港请', N'**', 1)
SET IDENTITY_INSERT [dbo].[Sys_Keywords] OFF
SET IDENTITY_INSERT [dbo].[Sys_Menu] ON 

INSERT [dbo].[Sys_Menu] ([MenuID], [MenuTitle], [MenuUrl], [ParentID], [Sort], [Status]) VALUES (1, N'系统权限', N'/', 0, 3, 1)
INSERT [dbo].[Sys_Menu] ([MenuID], [MenuTitle], [MenuUrl], [ParentID], [Sort], [Status]) VALUES (2, N'报表', N'/', 0, 2, 1)
INSERT [dbo].[Sys_Menu] ([MenuID], [MenuTitle], [MenuUrl], [ParentID], [Sort], [Status]) VALUES (3, N'用户管理', N'/', 0, 1, 1)
INSERT [dbo].[Sys_Menu] ([MenuID], [MenuTitle], [MenuUrl], [ParentID], [Sort], [Status]) VALUES (4, N'消息管理', N'/', 0, 0, 1)
INSERT [dbo].[Sys_Menu] ([MenuID], [MenuTitle], [MenuUrl], [ParentID], [Sort], [Status]) VALUES (5, N'告警级别', N'/SysAlarmLevel', 1, 4, 1)
INSERT [dbo].[Sys_Menu] ([MenuID], [MenuTitle], [MenuUrl], [ParentID], [Sort], [Status]) VALUES (6, N'配置管理', N'/', 1, 3, 1)
INSERT [dbo].[Sys_Menu] ([MenuID], [MenuTitle], [MenuUrl], [ParentID], [Sort], [Status]) VALUES (7, N'关键字管理', N'/SysKeywords', 1, 2, 1)
INSERT [dbo].[Sys_Menu] ([MenuID], [MenuTitle], [MenuUrl], [ParentID], [Sort], [Status]) VALUES (8, N'菜单管理', N'/SysKeywords', 1, 1, 1)
INSERT [dbo].[Sys_Menu] ([MenuID], [MenuTitle], [MenuUrl], [ParentID], [Sort], [Status]) VALUES (9, N'角色管理', N'/SysRole', 1, 1, 1)
INSERT [dbo].[Sys_Menu] ([MenuID], [MenuTitle], [MenuUrl], [ParentID], [Sort], [Status]) VALUES (10, N'告警查询', N'/', 2, 1, 1)
INSERT [dbo].[Sys_Menu] ([MenuID], [MenuTitle], [MenuUrl], [ParentID], [Sort], [Status]) VALUES (11, N'告警统计', N'/', 2, 1, 1)
INSERT [dbo].[Sys_Menu] ([MenuID], [MenuTitle], [MenuUrl], [ParentID], [Sort], [Status]) VALUES (12, N'用户管理', N'/SysUserInfo', 3, 0, 1)
INSERT [dbo].[Sys_Menu] ([MenuID], [MenuTitle], [MenuUrl], [ParentID], [Sort], [Status]) VALUES (13, N'草稿箱', N'/MessageBox/Drafts', 4, 2, 1)
INSERT [dbo].[Sys_Menu] ([MenuID], [MenuTitle], [MenuUrl], [ParentID], [Sort], [Status]) VALUES (14, N'发件箱', N'/MessageBox/Outbox', 4, 1, 1)
INSERT [dbo].[Sys_Menu] ([MenuID], [MenuTitle], [MenuUrl], [ParentID], [Sort], [Status]) VALUES (15, N'收件箱', N'/MessageBox/Inbox', 4, 0, 1)
SET IDENTITY_INSERT [dbo].[Sys_Menu] OFF
SET IDENTITY_INSERT [dbo].[Sys_Role] ON 

INSERT [dbo].[Sys_Role] ([RoleID], [RoleName], [Status], [Mark]) VALUES (1, N'public', 1, N'通用权限')
INSERT [dbo].[Sys_Role] ([RoleID], [RoleName], [Status], [Mark]) VALUES (2, N'manager', 1, N'管理员')
SET IDENTITY_INSERT [dbo].[Sys_Role] OFF
INSERT [dbo].[Sys_RoleAlarmLevel] ([RoleID], [AlarmLevel]) VALUES (2, N'C')
INSERT [dbo].[Sys_RoleAlarmLevel] ([RoleID], [AlarmLevel]) VALUES (2, N'D')
INSERT [dbo].[Sys_RoleAlarmLevel] ([RoleID], [AlarmLevel]) VALUES (1, N'A')
INSERT [dbo].[Sys_RoleAlarmLevel] ([RoleID], [AlarmLevel]) VALUES (1, N'B')
INSERT [dbo].[Sys_RoleAlarmLevel] ([RoleID], [AlarmLevel]) VALUES (1, N'C')
INSERT [dbo].[Sys_RoleAlarmLevel] ([RoleID], [AlarmLevel]) VALUES (1, N'D')
SET IDENTITY_INSERT [dbo].[Sys_UserInfo] ON 

INSERT [dbo].[Sys_UserInfo] ([UserID], [UserName], [RealName], [Pwd], [Mobile], [Wechat], [OpenId], [Dept], [Position], [Status]) VALUES (1, N'admin', N'管理员', N'202CB962AC59075B964B07152D234B70', N'15012753773', NULL, NULL, NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[Sys_UserInfo] OFF
SET IDENTITY_INSERT [dbo].[Sys_UserRole] ON 

INSERT [dbo].[Sys_UserRole] ([ID], [RoleID], [UserID], [UserName]) VALUES (4, 1, 1, N'郑胜')
SET IDENTITY_INSERT [dbo].[Sys_UserRole] OFF
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'发件人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MessageBox', @level2type=N'COLUMN',@level2name=N'Sender'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'发送人ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MessageBox', @level2type=N'COLUMN',@level2name=N'SenderID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'收件人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MessageBox', @level2type=N'COLUMN',@level2name=N'Receiver'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'接收人ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MessageBox', @level2type=N'COLUMN',@level2name=N'ReceiverID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'发送时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MessageBox', @level2type=N'COLUMN',@level2name=N'SendTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MessageBox', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'标题Query' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MessageBox', @level2type=N'COLUMN',@level2name=N'Title'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'内容Query' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MessageBox', @level2type=N'COLUMN',@level2name=N'Content'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'1:收件箱 2:发件箱 3:草稿箱' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MessageBox', @level2type=N'COLUMN',@level2name=N'Type'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MessageBox', @level2type=N'COLUMN',@level2name=N'Status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'消息内容' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MessageFault', @level2type=N'COLUMN',@level2name=N'Content'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MessageFault', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'发送异常次数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MessageFault', @level2type=N'COLUMN',@level2name=N'FaultCount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MessageFault', @level2type=N'COLUMN',@level2name=N'Status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'告警级别' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MessageFault', @level2type=N'COLUMN',@level2name=N'AlarmLevel'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'厂站ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MessageFault', @level2type=N'COLUMN',@level2name=N'FactoryID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'风机标识' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MessageFault', @level2type=N'COLUMN',@level2name=N'FanID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'消息内容' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MessageHistory', @level2type=N'COLUMN',@level2name=N'Content'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MessageHistory', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'发送异常次数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MessageHistory', @level2type=N'COLUMN',@level2name=N'FaultCount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MessageHistory', @level2type=N'COLUMN',@level2name=N'Status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'告警级别' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MessageHistory', @level2type=N'COLUMN',@level2name=N'AlarmLevel'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'厂站ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MessageHistory', @level2type=N'COLUMN',@level2name=N'FactoryID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'风机标识' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MessageHistory', @level2type=N'COLUMN',@level2name=N'FanID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'接收用户ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MessageHistory', @level2type=N'COLUMN',@level2name=N'ToUserID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'消息内容' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MessageQueue', @level2type=N'COLUMN',@level2name=N'Content'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建时间' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MessageQueue', @level2type=N'COLUMN',@level2name=N'CreateTime'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'发送异常次数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MessageQueue', @level2type=N'COLUMN',@level2name=N'FaultCount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'告警级别' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MessageQueue', @level2type=N'COLUMN',@level2name=N'AlarmLevel'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'厂站ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MessageQueue', @level2type=N'COLUMN',@level2name=N'FactoryID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'风机标识' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'MessageQueue', @level2type=N'COLUMN',@level2name=N'FanID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_AlarmLevel', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'等级' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_AlarmLevel', @level2type=N'COLUMN',@level2name=N'AlarmLevel'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'关键字Query' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Keywords', @level2type=N'COLUMN',@level2name=N'Keyword'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'替换值' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Keywords', @level2type=N'COLUMN',@level2name=N'ReplaceValue'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Keywords', @level2type=N'COLUMN',@level2name=N'Status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'菜单ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Menu', @level2type=N'COLUMN',@level2name=N'MenuID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'菜单名称Query' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Menu', @level2type=N'COLUMN',@level2name=N'MenuTitle'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'链接' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Menu', @level2type=N'COLUMN',@level2name=N'MenuUrl'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'父菜单ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Menu', @level2type=N'COLUMN',@level2name=N'ParentID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'排序' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Menu', @level2type=N'COLUMN',@level2name=N'Sort'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Menu', @level2type=N'COLUMN',@level2name=N'Status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Role', @level2type=N'COLUMN',@level2name=N'RoleID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色名称-Query' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Role', @level2type=N'COLUMN',@level2name=N'RoleName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Role', @level2type=N'COLUMN',@level2name=N'Status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'描述' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_Role', @level2type=N'COLUMN',@level2name=N'Mark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_RoleAlarmLevel', @level2type=N'COLUMN',@level2name=N'RoleID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'级别' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_RoleAlarmLevel', @level2type=N'COLUMN',@level2name=N'AlarmLevel'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_RoleMenu', @level2type=N'COLUMN',@level2name=N'RoleID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'菜单ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_RoleMenu', @level2type=N'COLUMN',@level2name=N'MenuID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_UserInfo', @level2type=N'COLUMN',@level2name=N'UserName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'真实姓名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_UserInfo', @level2type=N'COLUMN',@level2name=N'RealName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'密码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_UserInfo', @level2type=N'COLUMN',@level2name=N'Pwd'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'手机号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_UserInfo', @level2type=N'COLUMN',@level2name=N'Mobile'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'微信号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_UserInfo', @level2type=N'COLUMN',@level2name=N'Wechat'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'OpenID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_UserInfo', @level2type=N'COLUMN',@level2name=N'OpenId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'部门' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_UserInfo', @level2type=N'COLUMN',@level2name=N'Dept'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'岗位' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_UserInfo', @level2type=N'COLUMN',@level2name=N'Position'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_UserInfo', @level2type=N'COLUMN',@level2name=N'Status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_UserRole', @level2type=N'COLUMN',@level2name=N'ID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'角色ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_UserRole', @level2type=N'COLUMN',@level2name=N'RoleID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_UserRole', @level2type=N'COLUMN',@level2name=N'UserID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'用户名Selector-Sys_UserInfo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Sys_UserRole', @level2type=N'COLUMN',@level2name=N'UserName'
GO
