using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GridView.Scrolling.Models;

namespace GridView.Scrolling.Controllers {
    [HandleError]
    public class GridViewController : Controller {
        public ActionResult Index() {
            return Scrolling();
        }
        public ActionResult Scrolling(){
            ViewData["ShowVerticalScrollBar"] = true;
            ViewData["ShowHorizontalScrollBar"] = true;
            return View("Scrolling", NorthwindDataProvider.GetInvoices());
        }
        public ActionResult ScrollingPartial() {
            GetRequestParemetrs();
            return PartialView("ScrollingPartial", NorthwindDataProvider.GetInvoices());
        }
        void GetRequestParemetrs() {
            ViewData["ShowVerticalScrollBar"] = string.IsNullOrEmpty(Request.Params["ShowVerticalScrollBar"]) ? true : bool.Parse(Request.Params["ShowVerticalScrollBar"]);
            ViewData["ShowHorizontalScrollBar"] = string.IsNullOrEmpty(Request.Params["ShowHorizontalScrollBar"]) ? true : bool.Parse(Request.Params["ShowHorizontalScrollBar"]);
        }
    }
}
