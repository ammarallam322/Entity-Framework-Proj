//?????????????????????????using basma3.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basma2.models
{
    internal class basma2Context:DbContext
    {
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Records> Records { get; set; }
        public virtual DbSet<Department> Department { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=DESKTOP-PQBVQ61\\SQLEXPRESS;Database=basma3;Trusted_Connection=True; TrustServerCertificate=True;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //self relation
            modelBuilder.Entity<Employee>()
                .HasOne(e => e.supervisor)
                .WithMany()
                .HasForeignKey(e => e.superId)
                .OnDelete(DeleteBehavior.NoAction);  //to prevent on delete cascade

            //adding index on email column

            modelBuilder.Entity<Employee>()
                .HasIndex(e => e.Email);

            //adding index on day column

            modelBuilder.Entity<Records>()
                .HasIndex(e => e.day);


            // adding departments 

            modelBuilder.Entity<Department>().HasData(
                

                new Department() { Id = 1, Name = "IT" , manager ="eng mohamed"},
                new Department() { Id = 2, Name = "HR", manager = "eng ali" },
                new Department() { Id = 3, Name = "Finance", manager = "eng mostafa" },
                new Department() { Id = 4, Name = "Marketing", manager = "eng ahmed" }
            );



            #region Padding rows in records


            modelBuilder.Entity<Records>().HasData(new Records(new DateTime(2025, 02, 02) ,5) { recordId = 4});
            modelBuilder.Entity<Records>().HasData(new Records(new DateTime (2025,02,02),6) { recordId = 5});
            modelBuilder.Entity<Records>().HasData(new Records(new DateTime (2025,02,02),7) { recordId = 6});
            modelBuilder.Entity<Records>().HasData(new Records(new DateTime (2025,02,02),8) { recordId = 7});
            modelBuilder.Entity<Records>().HasData(new Records(new DateTime (2025,02,02),9) { recordId = 8});
            modelBuilder.Entity<Records>().HasData(new Records(new DateTime (2025,02,02),10) { recordId = 9});
            modelBuilder.Entity<Records>().HasData(new Records(new DateTime (2025,02,02),11) { recordId = 10});
            modelBuilder.Entity<Records>().HasData(new Records(new DateTime (2025,02,02).AddDays(2), 9) { recordId = 11});
            modelBuilder.Entity<Records>().HasData(new Records(new DateTime (2025,02,02).AddDays(2), 8) { recordId = 12});
            modelBuilder.Entity<Records>().HasData(new Records(new DateTime (2025,02,02).AddDays(2), 7) { recordId = 13});
            modelBuilder.Entity<Records>().HasData(new Records(new DateTime (2025,02,02).AddDays(2), 6) { recordId = 14});
            modelBuilder.Entity<Records>().HasData(new Records(new DateTime (2025,02,02).AddDays(2),5) { recordId = 15});
            modelBuilder.Entity<Records>().HasData(new Records(new DateTime (2025,02,02).AddDays(2),10) { recordId = 16});
            modelBuilder.Entity<Records>().HasData(new Records(new DateTime (2025,02,02).AddDays(2),511) { recordId = 17});

            #endregion






        }











    }
    }
