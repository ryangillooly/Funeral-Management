
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
    
public partial class action
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public action()
    {

        this.tasks = new HashSet<task>();

    }


    public System.Guid id { get; set; }

    public Nullable<System.Guid> syncgroupid { get; set; }

    public int type { get; set; }

    public int state { get; set; }

    public Nullable<System.DateTime> creationtime { get; set; }

    public Nullable<System.DateTime> lastupdatetime { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<task> tasks { get; set; }

}

}
