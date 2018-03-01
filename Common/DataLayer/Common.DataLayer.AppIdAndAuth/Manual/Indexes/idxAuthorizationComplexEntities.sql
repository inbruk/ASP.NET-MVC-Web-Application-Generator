CREATE INDEX [idxAuthorizationComplexEntities_Role]
	ON [dbo].[tblAuthorizationComplexEntities] (RoleId);
GO

CREATE INDEX [idxAuthorizationComplexEntities_ComplexEntityName]
	ON [dbo].[tblAuthorizationComplexEntities] (ComplexEntityName);
GO

CREATE INDEX [idxAuthorizationComplexEntities_RoleComplexEntityName]
	ON [dbo].[tblAuthorizationComplexEntities] ( RoleId, ComplexEntityName );
GO
