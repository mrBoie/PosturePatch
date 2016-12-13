CREATE TABLE [dbo].[Client]
(
	[ID] INT NOT NULL PRIMARY KEY, 
    [Name] NCHAR(10) NULL, 
    [Age] TINYINT NULL, 
    [Gender] TINYINT NULL, 
    [Description] VARCHAR(5000) NULL
)
