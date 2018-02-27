namespace Common.BusinessLogic.AppIdAndAuth.ApplicationId
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Auxiliary.StorageTools;
    using Auxiliary.PatternsAndClasses;

    public abstract class BaseTools <CTX,DTO> : StorageInMemAndPerApp< Dictionary<long, DTO>> // для StorageData
        where CTX : class, new()
        where DTO : class, new()
    {
        protected LazyInitWithoutParams<CTX> CurrDBContext = new LazyInitWithoutParams<CTX>();

        public DTO GetOneById(long id)
        {
            Dictionary<long, DTO> projsData = StorageData;
            DTO result = projsData[(long)id];
            return result;
        }

        public List<DTO> GetAll()
        {
            Dictionary<long, DTO> projsData = StorageData;
            var list = projsData.Values.ToList();
            return list;
        }

    }
}
