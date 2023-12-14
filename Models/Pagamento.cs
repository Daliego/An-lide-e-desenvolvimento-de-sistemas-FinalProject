using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace thirdProject.Models
{
    public class Pagamento
    {
        [Display(Name = "Código")]
        public int Id { get; set; }
        [Display(Name = "Data de Vencimento")]
        public DateTime DataLimite { get; set; }
        [Display(Name = "Valor")]
        public double Valor { get; set; }
        [Display(Name = "Pago")]
        public bool Pago { get; set; }
        [Display(Name = "Nota de Venda")]
        public List<NotaDeVenda> NotaDeVenda { get; set; } = new List<NotaDeVenda>();
    }
}