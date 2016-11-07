using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using CodeAlongMVC.Models;

namespace CodeAlongMVC.DataAccess
{
    public class LibraryContext: DbContext
    {
        public LibraryContext() : base("DefaultConnection")
        {
            
        }

        public DbSet<Book> Books { get; set; }
    }
}