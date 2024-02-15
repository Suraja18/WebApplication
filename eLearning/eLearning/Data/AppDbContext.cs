using eLearning.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eLearning.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book_Writer>().HasKey(bw => new
            {
                bw.books_Id,
                bw.writer_Id
            });

            modelBuilder.Entity<Book_Writer>().HasOne(b => b.Books).WithMany(bw => bw.Book_Writer).HasForeignKey(b => b.books_Id);
            modelBuilder.Entity<Book_Writer>().HasOne(b => b.Writer).WithMany(bw => bw.Book_Writer).HasForeignKey(b => b.writer_Id);


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Writer> Writers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Books> Books { get; set; }
        public DbSet<Book_Writer> Book_Writers { get; set; }
    }
}
