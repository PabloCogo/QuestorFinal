using CotacaoMoeda.Entidades;
using System;

namespace CotacaoMoeda.Repositorios.Interface
{
    public interface ICotacaoRepository
    {
        bool SalvarCotacao(Cotacao cotacao);
        Cotacao BuscarCotacao(string MoedaName, DateTime data);

    }
}
