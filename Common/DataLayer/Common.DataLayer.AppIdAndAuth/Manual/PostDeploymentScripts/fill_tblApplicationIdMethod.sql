SET IDENTITY_INSERT tblApplicationIdMethod ON;

IF NOT EXISTS( SELECT * FROM tblApplicationIdMethod WHERE Id=0 )
BEGIN
    INSERT INTO tblApplicationIdMethod 
        ( Id, EnumName, IsSpecial, SubsystemId )
    VALUES
        ( 0, 'Any possible subsystem', 0, 0 );
END

IF NOT EXISTS( SELECT * FROM tblApplicationIdMethod WHERE Id=1 )
BEGIN
    INSERT INTO tblApplicationIdMethod 
        ( Id, EnumName, IsSpecial, SubsystemId )
    VALUES
        ( 1, 'ReadWithFilters', 0, 0 );
END

IF NOT EXISTS( SELECT * FROM tblApplicationIdMethod WHERE Id=2 )
BEGIN
    INSERT INTO tblApplicationIdMethod 
        ( Id, EnumName, IsSpecial, SubsystemId )
    VALUES
        ( 2, 'Create', 0, 0 );
END

IF NOT EXISTS( SELECT * FROM tblApplicationIdMethod WHERE Id=3 )
BEGIN
    INSERT INTO tblApplicationIdMethod 
        ( Id, EnumName, IsSpecial, SubsystemId )
    VALUES
        ( 3, 'Read', 0, 0 );
END

IF NOT EXISTS( SELECT * FROM tblApplicationIdMethod WHERE Id=4 )
BEGIN
    INSERT INTO tblApplicationIdMethod 
        ( Id, EnumName, IsSpecial, SubsystemId )
    VALUES
        ( 4, 'Update', 0, 0 );
END

IF NOT EXISTS( SELECT * FROM tblApplicationIdMethod WHERE Id=5 )
BEGIN
    INSERT INTO tblApplicationIdMethod 
        ( Id, EnumName, IsSpecial, SubsystemId )
    VALUES
        ( 5, 'Delete', 0, 0 );
END

IF NOT EXISTS( SELECT * FROM tblApplicationIdMethod WHERE Id=6 )
BEGIN
    INSERT INTO tblApplicationIdMethod 
        ( Id, EnumName, IsSpecial, SubsystemId )
    VALUES
        ( 6, 'CreateLink', 0, 0 );
END

IF NOT EXISTS( SELECT * FROM tblApplicationIdMethod WHERE Id=7 )
BEGIN
    INSERT INTO tblApplicationIdMethod 
        ( Id, EnumName, IsSpecial, SubsystemId )
    VALUES
        ( 7, 'ReadLink', 0, 0 );
END

IF NOT EXISTS( SELECT * FROM tblApplicationIdMethod WHERE Id=8 )
BEGIN
    INSERT INTO tblApplicationIdMethod 
        ( Id, EnumName, IsSpecial, SubsystemId )
    VALUES
        ( 8, 'UpdateLink', 0, 0 );
END

IF NOT EXISTS( SELECT * FROM tblApplicationIdMethod WHERE Id=9 )
BEGIN
    INSERT INTO tblApplicationIdMethod 
        ( Id, EnumName, IsSpecial, SubsystemId )
    VALUES
        ( 9, 'DeleteLink', 0, 0 );
END

SET IDENTITY_INSERT tblApplicationIdMethod OFF;
GO

