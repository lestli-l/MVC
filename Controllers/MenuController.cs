using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Manage_core.Data;
using Manage_core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Manage_core.Controllers
{
    public class MenuController : Controller
    {
        private readonly UserContext _context;
       
        public MenuController( UserContext context )
        {
        
            _context = context;
        }
        public async Task<IActionResult> Creat()
        {
           
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Creat(Personal personal)
        {
             if(ModelState.IsValid){
                _context.Personal.Add(personal);
               await _context.SaveChangesAsync();
             } 
            return View();
        }
        public IActionResult Delete(string? identitycard){
          
            return View();
        }
        public async Task<IActionResult> Edit(string? identitycard)
        {
            if (identitycard == null)
            {
                return NotFound();
            }

            var person = await _context.Personal.FindAsync(identitycard);
            person.Employee= await _context.Employee.FindAsync(person.WorkNumber);
            
            if (person == null)
            {
                return NotFound();
            }
            return View(person);
           
        }
        //[HttpPost]
        //public async Task<IActionResult> Edit(){
           
        //}
        public async Task<IActionResult> List()
        {
            var model = await _context.Personal.ToListAsync();
            return View(model ) ;
        }
    }
}