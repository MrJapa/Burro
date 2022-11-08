using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Task = WebAPI.Classes.Task;

namespace WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class TodoController : ControllerBase
{

    private readonly ILogger<TodoController> _logger;

    public TodoController(ILogger<TodoController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetTask")]
    public IEnumerable<Task> GetAll()
    {
        using (ProjectContext context = new ProjectContext())
        {
            return context.Tasks.ToList();
        }
    }

    [HttpGet("{id}")]
    public Task Get(int id)
    {
        using (ProjectContext context = new ProjectContext())
        {
            return context.Tasks.FirstOrDefault(m => m.TaskId == id);
        }
    }
}
