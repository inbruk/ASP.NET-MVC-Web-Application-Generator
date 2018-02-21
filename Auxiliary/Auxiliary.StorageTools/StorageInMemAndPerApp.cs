namespace Auxiliary.StorageTools
{
    using System;

    public class StorageInMemAndPerApp<DT>
        where DT : class, new()
    {
        protected virtual String _localStorageName { get; }
        protected DT _localInMemoryStorage = null;

        public DT StorageData
        {
            set
            {
                _localInMemoryStorage = value;
                StoragePerApplication.Put(_localStorageName, value);
            }
            get
            {
                if (_localInMemoryStorage == null)
                {
                    _localInMemoryStorage = (DT) StoragePerApplication.Get(_localStorageName);
                }

                return _localInMemoryStorage;
            }
        }
    }
}
