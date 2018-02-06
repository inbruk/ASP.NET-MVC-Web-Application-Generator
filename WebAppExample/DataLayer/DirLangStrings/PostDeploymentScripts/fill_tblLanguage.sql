SET IDENTITY_INSERT tblLanguage ON;

IF NOT EXISTS( SELECT * FROM tblLanguage WHERE Id=1 )
BEGIN
    INSERT INTO tblLanguage 
        ( Id, EnumName, UIName )
    VALUES
        ( 1, 'Russian', 'Русский' );
END;

SET IDENTITY_INSERT tblLanguage OFF;
GO
