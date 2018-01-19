namespace AspNetMvcWebApplicationGenerator.Configuration.DataLayer
{
    using System;

    public class TranslatedString
    {
        public long Language { get; }
        public TranslatedStringType Type { get; }
        public long ReferencedItemId { get; }
        public String Value { get; }

        public TranslatedString(long language, TranslatedStringType type, long referencedItemId, String value)
        {
            Language = language;
            Type = type;
            ReferencedItemId = referencedItemId;
            Value = value;
        }

    }
}
