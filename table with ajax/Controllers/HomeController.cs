using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using table_with_ajax.Models;

namespace table_with_ajax.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDBContext _appDBContext;

        public HomeController(AppDBContext appDBContext)
        {
            _appDBContext = appDBContext;
        }



        public async Task<IActionResult> Index()
        {
           
            return View();
        }



        public JsonResult getAllUsers()
        {

            List<User> users = new List<User>();
            users = _appDBContext.users.Select(c => c).ToList();    

            return Json(new { data = users });
        }

        public List<User> getUsers()
        {
            List<User> users = new List<User>();

            users = _appDBContext.users.Select(c=>c).ToList();
            return users;
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
