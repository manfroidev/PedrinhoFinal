using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pedrinho.Models
{
    public class Usuario
    {
        public  int usuarioId { get; set; }
        public  string nome { get; set; }
        public  string email { get; set; }
        public  string senha { get; set; }
        public  string tipoAcesso { get; set; }
    }
}

