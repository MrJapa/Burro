using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Classes;
using Task = WebAPI.Classes.Task;

namespace ProjectManager
{
    public class Team
    {
        public int TeamId { get; set; }
        public string Name { get; set; }
        public List<TeamWorker> Workers { get; } = new();
        public Task? CurrentTask { get; set; }
        public List<Task> Tasks { get; set; } = new();
        public Team()
        {

        }
        public Team(string name)
        {
            Name = name;
        }
    }
}
