namespace AspNetMvcWebApplicationGenerator.Configuration.WebUserInterfaceLayer
{
    using System;
    using System.Collections.Generic;

    public class WebPage
    {
        public WebPageType PageType { get; }
        public String EntityName { get; }
        public Boolean IsReadOnly { get; }

        #region links to other entities 
            public String OwnEntityFieldName { get; }
            public String LinkedEntityName { get; }
            public String LinkedEntityFieldName { get; }
        #endregion

        public List<String> ReadOnlyFieldList { get; }

        public WebPage
        (
            WebPageType pageType,
            String entityName,
            Boolean isReadOnly,
            String ownEntityFieldName,
            String linkedEntityName,
            String linkedEntityFieldName,
            List<String> readOnlyFieldList
        )
        {
            PageType = pageType;
            EntityName = entityName;
            IsReadOnly = isReadOnly;
            OwnEntityFieldName = ownEntityFieldName;
            LinkedEntityName = linkedEntityName;
            LinkedEntityFieldName = linkedEntityFieldName;
            ReadOnlyFieldList = readOnlyFieldList;
        }
    }
}
