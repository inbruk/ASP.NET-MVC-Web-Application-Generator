CREATE INDEX [idxAuthorizationSimpleEntities_Role] 
	ON [dbo].[tblAuthorizationSimpleEntities](RoleId);
GO

CREATE INDEX [idxAuthorizationSimpleEntities_Subsystem] 
	ON [dbo].[tblAuthorizationSimpleEntities](EntityId);
GO

CREATE INDEX [idxAuthorizationSimpleEntities_RoleSubsystem] 
	ON [dbo].[tblAuthorizationSimpleEntities]( RoleId, EntityId );
GO
