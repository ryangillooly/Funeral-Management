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
    
    public partial class syncgroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public syncgroup()
        {
            this.syncgroupmembers = new HashSet<syncgroupmember>();
        }
    
        public System.Guid id { get; set; }
        public string name { get; set; }
        public Nullable<System.Guid> subscriptionid { get; set; }
        public string schema_description { get; set; }
        public Nullable<int> state { get; set; }
        public Nullable<System.Guid> hub_memberid { get; set; }
        public int conflict_resolution_policy { get; set; }
        public int sync_interval { get; set; }
        public bool sync_enabled { get; set; }
        public Nullable<System.DateTime> lastupdatetime { get; set; }
        public string ocsschemadefinition { get; set; }
        public Nullable<bool> hubhasdata { get; set; }
        public bool ConflictLoggingEnabled { get; set; }
        public int ConflictTableRetentionInDays { get; set; }
    
        public virtual ScheduleTask ScheduleTask { get; set; }
        public virtual subscription subscription { get; set; }
        public virtual userdatabase userdatabase { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<syncgroupmember> syncgroupmembers { get; set; }
    }
}
