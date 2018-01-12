namespace AspNetMvcWebApplicationGenerator.Configuration.DataLayer
{
    using System;
    using System.Collections.Generic;

    public class DLConfiguration
    {
        public Dictionary<long,   LanguageItem>  Languages { get; } = new Dictionary<long, LanguageItem>();
        public Dictionary<String, Directory>     DirectoryConfigurations { get; } = new Dictionary<String, Directory>();
        public Dictionary<String, Entity>        EntitiesConfigurations { get; } = new Dictionary<String, Entity>();
        public Dictionary<String, ComplexEntity> ComplexEntitiesConfigurations { get; } = new Dictionary<string, ComplexEntity>();

        public DLConfiguration
        (
            List<LanguageItem> langs,
            List<Directory> dirCfgs,
            List<Entity> entCfgs,
            List<ComplexEntity> cmplxCfgs
        )
        {
            foreach(var currLang in langs)
                Languages.Add(currLang.Id, currLang);

            foreach (var currDirCfg in dirCfgs)
                DirectoryConfigurations.Add(currDirCfg.EnumName, currDirCfg);

            foreach (var currEntCfg in entCfgs)
                EntitiesConfigurations.Add(currEntCfg.Name, currEntCfg);

            foreach (var currCmplxCfg in cmplxCfgs)
                ComplexEntitiesConfigurations.Add(currCmplxCfg.Name, currCmplxCfg);
        }
    }
}
