using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic;

namespace ProjetoUnico.Models
{
    public class Movie
    {
        //========================= ID ===================================================//
        public int Id  { get; set; }

        //============================= Title ===============================================//
                [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(60, MinimumLength =3, ErrorMessage = "O título deve ter entre 3 e 60 caracteres.")]
        [Display(Name = "Título")]
        public string? Title { get; set; } = string.Empty;

        //=========================== Release Date=================================================//

        [Display(Name = "Lançamento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        //============================= Genre===============================================//
        [Display(Name = "Categoria")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "Categoria Deve ter somente letras e começar com Maiúscula")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string? Genre { get; set; } = string.Empty;

        //============================= Price===============================================//
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Display(Name = "Preço")]
        [Column(TypeName ="decimal(18,2)")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        //============================= Rating ===============================================//
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string? Rating { get; set; } = string.Empty;

        //============================================================================//

    }
}
