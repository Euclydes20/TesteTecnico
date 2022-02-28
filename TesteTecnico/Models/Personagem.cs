using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TesteTecnico.Models
{
    [Table("Personagem")]
    public class Personagem
    {
        [Display(Description = "Id")]
        [Column("Id")]
        public int id { get; set; }
        [Display(Description = "Personagem")]
        [Column("Personagem")]
        public string personagem { get; set; }
        [Display(Description = "Filme")]
        [Column("Filme")]
        public string filme { get; set; }
        [Display(Description = "Cenário")]
        [Column("Cenario")]
        public string cenario { get; set; }
    }
}
