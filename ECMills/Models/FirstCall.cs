
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
    
public partial class FirstCall
{

    public short ID { get; set; }

    public short ClientID { get; set; }

    public short DeceasedID { get; set; }

    public byte OrderTypeID { get; set; }

    public byte OrderSubTypeID { get; set; }

    public bool DeathRegistered { get; set; }

    public string DeceasedPickedUpFrom { get; set; }

    public string Relationship { get; set; }

    public Nullable<System.DateTime> AppointmentDate { get; set; }

    public string Notes { get; set; }

    public System.DateTime CreationTime { get; set; }

    public byte CreatedBy { get; set; }

    public Nullable<System.DateTime> LastModifiedTime { get; set; }

    public Nullable<byte> LastMofiedBy { get; set; }



    public virtual Client Client { get; set; }

    public virtual Deceased Deceased { get; set; }

    public virtual User User { get; set; }

    public virtual User User1 { get; set; }

    public virtual OrderType OrderType { get; set; }

    public virtual OrderSubType OrderSubType { get; set; }

}

}