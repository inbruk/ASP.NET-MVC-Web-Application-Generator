using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.DataTransferObjects.Logging
{
    using System;

    public class Configuration
    {
        public long Id { get; }
        public Boolean DisableSavingToFile { get; } = false;
        public Boolean DisableSavingToWebService { get; } = false;
        public Boolean DisableSystemMessage { get; } = false;
        public Boolean DisableMessageForUser { get; } = false;
        public Boolean DisableInformation { get; } = false;
        public Boolean DisableWarning { get; } = false;
        public Boolean DisableError { get; } = false;
        public Boolean DisableFatalError { get; } = false;
        public Boolean DisableDebugMessage { get; } = false;

        public Configuration
        (
            long id,
            Boolean disableSavingToFile,
            Boolean disableSavingToWebService,
            Boolean disableSystemMessage,
            Boolean disableMessageForUser,
            Boolean disableInformation,
            Boolean disableWarning,
            Boolean disableError,
            Boolean disableFatalError,
            Boolean disableDebugMessage
        )
        {
            Id = id;
            DisableSavingToFile = disableSavingToFile;
            DisableSavingToWebService = disableSavingToWebService;
            DisableSystemMessage = disableSystemMessage;
            DisableMessageForUser = disableMessageForUser;
            DisableInformation = disableInformation;
            DisableWarning = disableWarning;
            DisableError = disableError;
            DisableFatalError = disableFatalError;
            DisableDebugMessage = disableDebugMessage;
        }
    }
}
