using CotacaoMoeda.Context;
using CotacaoMoeda.Entidades;
using CotacaoMoeda.Models;
using CotacaoMoeda.Repositorios.Interface;
using System.Collections.Generic;
using System.Linq;

namespace CotacaoMoeda.Repositorios
{
    public class MoedaRepository : IMoedaRepository
    {
        private readonly ApiContext _context;
        public MoedaRepository(ApiContext context)
        {
            _context = context;
        }
        public bool SalvarMoeda(Moeda moeda)
        {
            try
            {
                if (moeda.Id == 0)
                    _context.Moeda.Add(moeda);
                else
                    _context.Moeda.Update(moeda);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<Moeda> BuscarMoedas()
        {
            return _context.Moeda.ToList();
        }
    }
}
