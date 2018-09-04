using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    public class Cliente
    {
        //Metodo generics como o as classes do model

        public int codigoCliente { get; set; }
        public string nmCliente { get; set; }
        public DateTime dtNascimento { get; set; }
        public string nrTelefone { get; set; }
        public string dsEndereco { get; set; }
    }
}
