using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace thirdProject.Models
{
    public class TipoDePagamento
    {
        public int Id {get; set;}
        public string NomeDoCobrador {get; set;}
        public string InformacoesAdicionais {get; set;}
        public NotaDeVenda NotaDeVenda {get; set;}
    }
}