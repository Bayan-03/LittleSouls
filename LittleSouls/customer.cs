//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LittleSouls
{
    using System;
    using System.Collections.Generic;
    
    public partial class customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public customer()
        {
            this.pets = new HashSet<pet>();
        }
    
        public int customerId { get; set; }
        public string firstName { get; set; }
        public string lastname { get; set; }
        public string sex { get; set; }
        public string informationAllergy { get; set; }
        public int phoneNumber { get; set; }
        public string email { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public int zipCode { get; set; }
        public string buildingNumber { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pet> pets { get; set; }
    }
}
