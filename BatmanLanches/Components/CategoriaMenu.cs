using BatmanLanches.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BatmanLanches.Components
{
    public class CategoriaMenu : ViewComponent
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaMenu(ICategoriaRepository categoriaMenu)
        {
            _categoriaRepository = categoriaMenu;
        }

        public IViewComponentResult Invoke()
        {
            var categorias = _categoriaRepository.Categorias.OrderBy(p => p.CategoriaNome);
            return View(categorias);
        }
    }
}
