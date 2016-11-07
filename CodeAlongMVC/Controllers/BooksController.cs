using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeAlongMVC.Repositories;

namespace CodeAlongMVC.Controllers
{
    public class BooksController : Controller
    {
        // GET: Books
        private BookRepository repo;

        public BooksController()
        {
            this.repo = new BookRepository();
        }

        public ActionResult Index()
        {
            var books = repo.GetAllBooks();
            return View(books);
        }

        public ActionResult Details(int id =-1)
        {
            var book = repo.GetBookById(id);
            return View(book);
        }

        public string TestMethod()
        {
            return "We are learning MVC";
        }
    }
}