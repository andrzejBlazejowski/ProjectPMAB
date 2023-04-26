using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using wcfService.Hlpers;
using wcfService.Model.Entities;

namespace wcfService.Model.EntitiesForView
{
    [DataContract]
    public class BrandForView:BaseModelForView
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description{ get; set; }
        [DataMember]
        public string Address { get; set; }

        public BrandForView() { }
        public BrandForView(Brand brand)
        {
            Id = brand.Id;
            CreatedBy = brand.CretedBy;
            ModifiedBy = brand.ModifiedBy;
            CreatedDate = brand.CreatDate;
            ModifiedDate = (DateTime)brand.ModificationDate;
            IsActive = brand.IsActive;
            Name = brand.Name;
            Description = brand.Description;
            Address = AddressHelper.getShortAddres(brand.Address);
        }
    }
}