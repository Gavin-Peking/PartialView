using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialModule.Controllers
{
    public class ZCController : Controller
    {
        // GET: ZC 自采数据,后期需要改为外界不可直接访问
        /// <summary>
        /// 自采数据首页
        /// </summary>
        /// <param name="from">请求来源</param>
        /// <param name="data">自定义的用于显示目标数据的结构体</param>
        /// <returns></returns>
        [HttpPost]
        
        public ActionResult Index(string from, object data = null)
        {
            ViewBag.From = from;
            ViewBag.Data = data;
            ViewBag.Test = "admin Tests";
            return PartialView();
        }
    }
}