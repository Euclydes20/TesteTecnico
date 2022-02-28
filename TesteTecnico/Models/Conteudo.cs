using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteTecnico.Models
{
    public class Conteudo : DbContext
    {
        public Conteudo(DbContextOptions<Conteudo> option) : base(option)
        {
            Database.EnsureCreated();
        }
        public DbSet<Personagem> personagem { get; set; }
    }
}
