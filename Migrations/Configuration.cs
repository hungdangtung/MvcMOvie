namespace MvcMovie.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcMovie.Models.MovieDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MvcMovie.Models.MovieDBContext";
        }

        protected override void Seed(MvcMovie.Models.MovieDBContext context)
        {
            context.Movies.AddOrUpdate(
                i => i.Tilte, new Models.Movie { Tilte = "When Harry Met Sally", ReleaseDate = DateTime.Parse("1989-1-11"), Genre ="Romantic Comedy", Rating ="PG", Price = 7.99M},
                new Models.Movie { Tilte = "Ghostbusters", ReleaseDate = DateTime.Parse("1984-3-13"), Genre = "Comedy", Rating = "PG", Price = 8.99M },
                new Models.Movie { Tilte = "Ghostbuster 2", ReleaseDate = DateTime.Parse("1986-3-13"), Genre = "Comedy", Rating = "PG", Price = 9.99M },
                new Models.Movie { Tilte = "Rio Bravo", ReleaseDate = DateTime.Parse("1959-4-15"), Genre = "Western", Rating = "PG", Price = 3.99M }
                );
        }
    }
}
