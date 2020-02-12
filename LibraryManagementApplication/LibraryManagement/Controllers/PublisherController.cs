using LibraryManagement.ApplicationService.PublisherService;
using LibraryManagement.Models.Publisher;
using System.Collections.Generic;
using System.Web.Mvc;

namespace LibraryManagement.Controllers
{
    public class PublisherController : Controller
    {
        IPublisherService _pbService = new PublisherService();
        // GET: Publisher
        public ActionResult Index()
        {           
          var publisherDtos =  _pbService.GetAllPublishers();
           var publisherViewModels = new List<PublisherViewModel>();
            foreach (var pubDto in publisherDtos)
            {
                publisherViewModels.Add(PublisherViewModelMapping.Map(pubDto));
            }
            return View(publisherViewModels);

        }

        // GET: Publisher/Details/5
        public ActionResult Details(string id)
        {
            var publisherDto = _pbService.GetPublisherById(id);
           var pvm = PublisherViewModelMapping.Map(publisherDto);
            return View(pvm);
        }

        // GET: Publisher/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Publisher/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Publisher/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Publisher/Edit/5
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

        // GET: Publisher/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Publisher/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
