CREATE TABLE tblAccount ( 
    Id BIGINT,
    Comment NVARCHAR(MAX),
    Balance BIGINT,
    AccountState BIGINT FOREIGN KEY REFERENCES tblDirectoryValue(Id),
 ); 
GO
