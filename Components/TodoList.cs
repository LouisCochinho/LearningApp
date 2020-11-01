using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList.Models;

namespace TodoList.Components
{
	public partial class TodoList: ComponentBase
	{
        public IList<TodoItem> Todos = new List<TodoItem>();
        public string NewTodo { get; set; }

        public void AddTodo()
        {
            if (!string.IsNullOrWhiteSpace(NewTodo))
            {
                Todos.Add(new TodoItem { Title = NewTodo });
                NewTodo = string.Empty;
            }
        }
    }
}
