using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using wcfService.Hlpers;
using wcfService.Model.Entities;

namespace wcfService.Model.EntitiesForView
{
    public class StorageSizeForView:BaseModelForView
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }
        public string Dimensions { get; set; }
        public string VerboseDimensions { get; set; }
        public StorageSizeForView() { }
        public StorageSizeForView(storageSizes storage)
        {
            Id = storage.Id;
            CreatedBy = storage.CretedBy;
            ModifiedBy = storage.ModifiedBy;
            CreatedDate = storage.CreatDate;
            ModifiedDate = (DateTime)storage.ModificationDate;
            IsActive = storage.IsActive;
            VerboseDimensions = StorageSizeHelper.getVerboseStorageDimensions(storage);
            Dimensions = StorageSizeHelper.getStorageDimensions(storage);
            Height = StorageSizeHelper.getHeight(storage);
            Width = StorageSizeHelper.getWidth(storage);
            Depth = StorageSizeHelper.getDepth(storage);
        }
    }
}