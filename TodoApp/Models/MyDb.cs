﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TodoApp.Models
{
    public class MyDb
    {
        public static List<TodoItem> Lista = new List<TodoItem>
         {
            new TodoItem() { Id=1, Name = "Só", Done = true },
            new TodoItem() { Id=2, Name = "Cukor", Done = true },
            new TodoItem() { Id=3, Name = "Spagetti", Done = true },
            new TodoItem() { Id=4, Name = "Marhahús", Done = false },
            new TodoItem() { Id=5, Name = "Paradicsom", Done = false }
         };
    }
}