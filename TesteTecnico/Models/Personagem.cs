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
        [Display(Name = "ID", Description = "Id")]
        [Column("Id")]
        public int id { get; set; }
        [Display(Name = "PERSONAGEM", Description = "Personagem")]
        [Column("Personagem")]
        public string personagem { get; set; }
        [Display(Name = "FILME", Description = "Filme")]
        [Column("Filme")]
        public string filme { get; set; }
        [Display(Name = "CENÁRIO", Description = "Cenário")]
        [Column("Cenario")]
        public string cenario { get; set; }
    }
}
