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
    
    public partial class sp_getDebtDetails_Result
    {
        public int DebtId { get; set; }
        public string Definition { get; set; }
        public decimal Amount { get; set; }
        public System.DateTime DueDate { get; set; }
        public string PaymentDate { get; set; }
        public string PaymentDateToLandlord { get; set; }
        public string PaymentType { get; set; }
        public string Explanation { get; set; }
        public string LandlordFullName { get; set; }
        public string LandlordPhone { get; set; }
        public string RealtyDefinition { get; set; }
        public string Kiracilar { get; set; }
        public bool IsPaidByTenant { get; set; }
        public bool IsPaidToLandlord { get; set; }
        public bool IsCommission { get; set; }
    }
}
