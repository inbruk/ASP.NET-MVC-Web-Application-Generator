namespace Common.BusinessLogicLayer.Logging
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using Auxiliary.CommonOptions;
    using Auxiliary.PatternsAndClasses;

    using Common.DataTransferObjects.Logging;
    using Common.DataAccessLayer.Logging;

    public static class ConfigurationTools
    {
        public static Configuration Read1(long id)
        {
            Configuration result = CurrDBContext.Get().tblConfiguration.Where(x => x.Id == id).
                Select
                (
                    x =>
                    new Configuration
                    (
                        x.Id,
                        x.DisableSavingToFile,
                        x.DisableSavingToWebService,
                        x.DisableSystemMessage,
                        x.DisableMessageForUser,
                        x.DisableInformation,
                        x.DisableWarning,
                        x.DisableError,
                        x.DisableFatalError,
                        x.DisableDebugMessage
                    )
                ).SingleOrDefault();

            return result;
        }

        public static void Update1(Configuration item)
        {
            tblConfiguration dataItem = CurrDBContext.Get().tblConfiguration.Where(x => x.Id == item.Id).Single();

            dataItem.Id = item.Id;
            dataItem.DisableSavingToFile = item.DisableSavingToFile;
            dataItem.DisableSavingToWebService = item.DisableSavingToWebService;
            dataItem.DisableSystemMessage = item.DisableSystemMessage;
            dataItem.DisableMessageForUser = item.DisableMessageForUser;
            dataItem.DisableInformation = item.DisableInformation;
            dataItem.DisableWarning = item.DisableWarning;
            dataItem.DisableError = item.DisableError;
            dataItem.DisableFatalError = item.DisableFatalError;
            dataItem.DisableDebugMessage = item.DisableDebugMessage;

            CurrDBContext.Get().SaveChanges();
        } 
    }
}
