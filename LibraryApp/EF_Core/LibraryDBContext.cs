using LibraryApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryApp.EF_Core
{
    public class LibraryDBContext:DbContext
    {
        public DbSet<Genre> Genres => Set<Genre>();
        public DbSet<Author> Authors => Set<Author>();
        public DbSet<Book> Books => Set<Book>();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            const string connString = "Server=localhost;Port=3306;Database=library_db;User=root;Password=root;";
            optionsBuilder.UseMySql(connString, ServerVersion.AutoDetect(connString));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Genre-Books
            modelBuilder.Entity<Genre>().HasMany(g => g.Books).WithOne(b => b.Genre).HasForeignKey(b => b.GenreId).OnDelete(DeleteBehavior.Restrict);
            //Author-Books
            modelBuilder.Entity<Author>().HasMany(a => a.Books).WithOne(b => b.Author).HasForeignKey(b => b.AuthorId).OnDelete(DeleteBehavior.Restrict);
            //Genre Fields
            modelBuilder.Entity<Genre>().Property(g => g.Name).HasMaxLength(100).IsRequired();
            //Author Fields
            modelBuilder.Entity<Author>().Property(a => a.FirstName).HasMaxLength(100).IsRequired();
            modelBuilder.Entity<Author>().Property(a => a.LastName).HasMaxLength(100).IsRequired();
            //Book Fields
            modelBuilder.Entity<Book>().Property(b => b.Title).HasMaxLength(250).IsRequired();
            //Seeding Genres:
            modelBuilder.Entity<Genre>().HasData(
                new Genre()
                {
                    Id = 1,
                    Name = "Поезія"
                },
                 new Genre()
                 {
                     Id = 2,
                     Name = "Романи"
                 },
                  new Genre()
                  {
                      Id = 3,
                      Name = "Драма"
                  }
                );
            //Seeding Authors
            modelBuilder.Entity<Author>().HasData(
                new Author()
                {
                    Id=1,
                    FirstName="Тарас",
                    LastName="Шевченко",
                    BirthYear=1814
                },
                 new Author()
                 {
                     Id = 2,
                     FirstName = "Леся",
                     LastName = "Українка",
                     BirthYear = 1871
                 },
                  new Author()
                  {
                      Id = 3,
                      FirstName = "Іван",
                      LastName = "Франко",
                      BirthYear = 1856
                  }
                );
        }
    }
}
