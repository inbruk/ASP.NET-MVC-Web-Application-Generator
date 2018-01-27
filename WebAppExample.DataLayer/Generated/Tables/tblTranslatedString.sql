CREATE TABLE tblTranslatedString (
    Id BIGINT IDENTITY (1,1) NOT NULL PRIMARY KEY, 
    Language BIGINT, 
    Type INT, 
    ReferencedItemId BIGINT, 
    Value NVARCHAR(MAX) 
);
GO
