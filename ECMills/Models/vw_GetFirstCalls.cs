
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
    
public partial class vw_GetFirstCalls
{

    public short FirstCallID { get; set; }

    public string ClientTitle { get; set; }

    public string ClientForenames { get; set; }

    public string ClientSurname { get; set; }

    public string DeceasedTitle { get; set; }

    public string DeceasedForenames { get; set; }

    public string DeceasedSurname { get; set; }

    public string OrderType { get; set; }

    public string OrderSubType { get; set; }

    public bool DeathRegistered { get; set; }

    public string DeceasedPickedUpFrom { get; set; }

    public string Relationship { get; set; }

    public string Notes { get; set; }

    public Nullable<System.DateTime> AppointmentDate { get; set; }

}

}
