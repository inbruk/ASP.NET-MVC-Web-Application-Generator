CREATE TABLE tblAccount ( 
    Id BIGINT IDENTITY(1, 1) NOT NULL PRIMARY KEY, 
    Comment NVARCHAR(MAX),
    Balance BIGINT, 
    AccountState BIGINT FOREIGN KEY REFERENCES tblDirectoryValue(Id),
 ); 
GO
