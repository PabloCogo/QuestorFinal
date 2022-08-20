using CotacaoMoeda.Context;
using CotacaoMoeda.Entidades;
using CotacaoMoeda.Repositorios.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace CotacaoMoeda.Repositorios
{
    public class CotacaoRepository : ICotacaoRepository
    {
        private readonly ApiContext _context;

        public CotacaoRepository(ApiContext context)
        {
            _context = context;
        }
        public bool SalvarCotacao(Cotacao cotacao)
        {
            try
            {
                if (cotacao.Id == 0)
                    _context.Cotacao.Add(cotacao);
                else
                {
                    _context.Cotacao.Update(cotacao);
                }
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        
        public Cotacao BuscarCotacao(string MoedaName, DateTime data)
        {
            return _context.Cotacao.Include(c => c.Moeda).Where(c => c.Moeda.Nome == MoedaName && c.Data <= data).FirstOrDefault();
        }
    }
}
