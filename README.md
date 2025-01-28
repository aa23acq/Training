# Training Project

## Overview

This project demonstrates various design patterns implemented in C# using .NET 8. The project includes examples of Creational, Structural, and Behavioral design patterns.

## Design Patterns Implemented

### Creational Design Patterns
1. **Singleton**
2. **Factory**
3. **Abstract Factory**
4. **Builder**
5. **Prototype**

### Structural Design Patterns
1. **Adapter**
2. **Decorator**
3. **Facade**
4. **Proxy**

### Behavioral Design Patterns
1. **Chain of Responsibility**
2. **Observer**
3. **Strategy**
4. **Command**

## Project Structure

- **Training.csproj**: Project file containing project configuration.
- **Prototype.cs**: Contains classes demonstrating the Prototype design pattern.
- **Program.cs**: Entry point of the application, demonstrating usage of various design patterns.
- **Shape.cs**: Contains shape classes implementing the `IShape` interface.

## How to Run

1. Open the solution in Visual Studio 2022.
2. Build the solution to restore dependencies and compile the project.
3. Run the project to see the output in the console.

## Example Usage

### Prototype Pattern
```csharp
var circle = new Circle(5); Console.WriteLine($"Area of Circle: {circle.Area()}"); Console.WriteLine($"Perimeter of Circle: {circle.Perimeter()}");
var square = new Square(5); Console.WriteLine($"Area of Square: {square.Area()}"); Console.WriteLine($"Perimeter of Square: {square.Perimeter()}");
var rectangle = new Rectangle(5, 10); Console.WriteLine($"Area of Rectangle: {rectangle.Area()}"); Console.WriteLine($"Perimeter of Rectangle: {rectangle.Perimeter()}");
```


## Requirements

- Visual Studio 2022
- .NET 8 SDK

## License

This project is licensed under the MIT License. See the LICENSE file for details.

---

Feel free to explore the code and modify it to understand the design patterns better. Happy coding! 