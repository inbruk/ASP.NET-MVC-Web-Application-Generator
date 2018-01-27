CREATE TABLE tblDirectory (
    Id BIGINT IDENTITY (1,1) NOT NULL PRIMARY KEY, 
    EnumName NVARCHAR(16), 
    IsReadOnly BIT 
);
GO
