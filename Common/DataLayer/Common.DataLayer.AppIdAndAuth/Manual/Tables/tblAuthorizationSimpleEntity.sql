CREATE TABLE [dbo].[tblAuthorizationSimpleEntity]
(
	[RoleId] BIGINT NOT NULL FOREIGN KEY REFERENCES tblAuthenticationRole(Id),
    [EntityId] BIGINT NOT NULL FOREIGN KEY REFERENCES tblApplicationIdSubsystem(Id), 

    [AllowMethodReadWithFilters] BIT NOT NULL DEFAULT(0),
    [AllowMethodCreateOne] BIT NOT NULL DEFAULT(0),
    [AllowMethodReadOne] BIT NOT NULL DEFAULT(0), 
    [AllowMethodUpdateOne] BIT NOT NULL DEFAULT(0),
    [AllowMethodDeleteOne] BIT NOT NULL DEFAULT(0),
    [AllowMethodCreateMultiple] BIT NOT NULL DEFAULT(0),
    [AllowMethodReadMultiple] BIT NOT NULL DEFAULT(0),
    [AllowMethodUpdateMultiple] BIT NOT NULL DEFAULT(0),
    [AllowMethodDeleteMultiple] BIT NOT NULL DEFAULT(0), 
    [AllowMethodCreateLink] BIT NOT NULL DEFAULT(0), 
    [AllowMethodReadLink] BIT NOT NULL DEFAULT(0), 
    [AllowMethodUpdateLink] BIT NOT NULL DEFAULT(0),
    [AllowMethodDeleteLink] BIT NOT NULL DEFAULT(0),
	
	CONSTRAINT cstRoleEntity UNIQUE (RoleId, EntityId)
) 
