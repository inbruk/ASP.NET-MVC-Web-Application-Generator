
SET IDENTITY_INSERT tblDirectoryValue ON;


INSERT INTO tblDirectoryValue 
    ( Id, EnumName, IsReadOnly, DirectoryId )
VALUES
    ( 1, 'Driver', 1, 1 );

INSERT INTO tblDirectoryValue 
    ( Id, EnumName, IsReadOnly, DirectoryId )
VALUES
    ( 2, 'Dispatcher', 1, 1 );

INSERT INTO tblDirectoryValue 
    ( Id, EnumName, IsReadOnly, DirectoryId )
VALUES
    ( 3, 'Superviser', 1, 1 );

INSERT INTO tblDirectoryValue 
    ( Id, EnumName, IsReadOnly, DirectoryId )
VALUES
    ( 4, 'Male', 1, 2 );

INSERT INTO tblDirectoryValue 
    ( Id, EnumName, IsReadOnly, DirectoryId )
VALUES
    ( 5, 'Female', 1, 2 );

INSERT INTO tblDirectoryValue 
    ( Id, EnumName, IsReadOnly, DirectoryId )
VALUES
    ( 6, 'Single', 1, 3 );

INSERT INTO tblDirectoryValue 
    ( Id, EnumName, IsReadOnly, DirectoryId )
VALUES
    ( 7, 'Married', 1, 3 );

INSERT INTO tblDirectoryValue 
    ( Id, EnumName, IsReadOnly, DirectoryId )
VALUES
    ( 8, 'Working', 1, 4 );

INSERT INTO tblDirectoryValue 
    ( Id, EnumName, IsReadOnly, DirectoryId )
VALUES
    ( 9, 'Blocked', 1, 4 );

INSERT INTO tblDirectoryValue 
    ( Id, EnumName, IsReadOnly, DirectoryId )
VALUES
    ( 10, 'LADA', 1, 5 );

INSERT INTO tblDirectoryValue 
    ( Id, EnumName, IsReadOnly, DirectoryId )
VALUES
    ( 11, 'GAZ', 1, 5 );

SET IDENTITY_INSERT tblDirectoryValue OFF;
GO
