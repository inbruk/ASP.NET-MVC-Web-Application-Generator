CREATE TABLE [dbo].[tblAuthenticationActor]
(
    [Id] BIGINT IDENTITY (1,1) NOT NULL PRIMARY KEY, 
    [Login] NVARCHAR(32) NOT NULL,
    [PasswordSalt] NVARCHAR(64) NOT NULL,
    [PasswordHash] NVARCHAR(64) NOT NULL,
	[IsBanned] BIT NOT NULL DEFAULT(0)
)
