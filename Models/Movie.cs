using System.ComponentModel.DataAnnotations;

namespace ProjetoUnico.Models
{
    public class Movie
    {
        public int Id  { get; set; }

        [Display(Name = "Título")]
        public string? Title { get; set; }

        [Display(Name = "Lançamento")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Categoria")]
        public string? Genre { get; set; }

        [Display(Name = "Preço")] 
        public decimal Price { get; set; }
        

    }
}
