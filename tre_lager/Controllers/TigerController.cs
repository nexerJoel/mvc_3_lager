using ServiceLayer;
using ServiceLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace tre_lager.Controllers
{
    public class TigerController : Controller
    {
        private TigerManager _manager;
        public TigerController() {
            _manager = new TigerManager();
        }

        // GET: Tiger
        public ActionResult Index()
        {
            var tigers = _manager.GetAllTigers();
            return View(tigers);
        }

        [HttpPost]
        public ActionResult Index(TigerModel model) {
            _manager.CreateTiger(model);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult CreateTiger(TigerModel model)
        {
            _manager.CreateTiger(model);
            return RedirectToAction("Index");
        }


        public ActionResult Edit(Guid id, string name, int? legs)
        {
            var tiger = _manager.GetTiger(id);
            return View(tiger);
        }

        [HttpPost]
        public ActionResult Edit(TigerModel model) {

            //Update db with updated values 

            return RedirectToAction("Edit", "Tiger", new { id = model.Id, name = "joel", legs = 2 });
        }
    }
}