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

            //código pra pesquisar:
             
            var movies = from m in _context.Movie select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(s => s.Title!.Contains(SearchString));
            }

            //fim
            
            //Movie = await _context.Movie.ToListAsync();
            Movie = await movies.ToListAsync();
            /*
             Colocar isso: "{SearchString?}" na linha 01, a direita de page da página index para pesquisar direto pela url do navegador.
             */

        }
    }
}
