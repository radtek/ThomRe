//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VAV.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class HOMEITEM
    {
        public decimal ID { get; set; }
        public string NAMECN { get; set; }
        public string NAMEEN { get; set; }
        public Nullable<decimal> MODULEID { get; set; }
        public string TYPE { get; set; }
        public string TYPEVALUE { get; set; }
        public Nullable<decimal> ISVALID { get; set; }
        public string TYPEPARAM { get; set; }
        public Nullable<decimal> DISPLAYORDER { get; set; }
        public Nullable<System.DateTime> MTIME { get; set; }
    
        public virtual HOMEMODULE HOMEMODULE { get; set; }
    }
}
