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
    
    public partial class FILEDETAIL
    {
        public decimal FILEID { get; set; }
        public string FILETYPECODE { get; set; }
        public string FILENAMECN { get; set; }
        public string FILENAMEEN { get; set; }
        public Nullable<System.DateTime> UPLOADDATE { get; set; }
        public string AUTHOR { get; set; }
        public Nullable<System.DateTime> REPORTDATE { get; set; }
        public string COMMENTS { get; set; }
        public string OPERATORS { get; set; }
        public decimal ISVALID { get; set; }
        public string EXTENSION { get; set; }
        public string INSTITUTIONINFOCODE { get; set; }
        public string FILESIZE { get; set; }
        public Nullable<decimal> FILEORDER { get; set; }
        public Nullable<System.DateTime> CTIME { get; set; }
        public Nullable<System.DateTime> MTIME { get; set; }
        public string BUSINESSTYPE { get; set; }
        public string PHYSICAL_PATH { get; set; }
    
        public virtual BUSINESSTYPEINFO BUSINESSTYPEINFO { get; set; }
        public virtual FILETYPEINFO FILETYPEINFO { get; set; }
        public virtual INSTITUTIONINFO INSTITUTIONINFO { get; set; }
    }
}