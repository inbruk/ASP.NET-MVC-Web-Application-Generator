
SET IDENTITY_INSERT tblApplication ON;

IF NOT EXISTS( SELECT * FROM tblApplication WHERE Id=1 )
BEGIN
    INSERT INTO tblApplication 
        ( Id, EnumName, ProjectId )
    VALUES
        ( 1, 'DirLangStrings', 1 );
END

IF NOT EXISTS( SELECT * FROM tblApplication WHERE Id=2 )
BEGIN
    INSERT INTO tblApplication 
        ( Id, EnumName, ProjectId )
    VALUES
        ( 2, 'AppIdAndAuth', 1 );
END

IF NOT EXISTS( SELECT * FROM tblApplication WHERE Id=3 )
BEGIN
    INSERT INTO tblApplication 
        ( Id, EnumName, ProjectId )
    VALUES
        ( 3, 'Logging', 1 );
END

IF NOT EXISTS( SELECT * FROM tblApplication WHERE Id=4 )
BEGIN
    INSERT INTO tblApplication 
        ( Id, EnumName, ProjectId )
    VALUES
        ( 4, 'Engine', 2 );
END

IF NOT EXISTS( SELECT * FROM tblApplication WHERE Id=5 )
BEGIN
    INSERT INTO tblApplication 
        ( Id, EnumName, ProjectId )
    VALUES
        ( 5, 'DriverMobileApplication', 2 );
END

IF NOT EXISTS( SELECT * FROM tblApplication WHERE Id=6 )
BEGIN
    INSERT INTO tblApplication 
        ( Id, EnumName, ProjectId )
    VALUES
        ( 6, 'ASPNET_MVC_Web_Application', 2 );
END

SET IDENTITY_INSERT tblApplication OFF;
GO