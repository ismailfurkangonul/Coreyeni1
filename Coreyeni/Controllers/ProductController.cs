using Coreyeni.Data.Contexts;
using Coreyeni.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Coreyeni.Controllers
{
    public class ProductController : Controller
    {
        EFCoreContext context;
        public ProductController(EFCoreContext _context)
        {
            context = _context;


        }


        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Update(int Id)
        {
          
            return View(context.Products.Where(X => X.Id == Id).FirstOrDefault());
        }

        #region http

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            
            context.Products.Add(product);
            context.SaveChanges();
            return RedirectToAction("Index","Home");



        }
        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {
           
            context.Products.Update(product);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");



        }
        [HttpGet]
        public IActionResult DeleteProduct(int Id)
        {
           
            Product deleted = context.Products.Where(X => X.Id == Id).FirstOrDefault();
            context.Products.Remove(deleted);
            context.SaveChanges();

            return RedirectToAction("Index", "Home");


        }
        #endregion
    }
}
