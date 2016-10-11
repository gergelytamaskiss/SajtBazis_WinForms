CREATE TABLE [dbo].[Users]
(
	[ID] INT NOT NULL IDENTITY(1,1) PRIMARY KEY, 
    [username] VARCHAR(50) NOT NULL, 
    [password] VARCHAR(6) NOT NULL, 
    [permission] VARCHAR(20) NOT NULL, 
    [email] VARCHAR(50) NOT NULL
)
GO