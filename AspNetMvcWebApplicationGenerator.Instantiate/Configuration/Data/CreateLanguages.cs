namespace AspNetMvcWebApplicationGenerator.Instantiate
{
    using AspNetMvcWebApplicationGenerator.Configuration.DataLayer;

    public static class Languages
    {
        public static void Create()
        {
            DataConfiguration.AddLanguage( new LanguageItem( 1, "Russian", "Русский" ) );
        }
    }
}
