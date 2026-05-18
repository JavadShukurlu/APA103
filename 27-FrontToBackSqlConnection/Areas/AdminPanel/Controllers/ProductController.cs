using FrontToBackSqlConnection.Areas.AdminPanel.ViewModels;
using FrontToBackSqlConnection.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FrontToBackSqlConnection.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public ProductController(AppDbContext context,IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            var products=await _context.Products
                .Where(p=>!p.isDeleted)
                .Include(p=>p.ProductImages)
                .Include(p=>p.Category)
                .Select(p=>new ProductGetVM
                {
                    Id=p.Id,
                    Name=p.Name,
                    Price=p.Price,
                    SKU=p.SKU,
                    Image=p.ProductImages.FirstOrDefault().Image,
                    CategoryName=p.Category.Name
                })
                .ToListAsync();

            return View(products);
        }
    }
}
