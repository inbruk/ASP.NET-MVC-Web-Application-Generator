CREATE TABLE tblDirectoryValue (
    Id BIGINT IDENTITY (1,1) NOT NULL PRIMARY KEY, 
    EnumName NVARCHAR(16), 
    IsReadOnly BIT, 
    DirectoryId BIGINT FOREIGN KEY REFERENCES tblDirectory(Id)
);
GO
