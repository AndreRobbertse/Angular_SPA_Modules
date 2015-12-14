using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Xtreme.Reports.Controllers
{
    public class ReportController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult _DocumentViewer()
        {
            return PartialView(new ClientReport());
        }
    }
}