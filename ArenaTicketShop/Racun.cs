//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ArenaTicketShop
{
    using System;
    using System.Collections.Generic;
    
    public partial class Racun
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Racun()
        {
            this.Sjedalo_rez = new HashSet<Sjedalo_rez>();
        }
    
        public int racun_id { get; set; }
        public System.DateTime vrijeme_racuna { get; set; }
        public int blagajna_blagajna_id { get; set; }
    
        public virtual Blagajna Blagajna { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sjedalo_rez> Sjedalo_rez { get; set; }
    }
}