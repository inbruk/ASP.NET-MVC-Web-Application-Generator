SET IDENTITY_INSERT tblApplicationIdProject ON;

IF NOT EXISTS( SELECT * FROM tblApplicationIdProject WHERE Id=0 )
BEGIN
    INSERT INTO tblApplicationIdProject 
        ( Id, EnumName )
    VALUES
        ( 0, 'Any possible project' );
END

IF NOT EXISTS( SELECT * FROM tblApplicationIdProject WHERE Id=1 )
BEGIN
    INSERT INTO tblApplicationIdProject 
        ( Id, EnumName )
    VALUES
        ( 1, 'Common' );
END

IF NOT EXISTS( SELECT * FROM tblApplicationIdProject WHERE Id=2 )
BEGIN
    INSERT INTO tblApplicationIdProject 
        ( Id, EnumName )
    VALUES
        ( 2, 'WebAppExample' );
END

SET IDENTITY_INSERT tblApplicationIdProject OFF;
GO