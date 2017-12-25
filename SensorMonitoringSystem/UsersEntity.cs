//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SensorMonitoringSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class UsersEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UsersEntity()
        {
            this.UsersDetails = new HashSet<UsersDetailsEntity>();
        }
    
        public int UserID { get; set; }
        public int CompanyID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsActivated { get; set; }
        public long RegistrationCode { get; set; }
    
        public virtual CompaniesEntity Companies { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsersDetailsEntity> UsersDetails { get; set; }
    }
}