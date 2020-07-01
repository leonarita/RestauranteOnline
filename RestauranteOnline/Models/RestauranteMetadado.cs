using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestauranteOnline.Models
{
    [MetadataType(typeof(RestauranteMetadado))]
    public partial class Restaurante { }

    public class RestauranteMetadado
    {
        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(30, ErrorMessage = "O nome deve possuir, no máximo, 30 caracteres.")]
        public string Nome { set; get; }

        [Required(ErrorMessage = "O endereço é obrigatório.")]
        [StringLength(50, ErrorMessage = "O endereço deve possuir, no máximo, 50 caracteres.")]
        public string Endereco { set; get; }

        [Required(ErrorMessage = "O telefone é obrigatório.")]
        [StringLength(11, ErrorMessage = "O telefone deve possuir, no máximo, 11 caracteres.")]
        public string Telefone { set; get; }

        [StringLength(40, ErrorMessage = "O site deve possuir, no máximo, 40 caracteres.")]
        public string Site { set; get; }

        [Required(ErrorMessage = "O gênero é obrigatório.")]
        public int IDGenero { set; get; }

        [Required(ErrorMessage = "O bairro é obrigatório.")]
        public int IDBairro { set; get; }
    }

    /*
    [DisplayName("Restaurante")]
    public class RestauranteMetadado
    {
        [DisplayName("ENdereço")]
        public string Endereco { get; set; }
    }
    */
}