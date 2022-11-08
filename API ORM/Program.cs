using Microsoft.EntityFrameworkCore;
using ProjectManager;
using Task = WebAPI.Classes.Task;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

public class ProjectContext : DbContext
{
    public DbSet<Task> Tasks { get; set; }
    public DbSet<ToDo> ToDo { get; set; }
    public DbSet<Team>? Team { get; set; }
    public DbSet<Worker>? Worker { get; set; }
    public DbSet<TeamWorker>? TeamWorker { get; set; }



    public string DbPath { get; }

    public ProjectContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "ProjectManagers.db");
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Task>()
            .HasKey(p => new { p.TaskId});

        modelBuilder.Entity<TeamWorker>()
            .HasKey(p => new { p.TeamId, p.WorkerId });

        modelBuilder.Entity<Team>()
            .HasOne(team => team.CurrentTask);

        modelBuilder.Entity<Worker>()
            .HasOne(team => team.CurrentTodo);

    }
}