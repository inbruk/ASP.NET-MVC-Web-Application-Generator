CREATE INDEX [idxAuthorizationSimpleEntity_Role] 
	ON [dbo].[tblAuthorizationSimpleEntity](RoleId);
GO

CREATE INDEX [idxAuthorizationSimpleEntity_Subsystem] 
	ON [dbo].[tblAuthorizationSimpleEntity](EntityId);
GO

CREATE INDEX [idxAuthorizationSimpleEntity_RoleSubsystem] 
	ON [dbo].[tblAuthorizationSimpleEntity]( RoleId, EntityId );
GO
