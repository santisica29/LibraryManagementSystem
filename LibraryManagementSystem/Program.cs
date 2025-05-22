using LibraryManagementSystem;

//UserInterface userInterface = new();
//userInterface.MainMenu();

Animal myDog = new Dog("Lonzo", 5);
Animal myCat = new Cat("Olga", 4);

myDog.MakeSound();
myCat.MakeSound();
internal abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    protected Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }

    // Abstract method that must be implemented by derived classes
    public abstract void MakeSound();
}

internal class Dog : Animal
{
    public Dog(string name, int age)
        : base(name, age)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says: Woof!");
    }
}

internal class Cat : Animal
{
    public Cat(string name, int age)
        : base(name, age) // Calling the base class constructor
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} says: Meow!");
    }
}



