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
    
    public partial class FILETYPEINFO
    {
        public FILETYPEINFO()
        {
            this.FILEDETAILs = new HashSet<FILEDETAIL>();
        }
    
        public decimal ID_C { get; set; }
        public string CODE { get; set; }
        public string BUSINESSCODETYPE { get; set; }
        public string FILENAMECN { get; set; }
        public string FILENAMEEN { get; set; }
        public string COMMENTS { get; set; }
        public Nullable<System.DateTime> CTIME { get; set; }
        public Nullable<System.DateTime> MTIME { get; set; }
        public Nullable<decimal> TYPEORDER { get; set; }
        public decimal ISVALID { get; set; }
    
        public virtual BUSINESSTYPEINFO BUSINESSTYPEINFO { get; set; }
        public virtual ICollection<FILEDETAIL> FILEDETAILs { get; set; }
    }
}
