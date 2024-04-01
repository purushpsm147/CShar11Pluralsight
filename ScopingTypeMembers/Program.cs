// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var person = new Person { Name = "John", Age = 30 };
person.Age = 31;
class Person
{
    public required string Name { get; init; } = string.Empty;
    public required int Age { get; set; }
}
