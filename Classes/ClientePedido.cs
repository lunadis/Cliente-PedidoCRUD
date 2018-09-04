using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Classes
{
    public class ClientePedido
    {
        public int idPedido { get; set; }
        public int idProduto { get; set; }
        public int idCliente { get; set; }
        public DateTime dtPedido { get; set; }
        public int qtd { get; set; }
        public string preco { get; set; }
        //public string marca { get; set; }
    }
}
