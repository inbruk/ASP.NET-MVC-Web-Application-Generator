
SET IDENTITY_INSERT tblDirectory ON;


INSERT INTO tblDirectory 
    ( Id, EnumName, IsReadOnly )
VALUES
    ( 1, 'Position', 1 );

INSERT INTO tblDirectory 
    ( Id, EnumName, IsReadOnly )
VALUES
    ( 2, 'Gender', 1 );

INSERT INTO tblDirectory 
    ( Id, EnumName, IsReadOnly )
VALUES
    ( 3, 'MaritalStatus', 1 );

INSERT INTO tblDirectory 
    ( Id, EnumName, IsReadOnly )
VALUES
    ( 4, 'AccountState', 1 );

INSERT INTO tblDirectory 
    ( Id, EnumName, IsReadOnly )
VALUES
    ( 5, 'VehicleBrand', 1 );

SET IDENTITY_INSERT tblDirectory OFF;
GO
