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
    
    public partial class PayRequests
    {
        public int Id { get; set; }
        public int User_Id { get; set; }
        public decimal Tutar { get; set; }
        public int BankAccount_Id { get; set; }
        public System.DateTime SendTime { get; set; }
        public int Statu { get; set; }
    
        public virtual BankAccounts BankAccounts { get; set; }
        public virtual Users Users { get; set; }
    }
}
