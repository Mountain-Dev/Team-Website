using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website.Models;

namespace Website.Controllers
{

    public class HomeController : Controller
    {
        private List<personData> personalDatas;

        public HomeController()
        {
            personalDatas = new List<personData>();
            personalDatas.Add(new personData() { title = "Felix", text = "Test Text Felix" });
            personalDatas.Add(new personData() { title = "Steven", text = "Test Text Steven" });
            personalDatas.Add(new personData() { title = "Alex", text = "Test Text Alex" });
            personalDatas.Add(new personData() { title = "Aleksei", text = "Test Text Aleksei" });
        }



        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View(personalDatas);
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}