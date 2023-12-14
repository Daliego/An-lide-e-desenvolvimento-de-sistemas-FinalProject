using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace thirdProject.Models
{
    public class Item
    {
        [Display(Name = "Código")]
        public int Id {get; set;}
        [Display(Name = "Preço")]
        public double Preco {get; set;}
        [Display(Name = "Percentual")]
        public int Percentual {get; set;}
        [Display(Name = "Quantidade")]
        public int Quantidade {get; set;}
        [Display(Name = "Produtos")]
        public List<Produto>? Produto {get; set;}
        [Display(Name = "Notas de Venda")]
        public List<NotaDeVenda> NotaDeVendas {get; set;}
    }
}