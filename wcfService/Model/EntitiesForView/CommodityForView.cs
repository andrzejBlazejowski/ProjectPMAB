using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using wcfService.Model.Entities;

namespace wcfService.Model.EntitiesForView
{
    [DataContract]
    public class CommodityForView : BaseModelForView
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
        public decimal GrossPrice { get; set; }
        public decimal NetPrice { get; set; }
        public string StorageName { get; set; }
        public string StorageSize { get; set; }
        public string BrandName { get; set; }
        public string CommodityCategory { get; set; }
        public CommodityForView() { }
        public CommodityForView(Comodity comm)
        {
            storageSizes storage = comm.storageSizes;
            Id = comm.Id;
            CreatedBy = comm.CretedBy;
            ModifiedBy = comm.ModifiedBy;
            CreatedDate = comm.CreatDate;
            ModifiedDate = (DateTime)comm.ModificationDate;
            IsActive = comm.IsActive;
            Name = comm.Name;
            Description = comm.Description;
            GrossPrice = (decimal)(comm.NetUnitPrice * comm.VatRate + comm.NetUnitPrice);
            NetPrice = (decimal)comm.NetUnitPrice;
            StorageName = storage.Name;
            StorageSize = storage.x + "x" + storage.y + "x" + storage.z;
            BrandName = comm.Brand.Name;
            CommodityCategory = comm.CommodityCategory.Name;
        }
    }
}