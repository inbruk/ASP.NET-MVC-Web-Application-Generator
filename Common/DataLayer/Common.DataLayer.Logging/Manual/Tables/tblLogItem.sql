CREATE TABLE [dbo].[tblLogItem]
(
	[Id] BIGINT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[DateTime] DATETIMEOFFSET NOT NULL DEFAULT GETDATE(),
    [Value] NVARCHAR(128) NULL, 
	[Comment] NVARCHAR(MAX) NULL,
    [ApplicationId] BIGINT NOT NULL,
    [LayerId] BIGINT NOT NULL, 
    [SubsystemId] BIGINT NOT NULL, 
    [MethodId] BIGINT NOT NULL, 
    [MethodName] NVARCHAR(128) NULL,
    [StringNumber] BIGINT NULL,  
    [SystemInfoId] BIGINT NULL FOREIGN KEY REFERENCES tblSystemInfo(Id), 
    [ExceptionInfoId] BIGINT NULL FOREIGN KEY REFERENCES tblExceptionInfo(Id)
)
