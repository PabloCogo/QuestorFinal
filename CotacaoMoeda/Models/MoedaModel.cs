using System.ComponentModel.DataAnnotations;

namespace CotacaoMoeda.Models
{
    public class MoedaModel
    {
        public long Id { get; set; }
        [Required, MaxLength(60)]
        public string Nome { get; set; }

        [Required, MaxLength(10)]
        public string Sigla { get; set; }
        [MaxLength(80)]
        public string Pais { get; set; }
    }
}
