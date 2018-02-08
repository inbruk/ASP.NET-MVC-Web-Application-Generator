
SET IDENTITY_INSERT tblDirectory ON;


IF NOT EXISTS( SELECT * FROM tblDirectory WHERE Id=1 )
BEGIN
    INSERT INTO tblDirectory 
        ( Id, EnumName, IsReadOnly )
    VALUES
        ( 1, 'Position', 1 );
END

IF NOT EXISTS( SELECT * FROM tblDirectory WHERE Id=2 )
BEGIN
    INSERT INTO tblDirectory 
        ( Id, EnumName, IsReadOnly )
    VALUES
        ( 2, 'Gender', 1 );
END

IF NOT EXISTS( SELECT * FROM tblDirectory WHERE Id=3 )
BEGIN
    INSERT INTO tblDirectory 
        ( Id, EnumName, IsReadOnly )
    VALUES
        ( 3, 'MaritalStatus', 1 );
END

IF NOT EXISTS( SELECT * FROM tblDirectory WHERE Id=4 )
BEGIN
    INSERT INTO tblDirectory 
        ( Id, EnumName, IsReadOnly )
    VALUES
        ( 4, 'AccountState', 1 );
END

IF NOT EXISTS( SELECT * FROM tblDirectory WHERE Id=5 )
BEGIN
    INSERT INTO tblDirectory 
        ( Id, EnumName, IsReadOnly )
    VALUES
        ( 5, 'VehicleBrand', 1 );
END

SET IDENTITY_INSERT tblDirectory OFF;
GO
