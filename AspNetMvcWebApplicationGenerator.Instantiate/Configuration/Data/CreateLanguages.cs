namespace AspNetMvcWebApplicationGenerator.Instance.Configuration.Data
{
    using System;

    using AspNetMvcWebApplicationGenerator.Generators.Configuration.DataLayer;

    internal static class CreateLanguages
    {
        public static void Create()
        {
            DataConfiguration.AddLanguage( new LanguageItem( 1, "Russian", "Русский" ) );
        }
    }
}
