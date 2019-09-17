CREATE TABLE [dbo].[遥信变位事件历史库](			
	[ID_KEY] [int] IDENTITY(1,1) NOT NULL,		
	[厂站ID] [varchar](50) NULL,		
	[YXID] [varchar](50) NULL,		
	[值名] [varchar](255) NULL,		
	[状态] [varchar](50) NULL,		
	[时间] [datetime] NULL,		
	[毫秒] [varchar](50) NULL,		
	[comflag] [int] NULL,		
	[备注] [varchar](50) NULL,		
	[等级] [int] NULL		
) ON [PRIMARY]			

CREATE TABLE [dbo].[故障事件历史库](		
	[ID_KEY] [int] IDENTITY(1,1) NOT NULL,	
	[厂站ID] [nvarchar](255) NULL,	
	[标识] [nvarchar](255) NULL,	
	[描述] [nvarchar](255) NULL,	
	[状态] [nvarchar](255) NULL,	
	[设备标识] [nvarchar](255) NULL,	
	[等级] [int] NULL,	
	[风机类型] [nvarchar](255) NULL,	
	[风机标识] [nvarchar](255) NULL,	
	[起始时间] [datetime] NULL,	
	[结束时间] [datetime] NULL,	
	[处理标识] [int] NULL,	
	[操作指导] [nvarchar](255) NULL,	
	[备注] [nvarchar](255) NULL	
) ON [PRIMARY]		

CREATE TABLE [dbo].[变位信息定义库](	
	[标识] [nvarchar](max) NULL,
	[描述] [nvarchar](max) NULL,
	[厂站ID] [nvarchar](max) NULL,
	[合标识] [nvarchar](max) NULL,
	[分标识] [nvarchar](max) NULL,
	[设备] [nchar](10) NULL,
	[等级] [int] NULL,
	[类型] [nchar](10) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]	

CREATE TABLE [dbo].[故障信息定义库](	
	[序号] [float] NULL,
	[标识] [nvarchar](255) NULL,
	[条件] [float] NULL,
	[描述] [nvarchar](255) NULL,
	[厂站ID] [nvarchar](255) NULL,
	[故障告警] [nvarchar](255) NULL,
	[告警等级] [float] NULL,
	[风机类型] [nvarchar](255) NULL,
	[风机标识] [nvarchar](255) NULL,
	[设备标识] [float] NULL,
	[状态测点] [nvarchar](255) NULL,
	[延时时间] [float] NULL,
	[上限值] [float] NULL,
	[下限值] [float] NULL,
	[故障类型] [nvarchar](255) NULL,
	[首伴标识] [float] NULL
) ON [PRIMARY]	

CREATE TABLE [dbo].[故障代码库](		
	[标识] [nvarchar](255) NULL,	
	[故障代码] [float] NULL,	
	[描述] [nvarchar](255) NULL,	
	[厂站ID] [float] NULL,	
	[故障状态] [nvarchar](255) NULL,	
	[告警等级] [float] NULL,	
	[设备标识] [nvarchar](255) NULL,	
	[延时时间] [float] NULL,	
	[首伴标识] [float] NULL	
) ON [PRIMARY]	
