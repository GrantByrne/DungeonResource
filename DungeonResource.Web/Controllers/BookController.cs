using DungeonResource.Components.Domain.Book;
using DungeonResource.Components.Domain.Spell;
using DungeonResource.Components.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DungeonResource.Web.Controllers
{
    public class BookController : Controller
    {
        /// <summary>
        /// Handles the business logic for the interactions with books
        /// </summary>
        private readonly IBookService _bookService;

        /// <summary>
        /// ctor
        /// </summary>
        /// <param name="bookService"></param>
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        //
        // GET: /Book/
        public ActionResult Index()
        {
            var books = _bookService.ReadAll();
            return View(books.OrderBy(p => p.Title));
        }

        //
        // GET: /Book/Details/5
        public ActionResult Details(int id)
        {
            var book = _bookService.Read(id);
            return View(book);
        }

        //
        // GET: /Book/Create
        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Book/Create
        [HttpPost]
        public ActionResult Create(Book book)
        {
            try
            {
                _bookService.Create(book);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Book/Update/5
        public ActionResult Update(int id)
        {
            var book = _bookService.Read(id);
            return View(book);
        }

        //
        // POST: /Book/Update/5
        [HttpPost]
        public ActionResult Update(Book book)
        {
            try
            {
                _bookService.Update(book);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Book/Delete/5
        public ActionResult Delete(int id)
        {
            _bookService.Delete(id);
            return View();
        }
	}
}