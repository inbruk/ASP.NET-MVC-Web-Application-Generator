CREATE TABLE [dbo].[tblAuthenticationRole]
(
    [Id] BIGINT IDENTITY (1,1) NOT NULL PRIMARY KEY, 
	EnumName NVARCHAR(16), 
	[IsReadOnly] BIT NOT NULL DEFAULT(0),
	[IsDeleted] BIT NOT NULL DEFAULT(0)
)
