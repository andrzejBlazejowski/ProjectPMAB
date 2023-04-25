using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace wcfService.Model.EntitiesForView
{
    public class CommodityForView: BaseModelForView
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double GrossPrice { get; set; }
        public double NetPrice { get; set; }
        public string StorageName { get; set; }
        public string StorageSize { get; set; }
        public string BrandName { get; set; }
        public string CommodityCategory { get; set; }
    }
}