//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eEdir_Management_System
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblWoreda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblWoreda()
        {
            this.tblMembers = new HashSet<tblMember>();
            this.tblMemberFamilies = new HashSet<tblMemberFamily>();
        }
    
        public int ID { get; set; }
        public int SubcityID { get; set; }
        public string Title { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMember> tblMembers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblMemberFamily> tblMemberFamilies { get; set; }
        public virtual tblSubcity tblSubcity { get; set; }
    }
}
