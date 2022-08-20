using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CotacaoMoeda.Entidades
{
    public class Moeda : Entity
    {
        [Required,MaxLength(60)]
        public string Nome { get; set; }

        [Required,MaxLength(10)]
        public string Sigla { get; set; }

        [MaxLength(80)]
        public string Pais { get; set; }
        public List<Cotacao> Cotacao { get; set; }
    }
}
