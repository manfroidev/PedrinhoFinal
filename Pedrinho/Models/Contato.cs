using System;
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

        [RegularExpression(@"[a-zA-Z]{3,15}", ErrorMessage = "Somente letras e de 5 a 15 caracteres")]
        [Required(ErrorMessage = "O nome obrigatorio ! ! !")]
        public string nome { get; set; }
       
        [Required(ErrorMessage = "O nome obrigatorio ! ! !")]
        public string sobrenome { get; set; }

        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Por favor insira um endereço de e-mail válido.")]
        [Required(ErrorMessage = "O e-mail e obrigatorio ! ! !")]
        public string email { get; set; }

        [RegularExpression(@"[0-9]{8,12}", ErrorMessage = "Somente numeros com no minimo 8 e maximo 12 numeros")]
        public string telefone { get; set; }

        [Required(ErrorMessage = "O campo obrigatorio ! ! !")]
        public string mensagem { get; set; }


    }
}
