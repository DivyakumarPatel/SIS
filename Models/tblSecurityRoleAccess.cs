
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
    
public partial class tblSecurityRoleAccess
{

    public int ID { get; set; }

    public int Role_ID { get; set; }

    public int Privilege_ID { get; set; }

    public byte AccessPermission { get; set; }

    public int Model_ID { get; set; }

    public int Securable_ID { get; set; }

    public int Object_ID { get; set; }

    public string Description { get; set; }

    public System.DateTime EnterDTM { get; set; }

    public int EnterUserID { get; set; }

    public System.DateTime LastChgDTM { get; set; }

    public int LastChgUserID { get; set; }

    public System.Guid MUID { get; set; }



    public virtual tblModel tblModel { get; set; }

    public virtual tblSecurityPrivilege tblSecurityPrivilege { get; set; }

    public virtual tblSecurityRole tblSecurityRole { get; set; }

}

}