using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Labb1.Net21EntityFrameworkKimWiklund.Models
{
    class LabbDBContext : DbContext
    {

        public DbSet<Employees> Employees { get; set; }
    
        public DbSet<Leaves> Leaves { get; set; }
        


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = DESKTOP-FARI6OS\\SQLEXPRESS;Initial Catalog=Labb1DB;Integrated Security = True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Employees>()
                .HasData(new Employees
                {
                    EmployeeId = 1,
                    FirstName = "Amanda",
                    LastName = "Westman",
                    Gender = "F",
                    Age = 22
                });
            modelBuilder.Entity<Employees>()
                .HasData(new Employees
                {
                    EmployeeId = 2,
                    FirstName = "Sebastian",
                    LastName = "Skalare",
                    Gender = "M",
                    Age = 28
                });
            modelBuilder.Entity<Employees>()
                .HasData(new Employees
                {
                    EmployeeId = 3,
                    FirstName = "Kim",
                    LastName = "Wiklund",
                    Gender = "M",
                    Age = 30
                });
            modelBuilder.Entity<Employees>()
                .HasData(new Employees
                {
                    EmployeeId = 4,
                    FirstName = "Pelle",
                    LastName = "Westman",
                    Gender = "M",
                    Age = 49
                });
            modelBuilder.Entity<Employees>()
                .HasData(new Employees
                {
                    EmployeeId = 5,
                    FirstName = "Sara",
                    LastName = "Bodin",
                    Gender = "F",
                    Age = 27
                });
            modelBuilder.Entity<Employees>()
                .HasData(new Employees
                {
                    EmployeeId = 6,
                    FirstName = "Helene",
                    LastName = "Andersson",
                    Gender = "F",
                    Age = 42
                });
            modelBuilder.Entity<Employees>()
                .HasData(new Employees
                {
                    EmployeeId = 7,
                    FirstName = "Linnea",
                    LastName = "Häggkvist",
                    Gender = "F",
                    Age = 32
                });
            modelBuilder.Entity<Leaves>()
                .HasData(new Leaves
                {
                    LeaveId = 1,
                    Reason = "Sick",
                    StartDate = DateTime.Parse("2022-04-05"),
                    EndDate = DateTime.Parse("2022-04-07"),
                    FEmployeeId = 1
                });
            modelBuilder.Entity<Leaves>()
                .HasData(new Leaves
                {
                    LeaveId = 2,
                    Reason = "Sick",
                    StartDate = DateTime.Parse("2022-04-05"),
                    EndDate = DateTime.Parse("2022-04-06"),
                    FEmployeeId = 2
                });
            modelBuilder.Entity<Leaves>()
                .HasData(new Leaves
                {
                    LeaveId = 3,
                    Reason = "Vacation",
                    StartDate = DateTime.Parse("2022-04-07"),
                    EndDate = DateTime.Parse("2022-04-10"),
                    FEmployeeId = 1
                });
            modelBuilder.Entity<Leaves>()
                .HasData(new Leaves
                {
                    LeaveId = 4,
                    Reason = "Vacation",
                    StartDate = DateTime.Parse("2022-04-07"),
                    EndDate = DateTime.Parse("2022-04-10"),
                    FEmployeeId = 3
                });
            modelBuilder.Entity<Leaves>()
                .HasData(new Leaves
                {
                    LeaveId = 5,
                    Reason = "Vab",
                    StartDate = DateTime.Parse("2022-04-05"),
                    EndDate = DateTime.Parse("2022-04-10"),
                    FEmployeeId = 4
                });
            modelBuilder.Entity<Leaves>()
                .HasData(new Leaves
                {
                    LeaveId = 6,
                    Reason = "Unpaid",
                    StartDate = DateTime.Parse("2022-04-11"),
                    EndDate = DateTime.Parse("2022-04-12"),
                    FEmployeeId = 5
                });
            modelBuilder.Entity<Leaves>()
                .HasData(new Leaves
                {
                    LeaveId = 7,
                    Reason = "Vacation",
                    StartDate = DateTime.Parse("2022-04-25"),
                    EndDate = DateTime.Parse("2022-04-30"),
                    FEmployeeId = 6
                });
            modelBuilder.Entity<Leaves>()
                .HasData(new Leaves
                {
                    LeaveId = 8,
                    Reason = "Vab",
                    StartDate = DateTime.Parse("2022-05-01"),
                    EndDate = DateTime.Parse("2022-05-12"),
                    FEmployeeId = 7
                });
            modelBuilder.Entity<Leaves>()
                .HasData(new Leaves
                {
                    LeaveId = 9,
                    Reason = "sick",
                    StartDate = DateTime.Parse("2022-04-26"),
                    EndDate = DateTime.Parse("2022-04-29"),
                    FEmployeeId = 7
                });

        }
    }
}

