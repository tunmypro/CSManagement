//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CSManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Register_SC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Register_SC()
        {
            this.Applieds = new HashSet<Applied>();
        }
    
        public int REG_IDCard { get; set; }
        public string REG_Name { get; set; }
        public string REG_Address { get; set; }
        public string REG_Tel { get; set; }
        public string REG_Email { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Applied> Applieds { get; set; }
    }
}