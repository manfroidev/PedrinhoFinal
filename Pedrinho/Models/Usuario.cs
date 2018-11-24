using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Pedrinho.Models
{

    public class Usuario
    {
        public int usuarioId { get; set; }

        [RegularExpression(@"[a-zA-Z]{5,15}", ErrorMessage = "Somente letras e de 5 a 15 caracteres")]
        [Required(ErrorMessage = "O nome obrigatorio ! ! !")]
        public string nome { get; set; }

        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Por favor insira um endereço de e-mail válido.")]
        [Required(ErrorMessage = "O e-mail e obrigatorio ! ! !")]
        public string email { get; set; }

        [RegularExpression(@"[a-zA-Z-0-9]{5,15}", ErrorMessage = "A senha tem que ter no minimo 5 caracteres e no maximo 10 caracteres")]
        [Required(ErrorMessage = "A senha e obrigatorio ! ! !")]
        public  string senha { get; set; }

        [Required(ErrorMessage = "Selecione 1 tipo de acesso")]
        public  string tipoAcesso { get; set; }
    }
}

