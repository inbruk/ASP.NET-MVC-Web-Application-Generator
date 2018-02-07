CREATE TABLE [dbo].[tblSubsystem]
(
    Id BIGINT IDENTITY (1,1) NOT NULL PRIMARY KEY, 
    EnumName NVARCHAR(16),
	ApplicationId BIGINT FOREIGN KEY REFERENCES tblApplication(Id)
);
GO
