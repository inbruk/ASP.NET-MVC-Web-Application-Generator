
SET IDENTITY_INSERT tblDirectoryValue ON;

IF NOT EXISTS( SELECT * FROM tblDirectoryValue WHERE Id=1 )
BEGIN
    INSERT INTO tblDirectoryValue 
        ( Id, EnumName, IsReadOnly, DirectoryId, IsDeleted )
    VALUES
    ( 1, 'Driver', 1, 1, 0 );
END

IF NOT EXISTS( SELECT * FROM tblDirectoryValue WHERE Id=2 )
BEGIN
    INSERT INTO tblDirectoryValue 
        ( Id, EnumName, IsReadOnly, DirectoryId, IsDeleted )
    VALUES
    ( 2, 'Dispatcher', 1, 1, 0 );
END

IF NOT EXISTS( SELECT * FROM tblDirectoryValue WHERE Id=3 )
BEGIN
    INSERT INTO tblDirectoryValue 
        ( Id, EnumName, IsReadOnly, DirectoryId, IsDeleted )
    VALUES
    ( 3, 'Superviser', 1, 1, 0 );
END

IF NOT EXISTS( SELECT * FROM tblDirectoryValue WHERE Id=4 )
BEGIN
    INSERT INTO tblDirectoryValue 
        ( Id, EnumName, IsReadOnly, DirectoryId, IsDeleted )
    VALUES
    ( 4, 'Male', 1, 2, 0 );
END

IF NOT EXISTS( SELECT * FROM tblDirectoryValue WHERE Id=5 )
BEGIN
    INSERT INTO tblDirectoryValue 
        ( Id, EnumName, IsReadOnly, DirectoryId, IsDeleted )
    VALUES
    ( 5, 'Female', 1, 2, 0 );
END

IF NOT EXISTS( SELECT * FROM tblDirectoryValue WHERE Id=6 )
BEGIN
    INSERT INTO tblDirectoryValue 
        ( Id, EnumName, IsReadOnly, DirectoryId, IsDeleted )
    VALUES
    ( 6, 'Single', 1, 3, 0 );
END

IF NOT EXISTS( SELECT * FROM tblDirectoryValue WHERE Id=7 )
BEGIN
    INSERT INTO tblDirectoryValue 
        ( Id, EnumName, IsReadOnly, DirectoryId, IsDeleted )
    VALUES
    ( 7, 'Married', 1, 3, 0 );
END

IF NOT EXISTS( SELECT * FROM tblDirectoryValue WHERE Id=8 )
BEGIN
    INSERT INTO tblDirectoryValue 
        ( Id, EnumName, IsReadOnly, DirectoryId, IsDeleted )
    VALUES
    ( 8, 'Working', 1, 4, 0 );
END

IF NOT EXISTS( SELECT * FROM tblDirectoryValue WHERE Id=9 )
BEGIN
    INSERT INTO tblDirectoryValue 
        ( Id, EnumName, IsReadOnly, DirectoryId, IsDeleted )
    VALUES
    ( 9, 'Blocked', 1, 4, 0 );
END

IF NOT EXISTS( SELECT * FROM tblDirectoryValue WHERE Id=10 )
BEGIN
    INSERT INTO tblDirectoryValue 
        ( Id, EnumName, IsReadOnly, DirectoryId, IsDeleted )
    VALUES
    ( 10, 'LADA', 1, 5, 0 );
END

IF NOT EXISTS( SELECT * FROM tblDirectoryValue WHERE Id=11 )
BEGIN
    INSERT INTO tblDirectoryValue 
        ( Id, EnumName, IsReadOnly, DirectoryId, IsDeleted )
    VALUES
    ( 11, 'GAZ', 1, 5, 0 );
END

SET IDENTITY_INSERT tblDirectoryValue OFF;
GO
