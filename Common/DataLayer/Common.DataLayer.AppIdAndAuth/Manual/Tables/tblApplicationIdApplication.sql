CREATE TABLE [dbo].[tblApplicationIdApplication]
(
    [Id] BIGINT IDENTITY (1,1) NOT NULL PRIMARY KEY, 
    [EnumName] NVARCHAR(64) NOT NULL,
	[ProjectId] BIGINT NOT NULL FOREIGN KEY REFERENCES tblApplicationIdProject(Id)
)
