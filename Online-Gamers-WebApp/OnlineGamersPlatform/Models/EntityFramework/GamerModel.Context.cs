﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineGamersPlatform.Models.EntityFramework
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OnlineGamersPlatformEntities : DbContext
    {
        public OnlineGamersPlatformEntities()
            : base("name=OnlineGamersPlatformEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Gamer> Gamer { get; set; }
        public virtual DbSet<Game> Game { get; set; }
        public virtual DbSet<Follow> Follow { get; set; }
    }
}