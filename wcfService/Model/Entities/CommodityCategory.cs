//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace wcfService.Model.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class CommodityCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CommodityCategory()
        {
            this.Comodity = new HashSet<Comodity>();
        }
    
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<System.DateTime> ModificationDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Comodity> Comodity { get; set; }
    }
}
