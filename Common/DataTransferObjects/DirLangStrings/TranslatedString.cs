namespace Common.DataTransferObjects.DirLangStrings
{
    using System;

    public class TranslatedString
    {
        public long Id { get; }
        public long Language { get; }
        public TranslatedStringType Type { get; }
        public long? ReferencedItemId { get; }
        public String Value { get; }
        public Boolean IsDeleted { set; get; } = false;

        public TranslatedString(long id, long language, TranslatedStringType type, long? referencedItemId, String value)
        {
            Id = id;
            Language = language;
            Type = type;
            ReferencedItemId = referencedItemId;
            Value = value;
        }
    }
}
