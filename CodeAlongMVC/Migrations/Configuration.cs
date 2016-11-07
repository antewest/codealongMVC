using CodeAlongMVC.Models;

namespace CodeAlongMVC.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeAlongMVC.DataAccess.LibraryContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CodeAlongMVC.DataAccess.LibraryContext context)
        {
            context.Books.AddOrUpdate(
                new Book { Id = 1, Author = "Ed McBain", Description = "Thriller", Title = "Trespass", Isbn = "111-111" },
                new Book { Id = 2, Author = "Michael Connelly", Description = "Thriller", Title = "The Poet", Isbn = "111-112" },
                new Book { Id = 3, Author = "Astrid Lindgren", Description = "Adventure", Title = "Pippi Longstocking", Isbn = "111-113" },
                new Book { Id = 4, Author = "Ed McBain", Description = "Thriller", Title = "Red Rain", Isbn = "111-114" },
                new Book { Id = 5, Author = "Astrid Lindgren", Description="Adventure", Title="Emil in Lonneberga", Isbn = "111-115"}
            );

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
