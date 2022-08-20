using CotacaoMoeda.Entidades;
using CotacaoMoeda.Models;
using CotacaoMoeda.Repositorios.Interface;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CotacaoMoeda.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class CotacaoController : ControllerBase
    {
        private readonly ICotacaoRepository _cotacaoRepository;

        public CotacaoController(ICotacaoRepository cotacaoRepository)
        {
            _cotacaoRepository = cotacaoRepository;
        }
        [HttpPost]
        [Route("SalvarCotacao")]
        public bool SalvarCotacao([FromBody]CotacaoModel cotacao)
        {
            try
            {
                var Cotacao = new Cotacao()
                {
                    Valor = cotacao.Valor,
                    Data = cotacao.Data,
                    MoedaId = cotacao.MoedaId
                };
                return _cotacaoRepository.SalvarCotacao(Cotacao);
            }
            catch
            {
                return false;
            }
        }
        [HttpGet]
        [Route("BuscarCotacao")]
        public Cotacao BuscarCotacao(string moeda,DateTime data)
        {
            return _cotacaoRepository.BuscarCotacao(moeda, data);
        }
    }
}
