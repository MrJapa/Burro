using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Classes
{
    public class Task
    {
        public int TaskId { get; set; }
        public string Name { get; set; }
        public List<ToDo> ToDo { get; } = new();
        public Task()
        {

        }
        public Task(string name)
        {
            Name = name;
        }
    }
}
