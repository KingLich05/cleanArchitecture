namespace ConsoleApp1;

public class User
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Age { get; set; }
    public virtual ICollection<Book> Books { get; set; }
}