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
    
    public partial class Sjedalo_rez
    {
        public int sjedalo_rez_id { get; set; }
        public int dogadaj_dogadaj_id { get; set; }
        public int sjedalo_sjedalo_id { get; set; }
        public int racun_racun_id { get; set; }
    
        public virtual Dogadaj Dogadaj { get; set; }
        public virtual Sjedalo Sjedalo { get; set; }
        public virtual Racun Racun { get; set; }
    }
}