﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Areas.admin.Controllers
{
    [Area("admin")]
    public class AccountController : Controller
    {
        //private readonly AppDbContext _context;
        //private readonly UserManager<IdentityUser> _userManager;
        //private readonly SignInManager<IdentityUser> _signInManager;

        //public AccountController(AppDbContext context, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        //{
        //    _context = context;
        //    _userManager = userManager;
        //    _signInManager = signInManager;
        //}

        public IActionResult Login()
        {
            return View();
        }
        //[HttpPost]
        //public async Task<IActionResult> Login(VmLogin model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var result = await _signInManager.PasswordSignInAsync(model., model.Password, false, false);

        //        if (result.Succeeded)
        //        {
        //            return RedirectToAction("index", "home");
        //        }
        //        else
        //        {
        //            ModelState.AddModelError("", "Email or password is not valid");
        //            return View(model);
        //        }
        //    }
        //    return View(model);
        //}


        public IActionResult Register()
        {
            return View();
        }
        ////[HttpPost]
        ////public async Task<IActionResult> Register(VmRegister model)
        ////{
        ////    if (ModelState.IsValid)
        ////    {
        ////        CustomUser user = new CustomUser()
        ////        {
        ////            FullName = model.FullName,
        ////            Email = model.Email,
        ////            UserName = model.Email,
                    
        ////        };

        ////        var result = await _userManager.CreateAsync(user, model.Password);
        ////        if (result.Succeeded)
        ////        {
        ////            await _signInManager.SignInAsync(user, false);
        ////            return RedirectToAction("index", "home");
        ////        }
        ////        else
        ////        {
        ////            foreach (var error in result.Errors)
        ////            {
        ////                ModelState.AddModelError("", error.Description);
        ////            }
        ////            return View(model);
        ////        }

        ////    }
        //    return View(model);
        //}



    }
}
