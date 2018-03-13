CREATE TABLE [dbo].[tblConfiguration]
(
	[Id] INT NOT NULL PRIMARY KEY,
    DisableSavingToFile  BIT NOT NULL DEFAULT(0),
    DisableSavingToWebService  BIT NOT NULL DEFAULT(0),
    DisableSystemMessage  BIT NOT NULL DEFAULT(0),
    DisableMessageForUser  BIT NOT NULL DEFAULT(0),
    DisableInformation  BIT NOT NULL DEFAULT(0),
    DisableWarning  BIT NOT NULL DEFAULT(0),
    DisableError  BIT NOT NULL DEFAULT(0),
    DisableFatalError  BIT NOT NULL DEFAULT(0),
    DisableDebugMessage  BIT NOT NULL DEFAULT(0)
)
