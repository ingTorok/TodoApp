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
        private List<TodoItem> lista = new List<TodoItem>
         {
            new TodoItem() { Name = "Só", Done = true },
            new TodoItem() { Name = "Cukor", Done = true },
            new TodoItem() { Name = "Spagetti", Done = true },
            new TodoItem() { Name = "Marhahús", Done = false },
            new TodoItem() { Name = "Paradicsom", Done = false }
         };

        public ActionResult Index()
        {           
            return View(lista); 
        }

        public ActionResult Create(string Todo)
        {
            if(!string.IsNullOrEmpty(Todo))
            {//if there is data
                //save data and go back to Index

                lista.Add(new TodoItem() { Name = Todo, Done = true });

                return RedirectToAction("Index");
            }
            
            //
            return View();
        }


    }
}