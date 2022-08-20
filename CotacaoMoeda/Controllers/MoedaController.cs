using CotacaoMoeda.Entidades;
using CotacaoMoeda.Models;
using CotacaoMoeda.Repositorios.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CotacaoMoeda.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class MoedaController : ControllerBase
    {
        private readonly IMoedaRepository _moedaRepository;
        public MoedaController(IMoedaRepository moedaRepository)
        {
            _moedaRepository = moedaRepository;
        }
        [HttpPost]
        [Route("SalvarMoeda")]
        public bool SalvarMoeda([FromBody]MoedaModel moeda)
        {
            try
            {
                var Moeda = new Moeda()
                {
                    Nome = moeda.Nome,
                    Sigla = moeda.Sigla,
                    Pais = moeda.Pais
                };
                return _moedaRepository.SalvarMoeda(Moeda);
            }
            catch
            {
                return false;
            }
        }
        [HttpGet]
        [Route("BuscarMoedas")]
        public List<Moeda> BuscarMoedas()
        {
            return _moedaRepository.BuscarMoedas();
        }

    }
}
