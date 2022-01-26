using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
  
        public class AccController : Controller
        {
            private readonly AppDbContext _context;
            private readonly UserManager<CustomUser> _userManager;
            private readonly SignInManager<CustomUser> _signInManager;

            public AccController(AppDbContext context, UserManager<CustomUser> userManager, SignInManager<CustomUser> signInManager)
            {
                _context = context;
                _userManager = userManager;
                _signInManager = signInManager;
            }
            public IActionResult Register()
            {
                return View();
            }

            [HttpPost]
            public async Task<IActionResult> Register(VmRegister model)
            {
                if (ModelState.IsValid)
                {
                    CustomUser user = new CustomUser()
                    {
                        FullName = model.FullName,
                        UserName = model.Username,
                        Email = model.Username


                    };

                    var result = await _userManager.CreateAsync(user, model.Password);
                    if (result.Succeeded)
                    {
                        await _signInManager.SignInAsync(user, false);
                        return RedirectToAction("index", "home");
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError("", error.Description);
                        }
                        return View(model);
                    }

                }
                return View(model);
            }
            public IActionResult Login()
            {
                return View();
            }
            [HttpPost]
            public async Task<IActionResult> Login(VmRegister model)
            {
                if (ModelState.IsValid)
                {
                    var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("index", "home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Email or password is not valid");
                        return View(model);
                    }
                }
                return View(model);
            }


            public async Task<IActionResult> Logout()
            {
                await _signInManager.SignOutAsync();
                return RedirectToAction("login");
            }
        }
    }


