//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cmplt_pro
    {
        public int Proj_Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
    
        public virtual Cnfrm_pro Cnfrm_pro { get; set; }
    }
}
