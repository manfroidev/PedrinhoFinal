using Microsoft.EntityFrameworkCore;


namespace Pedrinho.Models
{
    public class PedrinhoContext : DbContext
    {
        public PedrinhoContext()
        {
        }

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
