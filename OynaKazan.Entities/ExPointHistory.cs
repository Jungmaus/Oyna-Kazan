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
    
    public partial class ExPointHistory
    {
        public int Id { get; set; }
        public int User_Id { get; set; }
        public int ExchangePoint_Id { get; set; }
        public System.DateTime Time { get; set; }
    
        public virtual ExchangePoints ExchangePoints { get; set; }
        public virtual Users Users { get; set; }
    }
}
