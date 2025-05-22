namespace LibraryManagementSystem;
internal class Book
{
    public string Name { get; set; } = "Unknown";
    public int Pages { get; set; } = 0;

    internal Book()
    {
        Name = "Unkown";
        Pages = 0;
    }
    internal Book(int pages)
    {
        Name = "Unknown";
        Pages = pages;
        Console.WriteLine($"Name: {Name}, Pages = {Pages}");
    }

    internal Book(string name, int pages)
    {
        Name = name;
        Pages = pages;
        Console.WriteLine($"Name: {Name}, Pages = {Pages}");
    }
}
