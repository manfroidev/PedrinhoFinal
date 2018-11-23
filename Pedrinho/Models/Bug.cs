using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pedrinho.Models
{
    public class Bug
    {
        public int bugId { get; set; }
        public int enigmaId { get; set; }
        public int usuarioId { get; set; }
        public int descricao { get; set; }
    }
}
