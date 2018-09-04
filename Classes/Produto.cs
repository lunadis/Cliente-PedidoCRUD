using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    public class Produto
    {
        public int idProduto { get; set; }
        public string nmProduto { get; set; }
        public string nmFabricante { get; set; }
        public string preco { get; set; }
        public int qtd { get; set; }
        public DateTime validade { get; set; }
        public string telefone { get; set; }
    }
}
