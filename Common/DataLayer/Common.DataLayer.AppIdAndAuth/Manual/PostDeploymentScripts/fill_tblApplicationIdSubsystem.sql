SET IDENTITY_INSERT tblApplicationIdSubsystem ON;

IF NOT EXISTS( SELECT * FROM tblApplicationIdSubsystem WHERE Id=0 )
BEGIN
    INSERT INTO tblApplicationIdSubsystem 
        ( Id, EnumName, ApplicationId )
    VALUES
        ( 0, 'Any possible subsystem', 0 );
END

IF NOT EXISTS( SELECT * FROM tblApplicationIdSubsystem WHERE Id=1 )
BEGIN
    INSERT INTO tblApplicationIdSubsystem 
        ( Id, EnumName, ApplicationId )
    VALUES
        ( 1, 'Languages', 1 );
END

IF NOT EXISTS( SELECT * FROM tblApplicationIdSubsystem WHERE Id=2 )
BEGIN
    INSERT INTO tblApplicationIdSubsystem 
        ( Id, EnumName, ApplicationId )
    VALUES
        ( 2, 'Directories', 1 );
END

IF NOT EXISTS( SELECT * FROM tblApplicationIdSubsystem WHERE Id=3 )
BEGIN
    INSERT INTO tblApplicationIdSubsystem 
        ( Id, EnumName, ApplicationId )
    VALUES
        ( 3, 'TranslatedStrings', 1 );
END

IF NOT EXISTS( SELECT * FROM tblApplicationIdSubsystem WHERE Id=4 )
BEGIN
    INSERT INTO tblApplicationIdSubsystem 
        ( Id, EnumName, ApplicationId )
    VALUES
        ( 4, 'Project', 2 );
END

IF NOT EXISTS( SELECT * FROM tblApplicationIdSubsystem WHERE Id=5 )
BEGIN
    INSERT INTO tblApplicationIdSubsystem 
        ( Id, EnumName, ApplicationId )
    VALUES
        ( 5, 'Layer', 2 );
END

IF NOT EXISTS( SELECT * FROM tblApplicationIdSubsystem WHERE Id=6 )
BEGIN
    INSERT INTO tblApplicationIdSubsystem 
        ( Id, EnumName, ApplicationId )
    VALUES
        ( 6, 'Application', 2 );
END

IF NOT EXISTS( SELECT * FROM tblApplicationIdSubsystem WHERE Id=7 )
BEGIN
    INSERT INTO tblApplicationIdSubsystem 
        ( Id, EnumName, ApplicationId )
    VALUES
        ( 7, 'Subsystem', 2 );
END

IF NOT EXISTS( SELECT * FROM tblApplicationIdSubsystem WHERE Id=8 )
BEGIN
    INSERT INTO tblApplicationIdSubsystem 
        ( Id, EnumName, ApplicationId )
    VALUES
        ( 8, 'ProjAppSubTools', 2 );
END

IF NOT EXISTS( SELECT * FROM tblApplicationIdSubsystem WHERE Id=9 )
BEGIN
    INSERT INTO tblApplicationIdSubsystem 
        ( Id, EnumName, ApplicationId )
    VALUES
        ( 9, 'ActorTools', 3 );
END

IF NOT EXISTS( SELECT * FROM tblApplicationIdSubsystem WHERE Id=9 )
BEGIN
    INSERT INTO tblApplicationIdSubsystem 
        ( Id, EnumName, ApplicationId )
    VALUES
        ( 10, 'RoleTools', 3 );
END

IF NOT EXISTS( SELECT * FROM tblApplicationIdSubsystem WHERE Id=11 )
BEGIN
    INSERT INTO tblApplicationIdSubsystem 
        ( Id, EnumName, ApplicationId )
    VALUES
        ( 11, 'ActorRoleTools', 3 );
END

IF NOT EXISTS( SELECT * FROM tblApplicationIdSubsystem WHERE Id=12 )
BEGIN
    INSERT INTO tblApplicationIdSubsystem 
        ( Id, EnumName, ApplicationId )
    VALUES
        ( 12, 'TokenTools', 3 );
END

IF NOT EXISTS( SELECT * FROM tblApplicationIdSubsystem WHERE Id=13 )
BEGIN
    INSERT INTO tblApplicationIdSubsystem 
        ( Id, EnumName, ApplicationId )
    VALUES
        ( 13, 'Authorization', 4 );
END

IF NOT EXISTS( SELECT * FROM tblApplicationIdSubsystem WHERE Id=14 )
BEGIN
    INSERT INTO tblApplicationIdSubsystem 
        ( Id, EnumName, ApplicationId )
    VALUES
        ( 14, 'SystemInfo', 5 );
END

IF NOT EXISTS( SELECT * FROM tblApplicationIdSubsystem WHERE Id=15 )
BEGIN
    INSERT INTO tblApplicationIdSubsystem 
        ( Id, EnumName, ApplicationId )
    VALUES
        ( 15, 'StartShutdownHalt', 5 );
END

IF NOT EXISTS( SELECT * FROM tblApplicationIdSubsystem WHERE Id=16 )
BEGIN
    INSERT INTO tblApplicationIdSubsystem 
        ( Id, EnumName, ApplicationId )
    VALUES
        ( 16, 'Logging', 5 );
END

IF NOT EXISTS( SELECT * FROM tblApplicationIdSubsystem WHERE Id=17 )
BEGIN
    INSERT INTO tblApplicationIdSubsystem 
        ( Id, EnumName, ApplicationId )
    VALUES
        ( 17, 'Engine', 6 );
END

IF NOT EXISTS( SELECT * FROM tblApplicationIdSubsystem WHERE Id=18 )
BEGIN
    INSERT INTO tblApplicationIdSubsystem 
        ( Id, EnumName, ApplicationId )
    VALUES
        ( 18, 'WebApplication', 7 );
END

IF NOT EXISTS( SELECT * FROM tblApplicationIdSubsystem WHERE Id=19 )
BEGIN
    INSERT INTO tblApplicationIdSubsystem 
        ( Id, EnumName, ApplicationId )
    VALUES
        ( 19, 'DriverMobileApp', 8 );
END

SET IDENTITY_INSERT tblApplicationIdSubsystem OFF;
GO