
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace S1G6_SISAPP.Models
{

using System;
    using System.Collections.Generic;
    
public partial class tblBRItemProperty
{

    public int ID { get; set; }

    public int BRItem_ID { get; set; }

    public int PropertyType_ID { get; set; }

    public int PropertyName_ID { get; set; }

    public string Value { get; set; }

    public int Sequence { get; set; }

    public bool IsLeftHandSide { get; set; }

    public Nullable<int> Parent_ID { get; set; }

    public Nullable<bool> SuppressText { get; set; }

    public System.Guid MUID { get; set; }



    public virtual tblBRItem tblBRItem { get; set; }

}

}
