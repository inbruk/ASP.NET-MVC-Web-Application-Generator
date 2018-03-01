CREATE TABLE [dbo].[tblAuthorizationComplexEntities]
(
	[RoleId] BIGINT NOT NULL FOREIGN KEY REFERENCES tblAuthenticationRole(Id),
    [ComplexEntityName] NVARCHAR(128) NOT NULL, 
    
	[AllowMethodReadWithFilters] BIT NOT NULL DEFAULT(0),

	CONSTRAINT cstRoleComplexEntity UNIQUE (RoleId, ComplexEntityName)
)
