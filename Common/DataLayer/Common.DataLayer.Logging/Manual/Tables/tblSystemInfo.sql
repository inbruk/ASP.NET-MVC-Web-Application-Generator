CREATE TABLE [dbo].[tblSystemInfo]
(
	[Id] BIGINT IDENTITY (1,1) NOT NULL PRIMARY KEY,
    [CommandLine] NVARCHAR(MAX) NULL, 
    [CurrentDirectory] NVARCHAR(MAX) NULL,
    [MachineName] NVARCHAR(128) NULL,
    [OSVersion] NVARCHAR(128) NULL,
    [Is64BitOperatingSystem] BIT NULL,
    [ProcessorCount] NVARCHAR(128) NULL,
    [StackTrace] NVARCHAR(MAX) NULL,
    [SystemDirectory] NVARCHAR(MAX) NULL,
    [SystemPageSize] NVARCHAR(128) NULL,
    [UserName] NVARCHAR(128) NULL,
    [UserDomainName] NVARCHAR(128) NULL,
    [GetLogicalDrives] NVARCHAR(128) NULL
)
