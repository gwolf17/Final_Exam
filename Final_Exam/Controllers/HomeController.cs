using Final_Exam.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Exam.Controllers
{
    public class HomeController : Controller
    {
        //Bring in the repositories
        private IQuoteRepository _repo { get; set; }

        //Constructor
        public HomeController(IQuoteRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index()
        {
            var data = _repo.Quotes
                .OrderBy(x => x.Author)
                .ToList();  //Gather the data in the database

            return View(data);
        }

        //Details page
        public IActionResult Details(int quoteid)
        {
            var data = _repo.Quotes.Single(x => x.QuoteID == quoteid);

            return View(data);
        }

        //Edit Functionality
        [HttpGet]
        public IActionResult Edit(int quoteid)
        {
            var data = _repo.Quotes.Single(x => x.QuoteID == quoteid);

            return View(data);
        }

        [HttpPost]
        public IActionResult Edit(Quote q)
        {
            //Call edit method in the repository
            _repo.EditQuote(q);

            return RedirectToAction("Index");
        }

        //Create functionality
        [HttpGet]
        public IActionResult Add()
        {
            //PAss in a new Quote object
            return View(new Quote());
        }

        [HttpPost]
        public IActionResult Add(Quote q)
        {
            //Call Create repository method
            _repo.AddQuote(q);

            return RedirectToAction("Index");
        }

        //Delete functionality
        public IActionResult Delete(int quoteid)
        {
            var q = _repo.Quotes.Where(x => x.QuoteID == quoteid).FirstOrDefault();
            //Call repository delete method
            _repo.DeleteQuote(q);

            return RedirectToAction("Index");
        }
    }
}
