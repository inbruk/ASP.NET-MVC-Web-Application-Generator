namespace AspNetMvcWebApplicationGenerator.Generators.Configuration.DataLayer
{
    using System;

    public class ComplexEntityFieldFeatures
    {
        public String FieldFullName { get; }

        #region grid column configuration 
            public int GridColumnWidth { get; }
            public Boolean GridColumnIsSortingAllowed { get; }
        #endregion

        #region field filter configuration 
            public Boolean FieldFilterIsRequired { get; }
            public Boolean FieldFilterIsMinRequired { get; }
        #endregion

        public ComplexEntityFieldFeatures
        (
            String fieldFullName,
            int gridColumnWidth,
            Boolean gridColumnIsSortingAllowed,
            Boolean fieldFilterIsRequired,
            Boolean fieldFilterIsMinRequired
        )
        {
            FieldFullName = fieldFullName;
            GridColumnWidth = gridColumnWidth;
            GridColumnIsSortingAllowed = gridColumnIsSortingAllowed;
            FieldFilterIsRequired = fieldFilterIsRequired;
            FieldFilterIsMinRequired = fieldFilterIsMinRequired;
        }
    }
}
