using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using wcfService.Model.Entities;

namespace wcfService.Model.EntitiesForView
{
    public class CommodityCategoryForView : BaseModelForView
    {
        public string Name { get; set; }
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