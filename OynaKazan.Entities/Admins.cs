//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OynaKazan.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Admins
    {
        public int Id { get; set; }
        public string Kadi { get; set; }
        public string Sifre { get; set; }
        public Nullable<System.DateTime> LastLoginDate { get; set; }
        public string LastLoginIp { get; set; }
    }
}
