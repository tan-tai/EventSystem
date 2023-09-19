using System;
using System.Text.Json;

class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        // Create an instance of the Person class.
        Person originalPerson = new Person
        {
            Name = "Enzo",
            Age = 23
        };

        // Serialize the Person object to JSON format.
        string json = JsonSerializer.Serialize(originalPerson);

        Console.WriteLine("Serialized JSON:");
        Console.WriteLine(json);

        // Deserialize the JSON back to a Person object.
        Person deserializedPerson = JsonSerializer.Deserialize<Person>(json);

        Console.WriteLine("\nDeserialized Object:");
        Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
    }
}

