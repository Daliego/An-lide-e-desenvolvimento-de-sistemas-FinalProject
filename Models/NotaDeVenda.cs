using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace thirdProject.Models
{
    public class NotaDeVenda
    {
        [Display(Name = "Código")]
        public int Id { get; set; }
        [Display(Name = "Data")]
        public DateTime Data { get; set; }
        [Display(Name = "Tipo")]
        public bool Tipo { get; set; }
        [Display(Name = "Cancelar")]
        public bool Cancelar { get; set; }
        [Display(Name = "Devolver")]
        public bool Devolver { get; set; }
        [Display(Name = "Item")]
        public Item? Item { get; set; }
        [Display(Name = "Clientes")]
        public List<Cliente>? Cliente { get; set; }
        [Display(Name = "Vendedores")]
        public List<Vendedor>? Vendedor { get; set; }
        [Display(Name = "Transportadoras")]
        public List<Transportadora>? Transportadora { get; set; }
        [Display(Name = "Pagamento")]
        public Pagamento Pagamento { get; set; }
        public List<TipoDePagamento>? TipoDePagamento { get; set; }
    }
}