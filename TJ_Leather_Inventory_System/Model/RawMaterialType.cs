
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace TJ_Leather_Inventory_System.Model
{

using System;
    using System.Collections.Generic;
    
public partial class RawMaterialType
{

    public RawMaterialType()
    {

        this.RawMaterialDetails = new HashSet<RawMaterialDetail>();

    }


    public int RawMaterialTypesID { get; set; }

    public string TypeName { get; set; }



    public virtual ICollection<RawMaterialDetail> RawMaterialDetails { get; set; }

}

}
