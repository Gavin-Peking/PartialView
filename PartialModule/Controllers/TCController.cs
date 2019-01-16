using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialModule.Controllers
{
    public class TCController : Controller
    {
        // GET: TC 统采数据
        //[ChildActionOnly]
        public ActionResult Index()
        {
            return PartialView();
        }
    }
}