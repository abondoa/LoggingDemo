using NLog;
using System.Web.Mvc;

namespace LoggingDemo.Controllers
{
    public class HomeController : Controller
    {
        private static ILogger _log => LogManager.GetCurrentClassLogger();

        public ActionResult Index()
        {
            _log.Debug("Entered the Home Controller Index Action.");

            return View();
        }

        public ActionResult About()
        {
            _log.Debug("Entered the Home Controller About Action.");

            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            _log.Debug("Entered the Home Controller Contact Action.");

            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}