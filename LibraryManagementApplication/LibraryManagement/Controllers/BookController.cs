using LibraryManagement.ApplicationService;
using LibraryManagement.ApplicationService.DTO;
using LibraryManagement.Helper;
using LibraryManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryManagement.Controllers
{
    public class BookController : Controller
    {
        //injectable candidate
        IBookService _bookService = new BookService();

        // GET: Book
        public ActionResult Index()
        {
            var bookviewmodelCollection = new List<BookViewModel>();
            var books = _bookService.GetBooks();
            foreach (var book in books)
            {
                bookviewmodelCollection.Add(ViewModelMapper.MapToBookViewModel(book));
            }

            return View(bookviewmodelCollection);
        }

        // GET: Book/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Book/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Book/Create
        [HttpPost]
        public ActionResult Create(BookViewModel bookviewmodel)
        {
            try
            {
                var bookdto = new BookDto();
                bookdto.Title = bookviewmodel.Title;
                bookdto.Paperback = bookviewmodel.Paperback;
                bookdto.ISBN = bookviewmodel.ISBN;
                bookdto.Language = bookviewmodel.Language;
                bookdto.Price = bookviewmodel.Price;
                
                _bookService.AddBook(bookdto);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Book/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Delete/5
        public ActionResult Delete(Guid id)
        {
            var bookdto = _bookService.GetBookById(id);

            return View(ViewModelMapper.MapToBookViewModel(bookdto));
        }

        // POST: Book/Delete/5
        [HttpPost]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            try
            {
                var bookdto = new BookDto() { BookId = id };
                _bookService.RemoveBook(bookdto);

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View(ex);
            }
        }
    }
}
