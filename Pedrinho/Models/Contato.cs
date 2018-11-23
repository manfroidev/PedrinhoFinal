﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pedrinho.Models
{
    public class Contato
    {
        [Key]
        public int contatoId { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public string usuarioId { get; set; }

    }
}
