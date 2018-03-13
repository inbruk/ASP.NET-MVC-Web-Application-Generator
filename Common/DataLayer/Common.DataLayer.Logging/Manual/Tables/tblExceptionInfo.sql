CREATE TABLE [dbo].[tblExceptionInfo]
(
	[Id] BIGINT NOT NULL PRIMARY KEY,
    [InnerExceptionId] BIGINT NULL FOREIGN KEY REFERENCES tblExceptionInfo(Id),
    [IsParentException] BIT NOT NULL,     
    [DateTime]   DATETIMEOFFSET NOT NULL,
    [Value]      NVARCHAR(128) NULL, 
    [Data]       NVARCHAR(MAX) NULL,
    [TargetSite] NVARCHAR(MAX) NULL,
    [Message]    NVARCHAR(MAX) NOT NULL, 
    [StackTrace] NVARCHAR(MAX) NULL,
    [Sources]    NVARCHAR(MAX) NULL
)
