using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace thirdProject.Models
{
    public class Pagamento
    {
        public int Id {get; set;}
        public DateTime DataLimite {get; set;}
        public double Valor {get; set;}
        public Boolean Pago {get; set;}
        public List<NotaDeVenda>? NotaDeVenda {get; set;}
    }
}