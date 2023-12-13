using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace thirdProject.Models
{
    public class NotaDeVenda
    { 
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public Boolean Tipo { get; set; } 
        public Boolean Cancelar { get; set; } 
        public Boolean Devolver { get; set; }
        public Item? Item { get; set; }
        public List<Cliente>? Cliente { get; set; } 
        public List<Vendedor>? Vendedor { get; set; } 
        public List<Transportadora>? Transportadora { get; set; } 
        public Pagamento Pagamento { get; set; }
        public List<TipoDePagamento>? TipoDePagamento { get; set; }
    }
}