CREATE INDEX idxTranslatedString_Language 
    ON tblTranslatedString( Language ); 
GO

CREATE INDEX idxTranslatedString_TypeReferencedItemId 
    ON tblTranslatedString( Type, ReferencedItemId ); 
GO
