//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Practice4.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Store
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Store()
        {
            this.Agencies = new HashSet<Agency>();
            this.Agencies1 = new HashSet<Agency>();
            this.Purchases = new HashSet<Purchase>();
            this.SalesReports = new HashSet<SalesReport>();
        }
    
        public int Id { get; set; }
        public string MedicineName { get; set; }
        public System.DateTime ExpiryData { get; set; }
        public System.DateTime ManufacturedDate { get; set; }
        public double price { get; set; }
        public string PharmEmail { get; set; }
        public string PharmNumber { get; set; }
        public string PharmWebsite { get; set; }
        public string MedicinePhtot { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Agency> Agencies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Agency> Agencies1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Purchase> Purchases { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesReport> SalesReports { get; set; }
    }
}
