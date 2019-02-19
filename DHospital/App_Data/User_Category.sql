
CREATE TABLE [dbo].[User_Category](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL
) ON [PRIMARY]

go
Insert into User_Category values(1,'Doctor')
Insert into User_Category values(1,'Patient')
Insert into User_Category values(1,'Assistant')