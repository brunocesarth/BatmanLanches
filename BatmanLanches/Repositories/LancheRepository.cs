using BatmanLanches.Context;
using BatmanLanches.Models;
using BatmanLanches.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BatmanLanches.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _context;

        public LancheRepository(AppDbContext contexto)
        {
            _context = contexto;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches
            .Where(lanche => lanche.IsLanchePreferido)
            .Include(c => c.Categoria);

        public Lanche GetLancheById(int lancheId)
        {
            return _context.Lanches.FirstOrDefault(lanche => lanche.LancheId == lancheId);
        }
    }
}
