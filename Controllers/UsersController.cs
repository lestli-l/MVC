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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using Microsoft.AspNetCore.Identity;

namespace Manage_core.Controllers
{ 
    public class UsersController : Controller
    {
       private readonly UserContext _context;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        public UsersController(
        SignInManager<IdentityUser> signInManager,
        UserManager<IdentityUser> userManager,
        UserContext context
        )
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _context = context;
        }

        // GET: Users
        
        public async Task<IActionResult> Login()
        {
         
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(User user)
        {

            var use = await _userManager.FindByNameAsync(user.UserName);
            if (use != null) {
                var result = _signInManager.PasswordSignInAsync(use, user.PassWord, false, false);
                if(result.Result.Succeeded){
                    return View("/Views/Menu/HomePage.cshtml");
                }
            }
            ModelState.AddModelError("", "用户名或密码不正确");
            return View(user);
        }
       
        public IActionResult Register(){
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(User user)
        {
            if(ModelState.IsValid){
                var use = new IdentityUser { UserName = user.UserName };
                var result = await _userManager.CreateAsync(use, user.PassWord);
                if(result.Succeeded){
                    return RedirectToAction("Login", "Users");
                }
            }
            return View(user);
        }
    }
    }
