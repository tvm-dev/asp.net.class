using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoUnico.Models
{
    public class Movie
    {
        //============================================================================//
        public int Id  { get; set; }
        //============================================================================//

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(60, MinimumLength =3, ErrorMessage = "O título deve ter entre 3 e 60 caracteres.")]
        [Display(Name = "Título")]
        public string? Title { get; set; } = string.Empty;
        //============================================================================//


        [Display(Name = "Lançamento")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        //============================================================================//
                [Display(Name = "Categoria")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "Categoria Deve ter somente letras e começar com Maiúscula")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string? Genre { get; set; } = string.Empty;

        //============================================================================//
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Preço")]
        [Column(TypeName ="decimal(18,2)")]
        public decimal Price { get; set; }

        //============================================================================//
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string? Rating { get; set; } = string.Empty;
        //============================================================================//

    }
}
