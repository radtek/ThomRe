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
    
    public partial class EJVASSET
    {
        public string ASSET_ID { get; set; }
        public string RIC { get; set; }
        public System.DateTime TRADE_DT { get; set; }
        public Nullable<System.DateTime> MODIFYDATE { get; set; }
        public Nullable<decimal> ORIG_ISS_PX { get; set; }
        public Nullable<decimal> YIELD { get; set; }
        public Nullable<System.DateTime> MATURITY_DT { get; set; }
        public string TRADETYPE { get; set; }
        public Nullable<decimal> TERM_TO_MATURITY { get; set; }
        public Nullable<decimal> ORIG_AMT_ISS { get; set; }
    }
}
