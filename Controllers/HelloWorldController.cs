﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            //return "This is my <b>default</b> action...";
            return View();
        }

        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;
            return View();
        }

        //public string Welcome()
        //{
        //    return "This is the welcome action method...";
        //}

        /*
         * public string Welcome(string name, int numTimes = 1)
         
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", NumTimes is: " + numTimes);
        }
        */
        /*
        public string Welcome(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello" + name + ", ID: " + ID);
        }
        */
    }
}