CREATE TABLE tblTranslatedString (
    Id BIGINT IDENTITY (1,1) NOT NULL PRIMARY KEY, 
    Language BIGINT NOT NULL, 
    Type INT NOT NULL, 
    ReferencedItemId BIGINT, 
    Value NVARCHAR(MAX),
	IsDeleted BIT NOT NULL DEFAULT(0)
);
GO
