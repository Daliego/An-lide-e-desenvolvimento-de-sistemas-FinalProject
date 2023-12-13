using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace thirdProject.Models
{
    public class Produto
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public string Descricao {get; set;}
        public int Quantidade {get; set;}
        public double Preco {get; set;}
        public Item Item {get; set;}
        public Marca? Marca {get; set;}
    }
}