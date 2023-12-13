using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace thirdProject.Models
{
    public class Cliente
    {
        public int Id {get; set;}
        public string Nome {get; set;}

        public NotaDeVenda NotaDeVenda {get; set;}
    }
}