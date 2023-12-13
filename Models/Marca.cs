using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace thirdProject.Models
{
    public class Marca
    {
        public int Id {get; set;}
        public string Name {get; set;}
        public string Descricao {get; set;}

        public Produto Produto {get; set;}
    }
}