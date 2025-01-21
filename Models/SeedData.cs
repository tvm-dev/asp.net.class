using Microsoft.EntityFrameworkCore;
using ProjetoUnico.Data;
namespace ProjetoUnico.Models
{
    public class SeedData
    {
        public static void Initilaize(IServiceProvider serviceProvider)
        {
            //using(var context = new ProjetoUnicoContext)
            using (var context = new ProjetoUnicoContext(serviceProvider.GetRequiredService<DbContextOptions<ProjetoUnicoContext>>()))
            {
                if (context == null || context.Movie == null)
                {
                    throw new ArgumentNullException("Null ProjetoUnicoContext");
                }

                if (context.Movie.Any()){
                    return;
                }

                //Senao contiver registros, adicioná-los:

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Tropa de Elite",
                        ReleaseDate = DateTime.Parse("1997-12-01"),
                        Genre = "Ação",
                        Price = 9.99M
                    },
                    new Movie
                    {
                        Title = "Tropa de Elite 2",
                        ReleaseDate = DateTime.Parse("2007-12-01"),
                        Genre = "Ação",
                        Price = 99.99M
                    },
                    new Movie
                    {
                        Title = "E o vento levou",
                        ReleaseDate = DateTime.Parse("1977-12-01"),
                        Genre = "Drama",
                        Price = 7.49M
                    },
                     new Movie
                     {
                         Title = "Tropa de Elite",
                         ReleaseDate = DateTime.Parse("1997-12-01"),
                         Genre = "Ação",
                         Price = 9.99M
                     },
                    new Movie
                    {
                        Title = "Tropa de Elite 2",
                        ReleaseDate = DateTime.Parse("2007-12-01"),
                        Genre = "Ação",
                        Price = 99.99M
                    },
                    new Movie
                    {
                        Title = "E o vento levou",
                        ReleaseDate = DateTime.Parse("1977-12-01"),
                        Genre = "Drama",
                        Price = 7.49M
                    },
                     new Movie
                     {
                         Title = "Tropa de Elite",
                         ReleaseDate = DateTime.Parse("1997-12-01"),
                         Genre = "Ação",
                         Price = 9.99M
                     },
                    new Movie
                    {
                        Title = "Tropa de Elite 2",
                        ReleaseDate = DateTime.Parse("2007-12-01"),
                        Genre = "Ação",
                        Price = 99.99M
                    },
                    new Movie
                    {
                        Title = "E o vento levou",
                        ReleaseDate = DateTime.Parse("1977-12-01"),
                        Genre = "Drama",
                        Price = 7.49M
                    }
                    );

                    context.SaveChanges();
            }
        }
    }
}
