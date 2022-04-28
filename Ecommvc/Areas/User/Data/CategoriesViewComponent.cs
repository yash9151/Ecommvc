using Ecommvc.Data;
using Ecommvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommvc.Areas.User.Data
{
    public class CategoriesViewComponent : ViewComponent
    {
        private readonly EcomdbContext context;

        public CategoriesViewComponent(EcomdbContext context)
        {
            this.context = context;
        }


        public async Task<IViewComponentResult> InvokeAsync()
        {
            var categories = await GetCategoriesAsync();
            return View(categories);
        }

        private Task<List<Category>> GetCategoriesAsync()
        {
            return context.Categories.OrderBy(x => x.Sorting).ToListAsync();

        }

    }
}