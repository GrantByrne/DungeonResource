CREATE TABLE [dbo].[Logs]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [TimeStamp] DATETIME NULL, 
    [Message] VARCHAR(800) NULL, 
    [Level] VARCHAR(50) NULL, 
    [StackTrace] VARCHAR(8000) NULL, 
    [Url] VARCHAR(500) NULL
)
