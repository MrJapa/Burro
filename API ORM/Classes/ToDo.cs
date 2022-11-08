public class ToDo
{
    public int ToDoId { get; set; }
    public string Name { get; set; }
    public bool IsComplete { get; set; }
    public ToDo()
    {

    }
    public ToDo(string name)
    {
        Name = name;
    }
}