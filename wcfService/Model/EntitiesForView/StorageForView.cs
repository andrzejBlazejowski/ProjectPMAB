using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using wcfService.Model.Entities;

namespace wcfService.Model.EntitiesForView
{
    public class StorageForView:BaseModelForView
    {
        public string Status { get; set; }
        public string Size { get; set; }
        public string Dimensions { get; set; }
        public StorageForView() { }
        public StorageForView(storage storage)
        {
            Id = storage.Id;
            CreatedBy = storage.CretedBy;
            ModifiedBy = storage.ModifiedBy;
            CreatedDate = storage.CreatDate;
            ModifiedDate = (DateTime)storage.ModificationDate;
            IsActive = storage.IsActive;
            Status = storage.storageStatus.Name;
            Size = storage.storageSizes.Name;
            Dimensions = storage.storageSizes.x + "x" + storage.storageSizes.y + "x" + storage.storageSizes.z;
        }
    }
}