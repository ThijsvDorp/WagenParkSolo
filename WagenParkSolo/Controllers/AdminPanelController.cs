using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WagenParkSolo.Models;

namespace WagenParkSolo.Controllers
{
    [Authorize(Roles = "Admin, Employee")]
    public class AdminPanelController : Controller
    {
        WagenparkEntities db = new WagenparkEntities();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult NextDayOrders()
        {
            return View(db.spNextDayOrders());
        }
    }
}