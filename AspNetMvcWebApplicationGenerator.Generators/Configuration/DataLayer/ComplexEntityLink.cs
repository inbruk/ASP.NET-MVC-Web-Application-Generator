namespace AspNetMvcWebApplicationGenerator.GeneratorsConfiguration.DataLayer
{
    using System;

    public class ComplexEntityLink
    {
        public ComplexEntityLinkType Type { get; }

        public String LeftShortTableName { get; }
        public String LeftFieldName { get; }

        public Boolean IsRightTableLink { get; }
        public String  RightTableName { get; }
        public String  RightShortTableName { get; }
        public String  RightFieldName { get; }

        public ComplexEntityLink
        (
            ComplexEntityLinkType type,

            String  leftShortTableName,
            String  leftFieldName,

            Boolean isRightTableLink,
            String  rightTableName,
            String  rightShortTableName,
            String  rightFieldName
        )
        {
            Type                = type;

            LeftShortTableName  = leftShortTableName;
            LeftFieldName       = leftFieldName;

            IsRightTableLink    = isRightTableLink;
            RightTableName      = rightTableName;
            RightShortTableName = rightShortTableName;
            RightFieldName      = rightFieldName;
        }
    }
}
