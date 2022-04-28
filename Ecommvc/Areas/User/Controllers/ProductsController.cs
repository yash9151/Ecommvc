using Ecommvc.Data;
using Ecommvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommvc.Areas.User.Controllers
{
    [Area("User")]

    public class ProductsController : Controller
    {

        private readonly EcomdbContext context;

        public ProductsController(EcomdbContext context)
        {
            this.context = context;

        }

        public async Task<IActionResult> Index()
        {
            var ecomWebdbcontext = context.Products;
            return View(await ecomWebdbcontext.ToListAsync());

        }

        //user/products/category
        public async Task<IActionResult> ProductsByCategory(string categorySlug)
        {

            Category category = await context.Categories.Where(x => x.Slug == categorySlug).FirstOrDefaultAsync();

            if (category == null) return RedirectToAction("Index");

            var ecomdbContext = context.Products.Where(m => m.CatId == category.CatId); ViewBag.CategoryName = category.CatName;

            ViewBag.categorySlug = category.Slug;

            return View(await ecomdbContext.ToListAsync());



        }
    }
}