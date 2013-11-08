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
	}
}