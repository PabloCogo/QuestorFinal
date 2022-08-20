using CotacaoMoeda.Entidades;
using System.Collections.Generic;

namespace CotacaoMoeda.Repositorios.Interface
{
    public interface IMoedaRepository
    {
        bool SalvarMoeda(Moeda moeda);
        List<Moeda> BuscarMoedas();
    }
}
