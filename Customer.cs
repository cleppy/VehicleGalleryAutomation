//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace finalotomasyon
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        public string CTC { get; set; }
        public string CName { get; set; }
        public string CSurname { get; set; }
        public Nullable<int> COrderID { get; set; }
    
        public virtual Order Order { get; set; }
    }
}
