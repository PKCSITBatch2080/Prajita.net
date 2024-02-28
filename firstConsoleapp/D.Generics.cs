using System;
class Generics
{
    public T  Display<T>(T value)
    {
        Console.WriteLine($"values (value)");
        return value;
    }
}