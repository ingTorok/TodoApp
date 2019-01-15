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
        public ActionResult Create(string name, bool isDone)
        {
            if(!string.IsNullOrEmpty(name))
            {//if there is data
                //save data and go back to Index
                var maxId = MyDb.Lista.Max(x => x.Id);
                MyDb.Lista.Add(new TodoItem() {Id = maxId + 1, Name = name, Done = isDone });

                return RedirectToAction("Index");
            }
            
            //
            return View();
        }

        /// <summary>
        /// The action will show the edited item
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Edit(int id)
        {
            //MyDb.Lista.Where(x=>x.Id==id); //- this return a list

            var item = MyDb.Lista.Single(x => x.Id == id); // - this return only if exist 1 and not more or less, otherweise will return an exepeption

            //var item = MyDb.Lista.SingleOrDefault(x => x.Id == id); // - if there is no id then return null

            return View(item);
        }

        [HttpPost]
        public ActionResult Edit(int id, string name, bool done)
        {
            var item = MyDb.Lista.Single(x => x.Id == id);
            item.Name = name;
            item.Done = done;

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var item = MyDb.Lista.Single(x => x.Id == id);
            return View(item);
        }

        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
            var item = MyDb.Lista.Single(x => x.Id == id);
            MyDb.Lista.Remove(item);

            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            var item = MyDb.Lista.Single(x => x.Id == id);
            return View(item);
        }

    }
}