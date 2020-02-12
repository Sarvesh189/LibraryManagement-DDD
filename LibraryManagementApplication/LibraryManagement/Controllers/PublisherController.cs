using LibraryManagement.ApplicationService.PublisherService;
using LibraryManagement.Models.Publisher;
using System;
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
             return View(publisherDtos);

        }

        // GET: Publisher/Details/5
        public ActionResult Details(Guid id)
        {
            var publisherDto = _pbService.GetPublisherById(id);
            return View(publisherDto);
        }

        // GET: Publisher/Create
        public ActionResult Create()
        {
            var pubDto = new PublisherDto();
            return View(pubDto);
        }

        // POST: Publisher/Create
        [HttpPost]
        public ActionResult Create(PublisherDto publisherDto)
        {
            try
            {
                _pbService.Add(publisherDto);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Publisher/Edit/5
        public ActionResult Edit(Guid id)
        {
            var publisherDto = _pbService.GetPublisherById(id);
            return View(publisherDto);
        }

        // POST: Publisher/Edit/5
        [HttpPost]
        public ActionResult Edit(PublisherDto publisher)
        {
            try
            {
                _pbService.Update(publisher);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Publisher/Delete/5
        public ActionResult Delete(Guid id)
        {
            var publisherDto = _pbService.GetPublisherById(id);
            return View(publisherDto);
        }

        // POST: Publisher/Delete/5
        [HttpPost]
        public ActionResult Delete(PublisherDto publisher)
        {
            try
            {
                _pbService.Remove(publisher);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
