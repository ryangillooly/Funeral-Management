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
    
    public partial class OrderItemSubType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderItemSubType()
        {
            this.OrderItems = new HashSet<OrderItem>();
        }
    
        public byte OrderItemTypeID { get; set; }
        public byte ID { get; set; }
        public string Subtype { get; set; }
    
        public virtual OrderItemType OrderItemType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}