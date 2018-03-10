SET IDENTITY_INSERT tblLanguage ON;

IF NOT EXISTS( SELECT * FROM tblLanguage WHERE Id=1 )
BEGIN
    INSERT INTO tblLanguage 
        ( Id, EnumName, UIName, IsDeleted  )
    VALUES
        ( 1, 'Russian', 'Русский', 0 );
END
SET IDENTITY_INSERT tblLanguage OFF;
GO
