namespace AspNetMvcWebApplicationGenerator.Configuration.WebUserInterfaceLayer
{
    using System;

    public class WebPage
    {
        public WebPageType PageType { get; }
        public String EntityName { get; }

        #region links to other entities 
            public String OwnEntityFieldName { get; }
            public String LinkedEntityName { get; }
            public String LinkedEntityFieldName { get; }
        #endregion

        public WebPage
        (
            WebPageType pageType,
            String entityName,
            String ownEntityFieldName,
            String linkedEntityName,
            String linkedEntityFieldName
        )
        {
            PageType = pageType;
            EntityName = entityName;
            OwnEntityFieldName = ownEntityFieldName;
            LinkedEntityName = linkedEntityName;
            LinkedEntityFieldName = linkedEntityFieldName;
        }
    }
}
