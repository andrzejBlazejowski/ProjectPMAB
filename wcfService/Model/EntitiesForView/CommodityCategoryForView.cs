using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using wcfService.Model.Entities;

namespace wcfService.Model.EntitiesForView
{
    [DataContract]
    public class CommodityCategoryForView : BaseModelForView
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }

        public CommodityCategoryForView() { }
        public CommodityCategoryForView(CommodityCategory cCat)
        {
            Id = cCat.Id;
            CreatedBy = cCat.CreatedBy;
            ModifiedBy = cCat.ModifiedBy;
            CreatedDate = cCat.CreateDate;
            ModifiedDate = (DateTime)cCat.ModificationDate;
            IsActive = cCat.IsActive;
            Name = cCat.Name;
            Description = cCat.Description;
        }
    }
}