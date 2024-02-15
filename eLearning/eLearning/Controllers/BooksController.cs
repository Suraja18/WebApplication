using eLearning.Data;
using eLearning.Data.Services;
using eLearning.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace eLearning.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBooksService _service;
        public BooksController(IBooksService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Picture,Name,Description,Course,Price,Publishdate")] Books Books)
        {
            if (!ModelState.IsValid)
            {
                return View(Books);
            }
            await _service.AddAsync(Books);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var BooksDetails = await _service.GetByIdAsync(id);

            if (BooksDetails == null) return View("NotFound");
            return View(BooksDetails);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var BooksDetails = await _service.GetByIdAsync(id);

            if (BooksDetails == null) return View("NotFound");
            return View(BooksDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Picture,Name,Description,Course,Price,Publishdate")] Books Books)
        {
            if (!ModelState.IsValid)
            { 
                return View(Books); 
            }
            await _service.UpdateAsync(id, Books);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int id)
        {
            var BooksDetails = await _service.GetByIdAsync(id);

            if (BooksDetails == null) return View("NotFound");
            return View(BooksDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var BooksDetails = await _service.GetByIdAsync(id);

            if (BooksDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
