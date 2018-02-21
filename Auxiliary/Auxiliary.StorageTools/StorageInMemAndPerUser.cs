namespace Auxiliary.StorageTools
{
    using System;

    public class StorageInMemAndPerUser<DT>
        where DT : class, new()
    {
        protected virtual String _localStorageName { get; }
        protected DT _localInMemoryStorage = null;

        public DT Data
        {
            set
            {
                _localInMemoryStorage = value;
                StoragePerUser.Put(_localStorageName, value);
            }
            get
            {
                if (_localInMemoryStorage == null)
                {
                    _localInMemoryStorage = (DT)StoragePerUser.Get(_localStorageName);
                }

                return _localInMemoryStorage;
            }
        }
    }


}
