using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using wcfService.Model.Entities;

namespace wcfService.Model.EntitiesForView
{
    [DataContract]
    public class StorageStatusForView:BaseModelForView
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Key { get; set; }
        public StorageStatusForView() { }
        public StorageStatusForView(storageStatus storageStatus)
        {
            Id = storageStatus.Id;
            CreatedBy = storageStatus.CretedBy;
            ModifiedBy = storageStatus.ModifiedBy;
            CreatedDate = storageStatus.CreatDate;
            ModifiedDate = (DateTime)storageStatus.ModificationDate;
            IsActive = storageStatus.IsActive;
            Name = storageStatus.Name;
            Description = storageStatus.Description;
            Key = storageStatus.Key;
        }
    }
}