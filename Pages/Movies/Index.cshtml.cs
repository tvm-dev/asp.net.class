using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoUnico.Models;

namespace ProjetoUnico.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly ProjetoUnico.Data.ProjetoUnicoContext _context;

        public IndexModel(ProjetoUnico.Data.ProjetoUnicoContext context)
        {
            _context = context;
        }

        //Propriedades abaixo servem para criar o código da caixa input de pesquisa
        public IList<Movie> Movie { get;set; } = default!;
        
        [BindProperty(SupportsGet = true)]
        public string? SearchString { get;set; }
        public SelectList? Genres { get;set; }
        [BindProperty(SupportsGet = true)]
        public string? MovieGenre { get;set; }
        //fim
        public async Task OnGetAsync()
        {
            //código pra pesquisar por genero de filme:

            IQueryable<string> genreQuery = from m in _context.Movie orderby m.Genre select m.Genre;

            //código pra pesquisar por nome de filme:

            var movies = from m in _context.Movie select m;

            //filtrando por titulo:
            if (!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(s => s.Title!.Contains(SearchString));
            }

            //filtrando por genero:
            if (!string.IsNullOrEmpty(MovieGenre))
            {
                movies = movies.Where(x => x.Genre == MovieGenre); 
            }

            //fim


            Genres = new SelectList(await genreQuery.Distinct().ToListAsync());

            //Movie = await _context.Movie.ToListAsync();
            Movie = await movies.ToListAsync();
            
            
            
            
            
            /*
             Colocar isso: "{SearchString?}" na linha 01, a direita de page da página index para pesquisar direto pela url do navegador.
             */

        }
    }
}
