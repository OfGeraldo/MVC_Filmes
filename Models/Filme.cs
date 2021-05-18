using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MvcFilmes.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Título")]
        public string Title { get; set; }

        [Display(Name = "Gênero")]
        public string Genre { get; set; }

        [Display(Name = "Preço"), Column(TypeName = "decimal(5, 2)")]
        public decimal Price { get; set; }

        [Display(Name = "Avaliação"), Range(1,5)]
        public int Rating { get; set; }

        [Display(Name = "Data de Lançamento"), DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public List<Ator> Atores { get; set; }
    }
}