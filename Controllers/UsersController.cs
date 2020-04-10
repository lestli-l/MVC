using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Manage_core.Data;
using Manage_core.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;

using Microsoft.AspNetCore.Authentication.Cookies;

using Microsoft.AspNetCore.Authorization;



namespace Manage_core.Controllers
{ 
    public class UsersController : Controller
    {
        private readonly UserContext _context;

        public UsersController(UserContext context)
        {
            _context = context;
        }

        // GET: Users
        public async Task<IActionResult> Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(string name,string password){
            if (name.Equals("admin@q") && password.Equals("123456"))

            {

                var claims = new List<Claim>(){

         new Claim(ClaimTypes.Name,name),new Claim("password",password)

};

                var userPrincipal = new ClaimsPrincipal(new ClaimsIdentity(claims, "Customer"));

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, userPrincipal, new AuthenticationProperties

                {

                    ExpiresUtc = DateTime.UtcNow.AddMinutes(20),

                    IsPersistent = false,

                    AllowRefresh = false

                });
               var user= await _context.User.ToListAsync();
                return View("Index",user);

            }

            return Json(new { result = false, msg = "用户名密码错误!" });


        }

    }
}
