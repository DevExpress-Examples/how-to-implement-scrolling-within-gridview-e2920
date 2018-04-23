using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EnableScrollingDynamically.Controllers {
    public class HomeController : Controller {
        // GET: Home
        public ActionResult Index() {
            return View();
        }
        public ActionResult GridViewPartial(bool? enableScroll) {
            if (enableScroll != null)
                Session["enableScroll"] = enableScroll;
            return PartialView("GridViewPartial", SimpleData.GetData());
        }
    }
    public class SimpleData {
        public static object GetData() {
            return Enumerable.Range(0, 25).Select(i => new {
                ID = i,
                A = i * 10,
                B = i % 2,
                C = "Test Text" + i.ToString(),
                D = "Test Text1" + i.ToString()
            });
        }
    }
}