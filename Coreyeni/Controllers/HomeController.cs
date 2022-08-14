using Coreyeni.Data.Contexts;
using Coreyeni.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Coreyeni.Controllers
{
    public class HomeController : Controller
    {
        EFCoreContext context;
        public HomeController(EFCoreContext _context)
        {
            context = _context;


        }


        public IActionResult Index()
        {
            
           

            //read
            List<Product> productList = context.Products.ToList();

           

            return View(productList);
        }
    }
}
