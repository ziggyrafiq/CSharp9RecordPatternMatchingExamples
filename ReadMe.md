# C# 9 Record and Pattern Matching Examples

## Overview
This repository contains examples demonstrating the usage of C# 9 features such as Records and Pattern Matching. The code showcases how to write concise and readable C# code using these powerful language features.

*  [This Repo Article by Ziggy Rafiq is on C# Corner](https://www.c-sharpcorner.com/article/record-and-pattern-matching-in-c-sharp-9-writing-c-sharp-code-that-is-concise-and-readabl/).

## Project Structure

### 1. `PatternMatching.Models` Namespace
   - `Shape` class representing a simple geometric shape with width and height properties.

### 2. `PatternMatching` Namespace
   - `ShapeInfo` static class with a method for obtaining a textual description of a given shape.

### 3. `Data` Class
   - Contains examples illustrating the use of C# 9 features.

## Examples

### Immutable by Default - `Data.Person` Record
```csharp
var person1 = new Person("John", "Doe");
var person2 = new Person("John", "Doe");

if (person1 == person2)
{
    Console.WriteLine("Both persons are equal.");
}

var person = new Person("Jane", "Doe");
var (firstName, lastName) = person;
Console.WriteLine($"First Name: {firstName}, Last Name: {lastName}");
``` 

### Type Patterns - Data.GetDisplayText Method
```csharp
string strExample = "I am Ziggy Rafiq!";
int intExample = 32;
DateTime dateTimeExample = DateTime.Now;
double doubleExample = 3.14;
bool boolExample = true;

Console.WriteLine(GetDisplayText(strExample));
Console.WriteLine(GetDisplayText(intExample));
Console.WriteLine(GetDisplayText(dateTimeExample));
Console.WriteLine(GetDisplayText(doubleExample));
Console.WriteLine(GetDisplayText(boolExample));
```

### Property Patterns - ShapeInfo.GetShapeDescription Method
```csharp
// Example 1: Point
Shape point = new Shape { Width = 0, Height = 0 };
Console.WriteLine(ShapeInfo.GetShapeDescription(point));  // Output: Point

// Example 2: Square
Shape square = new Shape { Width = 5, Height = 5 };
Console.WriteLine(ShapeInfo.GetShapeDescription(square));  // Output: Square with side 5

// Example 3: Rectangle
Shape rectangle = new Shape { Width = 3, Height = 7 };
Console.WriteLine(ShapeInfo.GetShapeDescription(rectangle));  // Output: Rectangle with width 3 and height 7

// Example 4: Unknown Shape
Shape unknownShape = new Shape { Width = 2, Height = 4 };
Console.WriteLine(ShapeInfo.GetShapeDescription(unknownShape));  // Output: Unknown Shape
```

## About The Author Ziggy Rafiq 
- **Technical Lead Developer, C# Corner (MVP 🏅, VIP⭐️, Public Speaker🎤), Mentor, and Trainer**
- **C# Corner MVP, VIP, Speaker, Chapter Lead UK**
- Mentor and Trainer with solid experience in System Architecture for over 19 years
- Link to [**Ziggy Rafiq Blog**](https://blog.ziggyrafiq.com)
- Link to [**Ziggy Rafiq Website**](https://ziggyrafiq.com)
* [**Please remember to subscribe to My YouTube channel**](https://www.youtube.com/)
* [**Please remember to follow me on LinkedIn**](https://www.linkedin.com/in/ziggyrafiq/)
* [**Please remember to connect with me on C# Corner**](https://www.c-sharpcorner.com/members/ziggy-rafiq)
* [**Please remember to follow  me on Twitter/X**](https://twitter.com/ziggyrafiq)
* [**Please remember to follow  me on Instagram**](https://www.instagram.com/ziggyrafiq/)
* [**Please remember to follow  me on Facebook**](https://www.facebook.com/ziggyrafiq)

Ziggy Rafiq is the author and creator of this repository. He is a C# Corner MVP Award recipient in 2023, with over 20 years of technical experience using Microsoft technologies and tools. Ziggy has earned various other awards in the past for his contributions to the tech community.

Please note that these examples are simplified for demonstration purposes. In real-world applications, additional security measures and best practices may be required. It is essential to adapt these practices to the specific requirements and security needs of your application.

We hope these code examples serve as a useful reference for maintaining security in your C# applications. Should you have any questions or feedback, please feel free to reach out.

**Happy and Secure Coding!**
