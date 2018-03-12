CREATE INDEX [idxLogItem_SystemInfoId]
	ON [dbo].[tblLogItem](SystemInfoId);
GO

CREATE INDEX [idxLogItem_ExceptionInfoId]
	ON [dbo].[tblLogItem](ExceptionInfoId);
GO

CREATE INDEX [idxLogItem_SysInfoExcInfo]
	ON [dbo].[tblLogItem](SystemInfoId,ExceptionInfoId);
GO

CREATE INDEX [idxLogItem_ApplicationId]
	ON [dbo].[tblLogItem](ApplicationId);
GO

CREATE INDEX [idxLogItem_LayerId]
	ON [dbo].[tblLogItem](LayerId);
GO

CREATE INDEX [idxLogItem_SubsystemId]
	ON [dbo].[tblLogItem](SubsystemId);
GO

CREATE INDEX [idxLogItem_MethodId]
	ON [dbo].[tblLogItem](MethodId);
GO
