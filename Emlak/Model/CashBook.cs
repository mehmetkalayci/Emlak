//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Emlak.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CashBook
    {
        public int TransactionId { get; set; }
        public System.DateTime TransactionDate { get; set; }
        public string TransactionType { get; set; }
        public decimal Amount { get; set; }
        public string Definition { get; set; }
        public Nullable<int> DebtId { get; set; }
    
        public virtual Debt Debt { get; set; }
    }
}
