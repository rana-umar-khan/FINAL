//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FINAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Teacher
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Teacher()
        {
            this.Courses = new HashSet<Course>();
        }
    
        public int TeaId { get; set; }
        public string TeaUsername { get; set; }
        public string TeaPassword { get; set; }
        public string TeaFirstName { get; set; }
        public string TeaLastName { get; set; }
        public string TeaEmail { get; set; }
        public string TeaContactNo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Course> Courses { get; set; }
    }
}