﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestCompany
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbSqlServerCompanyEntities1 : DbContext
    {
        public DbSqlServerCompanyEntities1()
            : base("name=DbSqlServerCompanyEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Access> Accesses { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}