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
    
    public partial class task
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public task()
        {
            this.task1 = new HashSet<task>();
            this.tasks = new HashSet<task>();
        }
    
        public System.Guid id { get; set; }
        public System.Guid actionid { get; set; }
        public long taskNumber { get; set; }
        public Nullable<System.DateTime> lastheartbeat { get; set; }
        public Nullable<int> state { get; set; }
        public Nullable<int> type { get; set; }
        public Nullable<System.Guid> agentid { get; set; }
        public Nullable<System.Guid> owning_instanceid { get; set; }
        public Nullable<System.DateTime> creationtime { get; set; }
        public Nullable<System.DateTime> pickuptime { get; set; }
        public Nullable<System.DateTime> completedtime { get; set; }
        public byte[] request { get; set; }
        public byte[] response { get; set; }
        public Nullable<int> priority { get; set; }
        public int retry_count { get; set; }
        public int dependency_count { get; set; }
        public long version { get; set; }
        public Nullable<System.DateTime> lastresettime { get; set; }
    
        public virtual action action { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<task> task1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<task> tasks { get; set; }
    }
}
