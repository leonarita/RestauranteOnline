using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestauranteOnline.Models
{
    [MetadataType(typeof(BairroMetadado))]
    public partial class Bairro { }

    public class BairroMetadado
    {
        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(50, ErrorMessage = "O nome deve possuir, no máximo, 50 caracteres.")]
        public string Nome { set; get; }
    }
}