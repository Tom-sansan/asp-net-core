using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuickMaster_Core3.Models;
using System.Linq;
using System.Threading.Tasks;

namespace QuickMaster_Core3.ViewComponents
{
    public class ListViewComponent : ViewComponent
    {
        private readonly MyContext _Context;

        public ListViewComponent(MyContext context)
        {
            this._Context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int price)
        {
            return View(await _Context.Book
                .Where(b => b.Price >= price).ToListAsync());
        }
    }
}
