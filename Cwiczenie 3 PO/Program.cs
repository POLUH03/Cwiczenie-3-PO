using System;

public class Employee
{
    protected string name;
    protected string lastname;
    protected string street;
    protected string city;

    public virtual void read()
    {
        Console.WriteLine("Wprowadź dane pracownika:");
        Console.Write("Imię: ");
        name = Console.ReadLine();
        Console.Write("Nazwisko: ");
        lastname = Console.ReadLine();
        Console.Write("Ulica: ");
        street = Console.ReadLine();
        Console.Write("Miasto: ");
        city = Console.ReadLine();
    }

    public virtual void show()
    {
        Console.WriteLine("\nDane pracownika:");
        Console.WriteLine($"Imię: {name}");
        Console.WriteLine($"Nazwisko: {lastname}");
        Console.WriteLine($"Ulica: {street}");
        Console.WriteLine($"Miasto: {city}");
    }
}

public class HR : Employee
{
    private string education;
    private string businessRole;

    public void read1()
    {
        base.read();
        Console.Write("Wykształcenie: ");
        education = Console.ReadLine();
        Console.Write("Rola biznesowa: ");
        businessRole = Console.ReadLine();
    }

    public void show1()
    {
        base.show();
        Console.WriteLine($"Wykształcenie: {education}");
        Console.WriteLine($"Zawód:: {businessRole}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        HR hrEmployee = new HR();
        hrEmployee.read1();
        hrEmployee.show1();

        Console.ReadLine(); // Aby konsola nie zamknęła się od razu
    }
}