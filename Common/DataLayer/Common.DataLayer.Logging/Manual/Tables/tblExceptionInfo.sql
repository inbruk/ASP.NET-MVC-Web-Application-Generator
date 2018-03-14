CREATE TABLE [dbo].[tblExceptionInfo]
(
	[Id] BIGINT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    [InnerExceptionId] BIGINT NULL FOREIGN KEY REFERENCES tblExceptionInfo(Id),
    [DateTime]   DATETIMEOFFSET NOT NULL,
	[Levels]     NVARCHAR(128) NULL, 
    [Value]      NVARCHAR(128) NULL, 
    [Data]       NVARCHAR(MAX) NULL,
    [TargetSite] NVARCHAR(MAX) NULL,
    [Message]    NVARCHAR(MAX) NOT NULL, 
    [StackTrace] NVARCHAR(MAX) NULL,
    [Sources]    NVARCHAR(MAX) NULL
)
