using BatmanLanches.Context;
using BatmanLanches.Models;
using BatmanLanches.Repositories.Interfaces;

namespace BatmanLanches.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;
        public CategoriaRepository(AppDbContext contexto)
        {
            _context = contexto;
        }

        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
