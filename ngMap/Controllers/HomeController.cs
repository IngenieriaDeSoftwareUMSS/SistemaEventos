using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ngMap.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        // Here I will create 3 Action  

        // 1. Index - for return view where I will show Google Map
        public ActionResult Index()
        {
            return View();
        }

        //2. GetAllLocation - for fetch all the location from database and show in the view
        public JsonResult GetAllLocation()
        {
            using (Database1Entities2 dc = new Database1Entities2())
            {
                var v = dc.Location/*.OrderBy(a => a.Title)*/.ToList();
                return new JsonResult { Data = v, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            }
        }

        //3. GetMarkerInfo - for fetch location details from database for show marker in the map
        public JsonResult GetMarkerInfo(int locationID)
        {
            using (Database1Entities2 dc = new Database1Entities2())
            {
                Location l = null;
                l = dc.Location.Where(a => a.LocationID.Equals(locationID)).FirstOrDefault();
                return new JsonResult { Data = l, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
            }
        }

    }
}
