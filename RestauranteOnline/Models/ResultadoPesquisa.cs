using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestauranteOnline.Models
{
    public class ResultadoPesquisa
    {
        public string Nome { set; get; }
        public string Endereco { set; get; }
        public string Telefone { set; get; }
        public string Site { set; get; }
        public bool DisqueEntrega { set; get; }
    }
}