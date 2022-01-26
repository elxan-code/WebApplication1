using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.ViewComponents
{
    public class Uptitle : ViewComponent
    {
        private readonly AppDbContext _context;

        public Uptitle(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            Settings settings =  _context.Settings.FirstOrDefault();
            return View(settings);
        }


    }
}
