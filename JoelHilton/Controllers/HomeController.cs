using JoelHilton.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace JoelHilton.Controllers
{
    public class HomeController : Controller
    {
       
        private MovieAppContext _daContext { get; set; }
        public HomeController(MovieAppContext someName)
        {
            _daContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyPodcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Movies()
        {
            ViewBag.Category = _daContext.Categories.ToList();
            
            return View();
        }

        [HttpPost]
        public IActionResult Movies(ApplicationResponse ar)
        {
            if (ModelState.IsValid)
            {
                _daContext.Add(ar);
                _daContext.SaveChanges();

                return View("Confirmation", ar);
            }
            else//if invalid
            {
                ViewBag.Category = _daContext.Categories.ToList();

                return View();
            } 
                
        }

        public IActionResult MovieList ()
        {
            var applications = _daContext.Responses
                .Include(x => x.Category)
                //.Where(x => x.Edited == false)
                .OrderBy(x => x.Title)
                .ToList();


            return View(applications);
        }
        
        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Category = _daContext.Categories.ToList();

            var movie = _daContext.Responses.Single(x => x.MovieId == movieid);

            return View("Movies", movie);
        }
        [HttpPost]
        public IActionResult Edit(ApplicationResponse blah)
        {
            _daContext.Update(blah);
            _daContext.SaveChanges();

            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var movie = _daContext.Responses.Single(x => x.MovieId == movieid);

            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(ApplicationResponse ar)
        {
            _daContext.Responses.Remove(ar);
            _daContext.SaveChanges();

            return RedirectToAction("MovieList");
        }

    }
}
