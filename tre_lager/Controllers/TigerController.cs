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

        public ActionResult Edit(Guid id)
        {
            var tiger = _manager.GetTiger(id);
            return View(tiger);
        }
    }
}