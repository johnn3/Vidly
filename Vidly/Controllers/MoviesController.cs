using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Name = "MortalKombat"
            };
            return View(movie);
        }

        //GET: Movies/Edit/id
        //displays id = "id" on the new screen
        //can also query string this now via edit?id=1
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        //in this call, we can request all movies in the database
        //defaults to page 1 if no index is passed)
        //if no sortBy is passed through, then we sort by the movies by 
        //their name automatically
        //to make a parameter optional, we must first make it nullable
        //this is implied via a "?" beside the datatype
        //string types are a reference type in C# and are therefore nullable automatically
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            //for the purpose of this demo
            return Content(String.Format("pageIndex={0} sortby={1}", pageIndex, sortBy));
        }
    }
}