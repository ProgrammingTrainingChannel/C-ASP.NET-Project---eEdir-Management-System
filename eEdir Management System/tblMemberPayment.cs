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
    
    public partial class tblMemberPayment
    {
        public int ID { get; set; }
        public int MemberID { get; set; }
        public int PaymentPeriodID { get; set; }
        public int PaymentYear { get; set; }
        public System.DateTime PaymentDate { get; set; }
        public decimal PaymentAmount { get; set; }
        public string PaymentTransactionCode { get; set; }
    
        public virtual tblMember tblMember { get; set; }
        public virtual tblPaymentPeriod tblPaymentPeriod { get; set; }
    }
}
