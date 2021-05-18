using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MvcFilmes.Models
{
    public class Ator
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string Name { get; set; }
        
        public int FilmeID { get; set; }

        public Filme Filme { get; set; }
    }
}