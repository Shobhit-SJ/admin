using httpClient_call.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace httpClient_call.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Post()
        {
            //controller collecting data from model
            PostData postData = new PostData();
            ViewBag.PostData = postData.GetPostData(); 
            return View();
        }

        public IActionResult Comment()
        {
            //controller collecting data from model
            Comments commentData = new Comments();
            ViewBag.Comment = commentData.GetPostData();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}