using BulkyBook.Data;
using BulkyBook.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBook.Controllers
{
    public class KategoriController : Controller
    {

        private readonly ApplicationDbContext _context;

        public KategoriController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            //var objKategoriList = _context.Categories.ToList();  

            IEnumerable<Kategori> objKategoriList = _context.Categories.ToList();
            return View(objKategoriList);
        }

        //GET
        public IActionResult Create()
        {
           
            return View();
        }

    }
}
