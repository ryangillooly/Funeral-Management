
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
    
public partial class DeceasedContactsContactType
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public DeceasedContactsContactType()
    {

        this.DeceasedContacts = new HashSet<DeceasedContact>();

    }


    public byte ID { get; set; }

    public string Type { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<DeceasedContact> DeceasedContacts { get; set; }

}

}
