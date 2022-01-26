using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Areas.admin.Controllers
{
    [Area("admin")]
    public class ProductsCategory : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ProductsCategory(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View(_context.Employees.Include(u=>u.Position).ToList());
        }

       
        public IActionResult Create()
        {
            ViewBag.Positions = _context.Positions.ToList();
            return View();

        }

        [HttpPost]
        public IActionResult Create(Employee model)
        {

            string fileName = Guid.NewGuid() + "-" + model.ImageFile.FileName;
            string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            model.ImageFile.CopyTo(stream);
                        }

                        model.Image = fileName;
                        
                        
                        _context.Employees.Add(model);
                        _context.SaveChanges();

                        return RedirectToAction("index");
                 
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            ViewBag.Positions = _context.Positions.ToList();
            return View(_context.Employees.Find(id));
        }
        [HttpPost]
        public IActionResult Update(Employee model)
        {
            string fileName = Guid.NewGuid() + "-" + model.ImageFile.FileName;
            string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                model.ImageFile.CopyTo(stream);
            }

            model.Image = fileName;


          

                _context.Employees.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
           
           


        }
        public IActionResult Delete(int id)
        {
            if (
                id == null)
            {
                return NotFound();
            }
            Employee category = _context.Employees.Find(id);
            _context.Employees.Remove(category);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }







    }

    }
