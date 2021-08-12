namespace AspNetMvcWebApplicationGenerator.Generators.Configuration.WebUserInterfaceLayer
{
    using System;
    using System.Collections.Generic;

    public class WebPage
    {
        public WebPageType PageType { get; }
        public String EntityName { get; }
        public Boolean IsReadOnly { get; } // only for WebPageType.Crud1EditFrom and WebPageType.CrudNEditFrom

        #region links to other entities for attach/detach
        public String OwnEntityFieldName { get; }
            public String LinkedEntityName { get; }
            public String LinkedEntityFieldName { get; }
        #endregion

        #region only for editable forms
            public List<String> ReadOnlyFieldList { get; } // not supported now
        #endregion

        public WebPage
        (
            WebPageType pageType,
            String entityName,
            Boolean isReadOnly = false,
            String ownEntityFieldName = null,
            String linkedEntityName = null,
            String linkedEntityFieldName = null,
            List<String> readOnlyFieldList = null 
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
