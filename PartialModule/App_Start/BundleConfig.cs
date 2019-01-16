using System.Web;
using System.Web.Optimization;

namespace PartialModule
{
    public class BundleConfig
    {
        // 有关捆绑的详细信息，请访问 https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
            // 生产准备就绪，请使用 https://modernizr.com 上的生成工具仅选择所需的测试。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js")
                      .Include("~/Scripts/bootstrap-table.js")
                      .Include("~/Scripts/bootstrap-table-filter.js")
                      .Include("~/Scripts/bootstrap-table-export.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));


            // 虚拟路径中，每个路径对应着将来浏览器里的JS文件夹路径
            //var b = new ScriptBundle("~/bundles/MyJs");
            //b.Include("~/Scripts/a.js", "~/Scripts/b.js");
            //bundles.Add(b);

            // 压缩JS文件，方式一，优先级高于方式二
            BundleTable.EnableOptimizations = true;

            // 压缩JS文件，方式二
            // 将Web.config 配置中的<compilation debug="false" targetFramework="4.6.1"/>
            // 方式一种的属性值，就是来源于配置文件的这个字段的配置
        }
    }
}
