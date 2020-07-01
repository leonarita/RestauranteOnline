using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestauranteOnline.Models
{
    [MetadataType(typeof(UsuarioMetadado))]
    public partial class Usuario { }

    public class UsuarioMetadado
    {
        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(50, ErrorMessage = "O nome deve possuir, no máximo, 50 caracteres.")]
        public string Nome { set; get; }

        [Required(ErrorMessage = "O login é obrigatório.")]
        [StringLength(30, ErrorMessage = "O login deve possuir, no máximo, 30 caracteres.")]
        public string Login { set; get; }

        [Required(ErrorMessage = "A senha é obrigatório.")]
        [StringLength(100, ErrorMessage = "A senha deve possuir, no máximo, 100 caracteres.")]
        public string Senha { set; get; }
    }
}