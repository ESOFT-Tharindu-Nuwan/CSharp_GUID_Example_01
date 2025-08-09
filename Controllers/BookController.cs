using Ebook.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ebook.Controllers
{
    public class BookController : Controller
    {
        private readonly AppDbContext _context;

        public BookController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var books = _context.Books.ToList();
            return View(books);
        }

        // GET: Book/Create (This method loads the create book page)
        public IActionResult Create()
        {
            return View();
        }

        // POST: This method handles the form submission for creating a book
        [HttpPost]
        public IActionResult Create(Book bookRequest)
        {
            bookRequest.Id = Guid.NewGuid();
            _context.Books.Add(bookRequest);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(Guid id)
        {
            var bookDetail = _context.Books.Find(id);
            return View(bookDetail);
        }

        public IActionResult Edit(Guid id)
        {
            var bookDetail = _context.Books.Find(id);
            return View(bookDetail);
        }

        [HttpPost]
        public IActionResult Edit(Book bookRequest)
        {
            _context.Update(bookRequest);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(Guid id)
        {
            var bookDetail = _context.Books.Find(id);
            _context.Books.Remove(bookDetail);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
