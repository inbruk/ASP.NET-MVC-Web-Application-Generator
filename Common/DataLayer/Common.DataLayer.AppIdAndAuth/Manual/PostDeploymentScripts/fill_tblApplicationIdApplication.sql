SET IDENTITY_INSERT tblApplicationIdApplication ON;

IF NOT EXISTS( SELECT * FROM tblApplicationIdApplication WHERE Id=0 )
BEGIN
    INSERT INTO tblApplicationIdApplication 
        ( Id, EnumName, ProjectId )
    VALUES
        ( 0, 'AnyApplication', 0 );
END

IF NOT EXISTS( SELECT * FROM tblApplicationIdApplication WHERE Id=1 )
BEGIN
    INSERT INTO tblApplicationIdApplication 
        ( Id, EnumName, ProjectId )
    VALUES
        ( 1, 'DirLangStrings', 1 );
END

IF NOT EXISTS( SELECT * FROM tblApplicationIdApplication WHERE Id=2 )
BEGIN
    INSERT INTO tblApplicationIdApplication 
        ( Id, EnumName, ProjectId )
    VALUES                                                                      
        ( 2, 'AppIdAndAuth', 1 );
END

IF NOT EXISTS( SELECT * FROM tblApplicationIdApplication WHERE Id=5 )
BEGIN
    INSERT INTO tblApplicationIdApplication 
        ( Id, EnumName, ProjectId )
    VALUES
        ( 5, 'Logging', 1 );
END

IF NOT EXISTS( SELECT * FROM tblApplicationIdApplication WHERE Id=6 )
BEGIN
    INSERT INTO tblApplicationIdApplication 
        ( Id, EnumName, ProjectId )
    VALUES
        ( 6, 'Engine', 2 );
END

IF NOT EXISTS( SELECT * FROM tblApplicationIdApplication WHERE Id=7 )
BEGIN
    INSERT INTO tblApplicationIdApplication 
        ( Id, EnumName, ProjectId )
    VALUES
        ( 7, 'WebApplication', 2 );
END

IF NOT EXISTS( SELECT * FROM tblApplicationIdApplication WHERE Id=8 )
BEGIN
    INSERT INTO tblApplicationIdApplication 
        ( Id, EnumName, ProjectId )
    VALUES
        ( 8, 'DriverMobileApp', 2 );
END

SET IDENTITY_INSERT tblApplicationIdApplication OFF;
GO