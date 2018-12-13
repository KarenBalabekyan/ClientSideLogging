using JavascriptLogger.NLog;
using System;
using System.Web.Mvc;

namespace JavascriptLogger.Controllers
{
    public class USER
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }

        public override string ToString()
        {
            return $"Name:{Name}, Age:{Age}, Phone:{Phone}";
        }
    }

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            #region logExample
            var u = new USER
            {
                Name = "Minas",
                Age = 45,
                Phone = "55804012"
            };

            Log.Instance.Info(u);
            Log.Instance.Error(new NullReferenceException("User is null"));
            Log.Instance.Warn("Warn");
            //Log.Instance.Fatal("Fatal");

            #endregion

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}