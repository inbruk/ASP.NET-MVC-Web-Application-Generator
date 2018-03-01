CREATE TABLE [dbo].[tblAuthorizationApplication]
(
	[RoleId] BIGINT NOT NULL FOREIGN KEY REFERENCES tblAuthenticationRole(Id),
    [ApplicationId] BIGINT NOT NULL FOREIGN KEY REFERENCES tblApplicationIdApplication(Id), 

    [AllowLogIn] BIT NOT NULL DEFAULT(0),

	CONSTRAINT cstRoleApplication UNIQUE (RoleId, ApplicationId)
)
