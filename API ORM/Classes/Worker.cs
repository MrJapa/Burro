using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager
{
    public class Worker
    {
        public int WorkerId { get; set; }
        public string Name { get; set; }
        public List<TeamWorker> Teams { get; } = new();
        public ToDo? CurrentTodo { get; set; }
        public List<ToDo> ToDos { get; set; } = new();
        public Worker()
        {

        }
        public Worker(string name)
        {
            Name = name;
        }
    }
}
