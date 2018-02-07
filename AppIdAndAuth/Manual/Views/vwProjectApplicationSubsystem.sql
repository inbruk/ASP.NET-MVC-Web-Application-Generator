CREATE VIEW [dbo].[vwProjectApplicationSubsystem]
AS 
	SELECT 
		TPR.Id AS ProjectId,
		TPR.EnumName AS ProjectEnumName,
		TAP.Id AS ApplicationId,
		TAP.EnumName AS ApplicationEnumName,
		TSU.Id AS SubsystemId,
		TSU.EnumName AS SubsystemEnumName
	FROM [tblProject] AS TPR
	INNER JOIN [tblApplication] AS TAP ON TPR.Id = TAP.ProjectId
	INNER JOIN [tblSubsystem] AS TSU ON TAP.Id = TSU.ApplicationId;
GO