SET IDENTITY_INSERT tblConfiguration ON;

IF NOT EXISTS( SELECT * FROM tblConfiguration WHERE Id=1 )
BEGIN
    INSERT INTO tblConfiguration
        (
			Id, 
			DisableSavingToFile, 
			DisableSavingToWebService, 
			DisableSystemMessage, 
			DisableMessageForUser, 
			DisableInformation, 
			DisableWarning, 
			DisableError, 
			DisableFatalError, 
			DisableDebugMessage 		
		)
    VALUES
        ( 
			1, 
			0, 
			0, 
			0, 
			0, 
			0, 
			0, 
			0, 
			0, 
			0 		
		);
END

SET IDENTITY_INSERT tblConfiguration OFF;
GO