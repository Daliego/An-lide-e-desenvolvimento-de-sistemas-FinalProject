using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace thirdProject.Models
{
    public class TipoDePagamento
    {
        [Display(Name = "Código")]
        public int Id { get; set; }
        [Display(Name = "Nome do Cobrador")]
        public string NomeDoCobrador { get; set; }
        [Display(Name = "Informações Adicionais")]
        public string InformacoesAdicionais { get; set; }
        [Display(Name = "Nota de Venda")]
        public NotaDeVenda NotaDeVenda { get; set; }
    }
}