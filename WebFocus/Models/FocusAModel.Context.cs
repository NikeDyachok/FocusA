﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebFocus.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FPWorkEntities : DbContext
    {
        public FPWorkEntities()
            : base("name=FPWorkEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tbl_ART> tbl_ART { get; set; }
        public virtual DbSet<tbl_Cashiers> tbl_Cashiers { get; set; }
        public virtual DbSet<tbl_CashIn> tbl_CashIn { get; set; }
        public virtual DbSet<tbl_CashIO> tbl_CashIO { get; set; }
        public virtual DbSet<tbl_ComInit> tbl_ComInit { get; set; }
        public virtual DbSet<tbl_ComInitDefault> tbl_ComInitDefault { get; set; }
        public virtual DbSet<tbl_Connections> tbl_Connections { get; set; }
        public virtual DbSet<tbl_exchangeItemsFrom> tbl_exchangeItemsFrom { get; set; }
        public virtual DbSet<tbl_exchangeItemsRest> tbl_exchangeItemsRest { get; set; }
        public virtual DbSet<tbl_exchangeItemsTo> tbl_exchangeItemsTo { get; set; }
        public virtual DbSet<tbl_Info> tbl_Info { get; set; }
        public virtual DbSet<tbl_Log> tbl_Log { get; set; }
        public virtual DbSet<tbl_Operations> tbl_Operations { get; set; }
        public virtual DbSet<tbl_Payment> tbl_Payment { get; set; }
        public virtual DbSet<tbl_PermittedItems> tbl_PermittedItems { get; set; }
        public virtual DbSet<tbl_SALES> tbl_SALES { get; set; }
        public virtual DbSet<tbl_SyncDB> tbl_SyncDB { get; set; }
        public virtual DbSet<tbl_SyncDBStatus> tbl_SyncDBStatus { get; set; }
        public virtual DbSet<tbl_SyncFP> tbl_SyncFP { get; set; }
        public virtual DbSet<tbl_Tax> tbl_Tax { get; set; }
        public virtual DbSet<tbl_Firms> tbl_Firms { get; set; }
        public virtual DbSet<tbl_Objects> tbl_Objects { get; set; }
        public virtual DbSet<tbl_Names> tbl_Names { get; set; }
    }
}
