using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TodoApp.Models;

namespace TodoApp.Controllers
{
    public class TodoController : Controller
    {
        public ActionResult Index()
        {           
            return View(MyDb.Lista); 
        }

        [HttpGet] //only at GET will be here routed
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost] //only the POST will be here routed
        public ActionResult Create(string Todo)
        {
            if(!string.IsNullOrEmpty(Todo))
            {//if there is data
                //save data and go back to Index

                MyDb.Lista.Add(new TodoItem() { Name = Todo, Done = true });

                return RedirectToAction("Index");
            }
            
            //
            return View();
        }


    }
}