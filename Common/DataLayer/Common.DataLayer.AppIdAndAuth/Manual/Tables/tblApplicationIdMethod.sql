CREATE TABLE [dbo].[tblApplicationIdMethod]
(
    [Id] BIGINT IDENTITY (1,1) NOT NULL PRIMARY KEY, 
    [EnumName] NVARCHAR(64) NOT NULL,
	[IsSpecial] BIT NOT NULL,
	[SubsystemId] BIGINT NOT NULL FOREIGN KEY REFERENCES tblApplicationIdSubsystem(Id)
)
