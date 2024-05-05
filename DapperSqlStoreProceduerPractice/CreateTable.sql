USE [mingkuan]
GO

/****** Object:  Table [dbo].[QandA]    Script Date: 2024/5/5 ¤W¤È 10:39:10 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[QandA](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[question] [text] NULL,
	[answer] [text] NULL,
 CONSTRAINT [PK_QandA] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


		   INSERT INTO [dbo].[QandA]
           ([question]
           ,[answer])
     VALUES
           ('q1',
            'a1')

		   INSERT INTO [dbo].[QandA]
           ([question]
           ,[answer])
     VALUES
           ('q2',
            'a2')

