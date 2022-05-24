﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Employees.Models
{
    public partial class SignalREmployeesContext : DbContext
    {
        public SignalREmployeesContext()
        {
        }

        public SignalREmployeesContext(DbContextOptions<SignalREmployeesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employees> Employees { get; set; }

       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employees>(entity =>
            {
                entity.Property(e => e.Address).IsFixedLength();

                entity.Property(e => e.Age).IsFixedLength();

                entity.Property(e => e.Name).IsFixedLength();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}