using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webAppDemo.Models;

namespace webAppDemo.Controllers
{
    public class UsersController : Controller
    {
        public async Task<IActionResult> Index(string searchString = "")
        {
            IEnumerable<Users> users = new List<Users>();
            try
            {
                users = await Users.GetAsync(searchString);
                return View(users);
            }
            catch (Exception ex)
            {
                ViewData["error"] = ex.Message;
                return View(users);
            }
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}