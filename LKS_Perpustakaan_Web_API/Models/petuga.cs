//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LKS_Perpustakaan_Web_API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class petuga
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public petuga()
        {
            this.peminjamen = new HashSet<peminjaman>();
        }
    
        public string id_petugas { get; set; }
        public string nama_petugas { get; set; }
        public string nik { get; set; }
        public string alamat { get; set; }
        public int id_user { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<peminjaman> peminjamen { get; set; }
        public virtual user user { get; set; }
    }
}
