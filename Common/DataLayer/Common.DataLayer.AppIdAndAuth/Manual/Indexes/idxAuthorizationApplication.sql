CREATE INDEX [idxAuthorizationApplication_Role]
	ON [dbo].[tblAuthorizationApplication](RoleId);
GO

CREATE INDEX [idxAuthorizationApplication_Application]
	ON [dbo].[tblAuthorizationApplication](ApplicationId);
GO

CREATE INDEX [idxAuthorizationApplication_RoleApplication]
	ON [dbo].[tblAuthorizationApplication](RoleId, ApplicationId);
GO
