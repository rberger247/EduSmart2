//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EduSmart2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Payment
    {
        public int PaymentId { get; set; }
        public int PaymentTypeId { get; set; }
        public int PersonId { get; set; }
        public string PaymentAmount { get; set; }
        public System.DateTime DateOfPayment { get; set; }
    }
}