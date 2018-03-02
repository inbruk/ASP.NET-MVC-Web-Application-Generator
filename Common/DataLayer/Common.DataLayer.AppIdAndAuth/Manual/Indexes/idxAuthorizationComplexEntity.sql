CREATE INDEX [idxAuthorizationComplexEntity_Role]
	ON [dbo].[tblAuthorizationComplexEntity] (RoleId);
GO

CREATE INDEX [idxAuthorizationComplexEntity_ComplexEntityName]
	ON [dbo].[tblAuthorizationComplexEntity] (ComplexEntityName);
GO

CREATE INDEX [idxAuthorizationComplexEntity_RoleComplexEntityName]
	ON [dbo].[tblAuthorizationComplexEntity] ( RoleId, ComplexEntityName );
GO
