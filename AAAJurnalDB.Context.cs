﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AAA_PR4
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AAAJurnalDBEntities2 : DbContext
    {
        public AAAJurnalDBEntities2()
            : base("name=AAAJurnalDBEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Assessment> Assessment { get; set; }
        public virtual DbSet<Cours> Cours { get; set; }
        public virtual DbSet<Jurnal> Jurnal { get; set; }
        public virtual DbSet<People> People { get; set; }
        public virtual DbSet<Predmet> Predmet { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<StudentGroup> StudentGroup { get; set; }
    }
}
