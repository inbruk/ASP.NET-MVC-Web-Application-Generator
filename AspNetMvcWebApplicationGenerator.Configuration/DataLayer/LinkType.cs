namespace AspNetMvcWebApplicationGenerator.Configuration.DataLayer
{
    public enum LinkType
    {
        NoLink = 0,
        One2OneVirtualPartOfObject = 1,
        One2OneTablePartOfObject = 2,
        N2OneTableOtherObject = 3,
        N2MTableOtherObject = 4
    }
}
