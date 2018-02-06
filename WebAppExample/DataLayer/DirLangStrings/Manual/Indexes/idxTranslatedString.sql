CREATE INDEX idxTranslatedString_Language 
    ON tblTranslatedString( Language ); 
GO

CREATE INDEX idxTranslatedString_TypeRefId 
    ON tblTranslatedString( Type, ReferencedItemId ); 
GO

CREATE INDEX idxTranslatedString_LangTypeRefId 
    ON tblTranslatedString( Language, Type, ReferencedItemId ); 
GO

