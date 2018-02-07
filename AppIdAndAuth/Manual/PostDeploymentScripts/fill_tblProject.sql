
SET IDENTITY_INSERT tblProject ON;

IF NOT EXISTS( SELECT * FROM tblProject WHERE Id=1 )
BEGIN
    INSERT INTO tblProject 
        ( Id, EnumName )
    VALUES
        ( 1, 'Common' );
END

IF NOT EXISTS( SELECT * FROM tblProject WHERE Id=2 )
BEGIN
    INSERT INTO tblProject 
        ( Id, EnumName )
    VALUES
        ( 2, 'WebAppExample' );
END

SET IDENTITY_INSERT tblProject OFF;
GO