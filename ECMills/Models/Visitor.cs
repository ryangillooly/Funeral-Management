//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ECMills.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Visitor
    {
        public short OrderID { get; set; }
        public byte LineItem { get; set; }
        public string Title { get; set; }
        public string Forenames { get; set; }
        public string Surname { get; set; }
        public string Relationship { get; set; }
        public System.DateTime Time { get; set; }
    
        public virtual Order Order { get; set; }
    }
}
