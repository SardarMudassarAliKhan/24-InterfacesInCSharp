In C#, an interface is a reference type that defines a contract for other classes to implement. It contains only the declaration of the methods, properties, events, or indexers, but not the implementation.

Here's a basic example of an interface in C#:

```csharp
interface IExampleInterface
{
    // Method declaration
    void SomeMethod();

    // Property declaration
    int SomeProperty { get; set; }

    // Event declaration
    event EventHandler SomeEvent;

    // Indexer declaration
    string this[int index] { get; set; }
}
```

To implement an interface in a class, you use the `: interfaceName` notation after the class name. For example:

```csharp
class ExampleClass : IExampleInterface
{
    // Implementing the SomeMethod defined in the interface
    public void SomeMethod()
    {
        Console.WriteLine("SomeMethod implementation");
    }

    // Implementing the SomeProperty defined in the interface
    public int SomeProperty { get; set; }

    // Implementing the SomeEvent defined in the interface
    public event EventHandler SomeEvent;

    // Implementing the indexer defined in the interface
    private string[] array = new string[10];
    public string this[int index]
    {
        get => array[index];
        set => array[index] = value;
    }
}
```

A class can implement multiple interfaces by separating them with commas:

```csharp
class MyClass : IInterface1, IInterface2
{
    // Implementation of interface members
}
```

Interfaces are commonly used to achieve abstraction, multiple inheritance, and polymorphism in C#. They allow for defining a contract that multiple classes can adhere to while allowing each class to provide its own implementation.
