USE [bd] /* !!!!!!!!!¬вести название своей бд!!!!!!! */
GO

/****** Object:  Table [dbo].[thing]    Script Date: 05.03.2021 23:22:19 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[thing](
	[id] [int] IDENTITY(0,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO

/****** Object:  Index [PK_thing]    Script Date: 05.03.2021 23:22:19 ******/
ALTER TABLE [dbo].[Thing] ADD  CONSTRAINT [PK_Thing] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]

INSERT INTO [dbo].[thing]
           ([name])
     VALUES
           ('thing1'),('thing2'),('thing3')
GO


