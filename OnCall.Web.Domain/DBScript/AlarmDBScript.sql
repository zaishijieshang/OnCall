CREATE TABLE [dbo].[ң�ű�λ�¼���ʷ��](			
	[ID_KEY] [int] IDENTITY(1,1) NOT NULL,		
	[��վID] [varchar](50) NULL,		
	[YXID] [varchar](50) NULL,		
	[ֵ��] [varchar](255) NULL,		
	[״̬] [varchar](50) NULL,		
	[ʱ��] [datetime] NULL,		
	[����] [varchar](50) NULL,		
	[comflag] [int] NULL,		
	[��ע] [varchar](50) NULL,		
	[�ȼ�] [int] NULL		
) ON [PRIMARY]			

CREATE TABLE [dbo].[�����¼���ʷ��](		
	[ID_KEY] [int] IDENTITY(1,1) NOT NULL,	
	[��վID] [nvarchar](255) NULL,	
	[��ʶ] [nvarchar](255) NULL,	
	[����] [nvarchar](255) NULL,	
	[״̬] [nvarchar](255) NULL,	
	[�豸��ʶ] [nvarchar](255) NULL,	
	[�ȼ�] [int] NULL,	
	[�������] [nvarchar](255) NULL,	
	[�����ʶ] [nvarchar](255) NULL,	
	[��ʼʱ��] [datetime] NULL,	
	[����ʱ��] [datetime] NULL,	
	[�����ʶ] [int] NULL,	
	[����ָ��] [nvarchar](255) NULL,	
	[��ע] [nvarchar](255) NULL	
) ON [PRIMARY]		

CREATE TABLE [dbo].[��λ��Ϣ�����](	
	[��ʶ] [nvarchar](max) NULL,
	[����] [nvarchar](max) NULL,
	[��վID] [nvarchar](max) NULL,
	[�ϱ�ʶ] [nvarchar](max) NULL,
	[�ֱ�ʶ] [nvarchar](max) NULL,
	[�豸] [nchar](10) NULL,
	[�ȼ�] [int] NULL,
	[����] [nchar](10) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]	

CREATE TABLE [dbo].[������Ϣ�����](	
	[���] [float] NULL,
	[��ʶ] [nvarchar](255) NULL,
	[����] [float] NULL,
	[����] [nvarchar](255) NULL,
	[��վID] [nvarchar](255) NULL,
	[���ϸ澯] [nvarchar](255) NULL,
	[�澯�ȼ�] [float] NULL,
	[�������] [nvarchar](255) NULL,
	[�����ʶ] [nvarchar](255) NULL,
	[�豸��ʶ] [float] NULL,
	[״̬���] [nvarchar](255) NULL,
	[��ʱʱ��] [float] NULL,
	[����ֵ] [float] NULL,
	[����ֵ] [float] NULL,
	[��������] [nvarchar](255) NULL,
	[�װ��ʶ] [float] NULL
) ON [PRIMARY]	

CREATE TABLE [dbo].[���ϴ����](		
	[��ʶ] [nvarchar](255) NULL,	
	[���ϴ���] [float] NULL,	
	[����] [nvarchar](255) NULL,	
	[��վID] [float] NULL,	
	[����״̬] [nvarchar](255) NULL,	
	[�澯�ȼ�] [float] NULL,	
	[�豸��ʶ] [nvarchar](255) NULL,	
	[��ʱʱ��] [float] NULL,	
	[�װ��ʶ] [float] NULL	
) ON [PRIMARY]	
