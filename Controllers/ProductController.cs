using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportsPro.Models;

namespace SportsPro.Controllers
{
    public class ProductController : Controller
    {

        private SportsProContext context { get; set; }

        public ProductController(SportsProContext ctx)
        {

            context = ctx;
        }

        public IActionResult Products()
        {
            var products = context.Products.ToList();
            return View(products);
        }

        //CREATE A PRODUCT
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Products product) {
            context.Products.Add(product);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        //EDIT A PRODUCT
        [HttpGet]
        public IActionResult Edit(int? id) {
            if(id == null || id == 0)
            {
                return NotFound();
            }
            var productFromDb = context.Products.Find(id);
            if(productFromDb == null)
            {
                return NotFound();
            }
            return View(productFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Products product)
        {
            context.Products.Update(product);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        //DELETING A PRODUCT
        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var productFromDb = context.Products.Find(id);
            if (productFromDb == null)
            {
                return NotFound();
            }
            return View(productFromDb);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(Products product)
        {
            context.Products.Remove(product);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
        /**
        [HttpGet]
        public IActionResult Edit(int id) {

            ViewBag.Action = "Edit";
            var product = context.Products.Find(id);    
            return View(product);
        
        }

        [HttpPost]
        public IActionResult Edit(Product product) {

            if (ModelState.IsValid)
            {
                if (product.ProductId == 0)
                    context.Products.Add(product);
                else
                    context.Products.Update(product);

                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            { 
                ViewBag.Action = (product.ProductId == 0) ? "Add" : "Edit";
                return View(product);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var product = context.Products.Find(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Delete(Product product) { 
            context.Products.Remove(product);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
*/