﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ResearchReportEntities : DbContext
    {
        public ResearchReportEntities()
            : base("name=ResearchReportEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<BANK_FIN_PRD_PROSP_DATA> BANK_FIN_PRD_PROSP_DATA { get; set; }
        public DbSet<BUSINESSTYPEINFO> BUSINESSTYPEINFOes { get; set; }
        public DbSet<DISC_ACCE_CFP_DATA> DISC_ACCE_CFP_DATA { get; set; }
        public DbSet<FILEDETAIL> FILEDETAILs { get; set; }
        public DbSet<FILETYPEINFO> FILETYPEINFOes { get; set; }
        public DbSet<FILEVISITLOG> FILEVISITLOGs { get; set; }
        public DbSet<FIN_PRD_RPT_DATA> FIN_PRD_RPT_DATA { get; set; }
        public DbSet<INSTITUTIONINFO> INSTITUTIONINFOes { get; set; }
        public DbSet<OPERATORINFO> OPERATORINFOes { get; set; }
        public DbSet<RATE_REP_DATA> RATE_REP_DATA { get; set; }
        public DbSet<RES_INFO_DATA> RES_INFO_DATA { get; set; }
        public DbSet<ROLEPERMISSION> ROLEPERMISSIONS { get; set; }
        public DbSet<ALLFILESINFO> ALLFILESINFOes { get; set; }
        public DbSet<GETNEWFILE> GETNEWFILEs { get; set; }
        public DbSet<GETNEWINSTITUTION> GETNEWINSTITUTIONs { get; set; }
        public DbSet<GETRESEACHREPORTBYTYPE> GETRESEACHREPORTBYTYPEs { get; set; }
    }
}
