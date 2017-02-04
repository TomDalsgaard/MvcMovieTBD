namespace MvcMovieTBD.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcMovieTBD.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MvcMovieTBD.Models.MovieDBContext context)
        {
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
            context.Movies.AddOrUpdate(i => i.Title,
                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-1-11"),
                    Genre = "Romantic Comedy",
                    Rating = "G",
                    ImDBUrl = "http://",
                    Price = 7.99M
                },

                 new Movie
                 {
                     Title = "Ghostbusters ",
                     ReleaseDate = DateTime.Parse("1984-3-13"),
                     Genre = "Comedy",
                     Rating = "PG",
                     ImDBUrl = "http://",
                     Price = 8.99M
                 },

                 new Movie
                 {
                     Title = "Ghost ",
                     ReleaseDate = DateTime.Parse("1989-6-23"),
                     Genre = "Comedy",
                     Rating = "G",
                     ImDBUrl = "http://",
                     Price = 6.99M
                 },

                 new Movie
                 {
                     Title = "Ghostbusters 2",
                     ReleaseDate = DateTime.Parse("1986-2-23"),
                     Genre = "Comedy",
                     Rating = "PG",
                     ImDBUrl = "http://",
                     Price = 9.99M
                 },

               new Movie
               {
                   Title = "Rio Bravo",
                   ReleaseDate = DateTime.Parse("1959-4-15"),
                   Genre = "Western",
                   Rating = "G",
                   ImDBUrl = "http://",
                   Price = 3.99M
               },

               new Movie
               {
                   Title = "Bladerunner",
                   ReleaseDate = DateTime.Parse("1979-07-15"),
                   Genre = "Sci Fi",
                   Rating = "PG",
                   ImDBUrl = "http://",
                   Price = 3.99M
               }
           );
        }
    }
}
