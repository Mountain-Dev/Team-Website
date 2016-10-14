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
            personalDatas.Add(new personData() { title = "Felix Wetell", phone = 30100000, mail = "felix.wetell@gmail.com", text = "I´m just a random guy that writes shit code!" });
            personalDatas.Add(new personData() { title = "Steven Bergqvist", phone = 0738518323, mail = "stevenbergqvist@gmail.com", text = "I'm 19 years old and studying programming. I am interested in all things tech and I hope to find a career in this field." });
            personalDatas.Add(new personData() { title = "Alex Söderberg", phone = 987654321, mail = "h1h2@hotmail.com", text = "Alex is a cooool guy." });
            personalDatas.Add(new personData() { title = "Aleksei Kazakov", phone = 123456789, mail = "cossack-hd@gmail.com", text = "Aleksei is a Russian elite hacker." });
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