namespace AspNetMvcWebApplicationGenerator.Instance.Configuration.Data
{
    using AspNetMvcWebApplicationGenerator.Configuration.DataLayer;

    public static class CreateLanguages
    {
        public static void Create()
        {
            DataConfiguration.AddLanguage( new LanguageItem( 1, "Russian", "Русский" ) );
        }
    }
}
