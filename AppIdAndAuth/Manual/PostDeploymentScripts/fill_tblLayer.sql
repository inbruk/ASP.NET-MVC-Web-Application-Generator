
SET IDENTITY_INSERT tblLayer ON;

IF NOT EXISTS( SELECT * FROM tblLayer WHERE Id=1 )
BEGIN
    INSERT INTO tblLayer 
        ( Id, EnumName )
    VALUES
        ( 1, 'DataLayer' );
END

IF NOT EXISTS( SELECT * FROM tblLayer WHERE Id=2 )
BEGIN
    INSERT INTO tblLayer 
        ( Id, EnumName )
    VALUES
        ( 2, 'DataAccessLayer' );
END

IF NOT EXISTS( SELECT * FROM tblLayer WHERE Id=3 )
BEGIN
    INSERT INTO tblLayer 
        ( Id, EnumName )
    VALUES
        ( 3, 'DataTransferObjects' );
END

IF NOT EXISTS( SELECT * FROM tblLayer WHERE Id=4 )
BEGIN
    INSERT INTO tblLayer 
        ( Id, EnumName )
    VALUES
        ( 4, 'BusinessLogicLayer' );
END

IF NOT EXISTS( SELECT * FROM tblLayer WHERE Id=5 )
BEGIN
    INSERT INTO tblLayer 
        ( Id, EnumName )
    VALUES
        ( 5, 'WebServiceLayer' );
END

IF NOT EXISTS( SELECT * FROM tblLayer WHERE Id=6 )
BEGIN
    INSERT INTO tblLayer 
        ( Id, EnumName )
    VALUES
        ( 6, 'WebServiceClients' );
END

IF NOT EXISTS( SELECT * FROM tblLayer WHERE Id=7 )
BEGIN
    INSERT INTO tblLayer 
        ( Id, EnumName )
    VALUES
        ( 7, 'WebUserInterface_Model' );
END

IF NOT EXISTS( SELECT * FROM tblLayer WHERE Id=8 )
BEGIN
    INSERT INTO tblLayer 
        ( Id, EnumName )
    VALUES
        ( 8, 'WebUserInterface_Controller' );
END

IF NOT EXISTS( SELECT * FROM tblLayer WHERE Id=9 )
BEGIN
    INSERT INTO tblLayer 
        ( Id, EnumName )
    VALUES
        ( 9, 'WebUserInterface_View' );
END

SET IDENTITY_INSERT tblLayer OFF;
GO