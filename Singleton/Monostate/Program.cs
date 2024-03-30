using System;
using static System.Console;

var ceo = new Ceo();
ceo.Name = "Court Jennings";
ceo.Age = 55;

var ceo2 = new Ceo();

WriteLine(ceo2);

public class Ceo
{
    // Mono-state utilizes static fields and properties to have a single point of storage for state
    private static string name;
    private static int age;

    public string Name
    {
        get => name;
        set => name = value;
    }

    public int Age
    {
        get => age;
        set => age = value;
    }

    public override string ToString()
    {
        return $"{nameof(Name)}: {Name}, {nameof(Age)}: {Age}";
    }
}