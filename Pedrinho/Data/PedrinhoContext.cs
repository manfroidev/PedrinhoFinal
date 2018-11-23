using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pedrinho.Models;

namespace Pedrinho.Models
{
    public class PedrinhoContext : DbContext
    {
        public PedrinhoContext (DbContextOptions<PedrinhoContext> options)
            : base(options)
        {
        }

        public DbSet<Pedrinho.Models.Usuario> Usuario { get; set; }

        public DbSet<Pedrinho.Models.Bug> Bug { get; set; }

        public DbSet<Pedrinho.Models.Contato> Contato { get; set; }

        public DbSet<Pedrinho.Models.Enigma> Enigma { get; set; }
       
    }
}
