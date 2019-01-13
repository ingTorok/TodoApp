﻿using System;
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
            var lista = new List<TodoItem>();

            lista.Add(new TodoItem() { Name = "Só", Done = true });
            lista.Add(new TodoItem() { Name = "Cukor", Done = true });
            lista.Add(new TodoItem() { Name = "Spagetti", Done = true });
            lista.Add(new TodoItem() { Name = "Marhahús", Done = false });
            lista.Add(new TodoItem() { Name = "Paradicsom", Done = false });

            return View(lista); 
        }

        public ActionResult Create(string Todo)
        {
            if(!string.IsNullOrEmpty(Todo))
            {//if there is data
                //save data and go back to Index
                return RedirectToAction("Index");
            }
            
            //
            return View();
        }


    }
}