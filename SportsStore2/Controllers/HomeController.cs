using Microsoft.AspNetCore.Mvc;
using SportsStore2.Models;
using System.Linq; 

namespace SportsStore2.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository;

        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }

        public IActionResult Index()
        {
            return View(repository.Products);
        }
    }
}
