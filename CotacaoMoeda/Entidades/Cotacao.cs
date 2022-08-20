using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CotacaoMoeda.Entidades
{
    public class Cotacao : Entity
    {
        [Required]
        public decimal Valor { get; set; }
        [Required]
        public DateTime Data { get; set; }
        public long MoedaId { get; set; }
        public Moeda Moeda { get; set; }
    }
}
