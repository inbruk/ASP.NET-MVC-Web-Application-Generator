namespace Common.WebServiceClient.ApplicationId
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Common.DataTransferObjects.AppIdAndAuth.ApplicationId;
    using DAL = Common.DataAccessLayer.AppIdAndAuth;

    public enum enLayer
    {
        DataLayer = 1,
        DataAccessLayer = 2,
        DataTransferObjects = 3,
        BusinessLayer = 4,
        WebServiceLayer = 5,
        WebServiceClient = 6,
        WebUserInterface_Model = 7,
        WebUserInterface_Controller = 8,
        WebUserInterface_View = 9
    };

    public static class LayerTools 
    {
        private static Layer ConvertEnum(enLayer en)
        {
            Layer result = new Layer((long)(en), en.ToString());
            return result;
        }

        private static Dictionary<long, Layer> Layers { get; }

        static LayerTools()
        {
            Layers = new Dictionary<long, Layer>();
            foreach (enLayer currEn in Enum.GetValues(typeof(enLayer)))
            {
                Layer currItem = ConvertEnum(currEn);
                Layers.Add(currItem.Id, currItem);
            }
        }

        public static Layer GetOneById(enLayer id)
        {
            Layer result = Layers[(long)id];
            return result;
        }

        public static List<Layer> GetAll()
        {
            var list = Layers.Values.ToList();
            return list;
        }
    }
}

