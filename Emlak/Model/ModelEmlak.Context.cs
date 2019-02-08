﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Emlak.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class EmlakEntities : DbContext
    {
        public EmlakEntities()
            : base("name=EmlakEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CashBook> CashBook { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Contract> Contract { get; set; }
        public virtual DbSet<ContractParties> ContractParties { get; set; }
        public virtual DbSet<Debt> Debt { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Realty> Realty { get; set; }
        public virtual DbSet<RealtyType> RealtyType { get; set; }
        public virtual DbSet<Town> Town { get; set; }
        public virtual DbSet<User> User { get; set; }
    
        public virtual ObjectResult<sp_getContracts_Result> sp_getContracts()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_getContracts_Result>("sp_getContracts");
        }
    
        public virtual ObjectResult<sp_getDebtDetails_Result> sp_getDebtDetails(Nullable<int> debtId)
        {
            var debtIdParameter = debtId.HasValue ?
                new ObjectParameter("DebtId", debtId) :
                new ObjectParameter("DebtId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_getDebtDetails_Result>("sp_getDebtDetails", debtIdParameter);
        }
    
        public virtual ObjectResult<sp_getExpiredContracts_Result> sp_getExpiredContracts()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_getExpiredContracts_Result>("sp_getExpiredContracts");
        }
    
        public virtual ObjectResult<sp_getMonthlyRentalReport_Result> sp_getMonthlyRentalReport()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_getMonthlyRentalReport_Result>("sp_getMonthlyRentalReport");
        }
    
        public virtual ObjectResult<sp_getMonthlyReport_Result> sp_getMonthlyReport(Nullable<int> month, Nullable<int> year)
        {
            var monthParameter = month.HasValue ?
                new ObjectParameter("Month", month) :
                new ObjectParameter("Month", typeof(int));
    
            var yearParameter = year.HasValue ?
                new ObjectParameter("Year", year) :
                new ObjectParameter("Year", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_getMonthlyReport_Result>("sp_getMonthlyReport", monthParameter, yearParameter);
        }
    
        public virtual ObjectResult<sp_getYearlyReport_Result> sp_getYearlyReport(Nullable<int> year)
        {
            var yearParameter = year.HasValue ?
                new ObjectParameter("Year", year) :
                new ObjectParameter("Year", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_getYearlyReport_Result>("sp_getYearlyReport", yearParameter);
        }
    
        public virtual ObjectResult<sp_getDebtsToLandlord_Result> sp_getDebtsToLandlord()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_getDebtsToLandlord_Result>("sp_getDebtsToLandlord");
        }
    }
}
