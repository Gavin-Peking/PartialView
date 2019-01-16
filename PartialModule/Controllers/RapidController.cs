using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialModule.Controllers
{
    public class RapidController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 发布列表
        /// </summary>
        /// <returns></returns>
        public ActionResult ListToPublish()
        {
            var data = TempData["datas"] as List<string> ?? new List<string>();
            TempData["datas"] = data;
            return PartialView(data);
        }

        /// <summary>
        /// 发布列表数据的增删
        /// </summary>
        /// <param name="isAdd">true:增；false:删</param>
        /// <param name="datas"></param>
        /// <returns></returns>
        public JsonResult AddOrRemove(bool isAdd, List<string> datas = null)
        {
            var items = TempData["datas"] as List<string> ?? new List<string>();
            if (isAdd)
            {
                if (datas != null && datas.Count > 0)
                    items.AddRange(datas);
            }
            else
            {
                if (items.Count > 0)
                {
                    items.Remove(items.LastOrDefault());
                }
            }

            TempData["datas"] = items;
            return Json(new { result = true }, JsonRequestBehavior.AllowGet);
        }

        public JsonResult RemoveLast()
        {
            var datas = TempData["datas"] as List<string>??new List<string>();
            if(datas.Count>0)
            datas.RemoveAt(datas.Count - 1);

            TempData["datas"] = datas;
            return Json(new { result = datas});
        }

    }
}