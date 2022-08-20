using System;
using System.ComponentModel.DataAnnotations;

namespace CotacaoMoeda.Models
{
    public class CotacaoModel
    {
        public long Id { get; set; }
        [Required(ErrorMessage = "Valor da cotação obrigatório")]
        public decimal Valor { get; set; }
        [Required(ErrorMessage = "Data da cotação obrigatória")]
        public DateTime Data { get; set; }
        public long MoedaId { get; set; }
    }
}
