using System;
using System.Collections.Generic;
using System.Text;
using BookMenagement.DAL.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Proxies;

namespace BookMenagement.DAL.DBContext
{
    public class BookMenagementContext:DbContext
    {
      
        public DbSet<Author> Author { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<BookCategory> BookCategory { get; set; }
        public DbSet<Currency> Currency { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<RecieptLine> RecieptLine { get; set; }
        public DbSet<RecieptHeader> RecieptHeader { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer("Server=.\\;Initial Catalog=BookMenagement;Integrated Security=True;Trusted_Connection=True")
                ;
          
        }
    }
}
