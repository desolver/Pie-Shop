using Microsoft.AspNetCore.Mvc;
using PieShop.Models.Repositories;
using PieShop.ViewModels;

namespace PieShop.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;
        
        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        // GET
        public ViewResult List()
        {
            var piesList = new PiesListViewModel { CurrentCategory = "Cheese cakes", Pies = _pieRepository.AllPies};
            return View(piesList);
        }
    }
}