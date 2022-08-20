using CotacaoMoeda.Entidades;
using Microsoft.EntityFrameworkCore;

namespace CotacaoMoeda.Context
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options) { }
        public DbSet<Moeda> Moeda { get; set; }
        public DbSet<Cotacao> Cotacao { get; set; }
        protected override void OnModelCreating(ModelBuilder model)
        {
            base.OnModelCreating(model);
        }
    }
}
