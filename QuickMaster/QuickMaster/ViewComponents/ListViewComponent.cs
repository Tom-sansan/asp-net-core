using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuickMaster.Models;

namespace QuickMaster.ViewComponents
{
    public class ListViewComponent : ViewComponent
    {
        private readonly MyContext _context;

        public ListViewComponent(MyContext context)
        {
            this._context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int price)
        {
            return View(await _context.Book.Where(b => b.Price >= price).ToListAsync());
        }
    }
}
