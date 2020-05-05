using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Manage_core.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Creat()
        {
            return View();
        }
        public IActionResult Delete(){
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult List()
        {
            return View();
        }
    }
}