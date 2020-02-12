using LibraryManagement.ApplicationService.BookService;
using LibraryManagement.ApplicationService.PublisherService;
using LibraryManagement.Models.Book;
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
        IPublisherService _pubService = new PublisherService();
        // GET: Book
        public ActionResult Index()
        {
            var books = _bookService.GetAllBooks();
           
            return View(books);
        }

        // GET: Book/Details/5
        public ActionResult Details(Guid id)
        {
            var book = _bookService.GetBookById(id);
            return View(book);
        }

        // GET: Book/Create
        public ActionResult Create()
        {
            var bookmodel = new BookViewModel();
            var publishers = _pubService.GetAllPublishers();
            var pubs = new List<SelectListItem>();
            foreach (var pub in publishers)
            {
                pubs.Add(new SelectListItem() { Text = pub.Name, Value = pub.Id.ToString() });

            }
            bookmodel.PublisherList = pubs;
            return View(bookmodel);
        }

        // POST: Book/Create
        [HttpPost]
        public ActionResult Create(BookViewModel bookviewmodel)
        {
            try
            {
                var bookdto = new ApplicationService.BookService.BookDto();
                bookdto.Title = bookviewmodel.Title;
                bookdto.ISBN = bookviewmodel.ISBN;
                bookdto.Language = bookviewmodel.Language;
                bookdto.Price = bookviewmodel.Price;
                bookdto.Publisher = new ApplicationService.BookService.PublisherDto() { Id = Guid.Parse(bookviewmodel.SelectedPublisher) };
                _bookService.Add(bookdto);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Edit/5
        public ActionResult Edit(Guid id)
        {
            var bookdto = _bookService.GetBookById(id);
            return View(bookdto);
        }

        // POST: Book/Edit/5
        [HttpPost]
        public ActionResult Edit(ApplicationService.BookService.BookDto bookDto)
        {
            try
            {
                _bookService.Update(bookDto);
                
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

            return View(bookdto);
        }

        // POST: Book/Delete/5
        [HttpPost]
        public ActionResult Delete(Guid id, FormCollection collection)
        {
            try
            {
                var bookdto = new ApplicationService.BookService.BookDto() { BookId = id };
                _bookService.Remove(bookdto);

                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return View(ex);
            }
        }
    }
}
