# Factory Method Example
Factory method is a creational design pattern which solves the problem of creating product objects without specifying their concrete classes.
Factory Method defines a method, which should be used for creating objects instead of direct constructor call (new operator). 
Subclasses can override this method to change the class of objects that will be created.

## Usage examples
The Factory Method pattern is widely used in C# code. It’s very useful when you need to provide a high level of flexibility for your code.

## Identification
* Factory methods can be recognized by creation methods, which create objects from concrete classes, but return them as objects of abstract type or interface.
* Use the Factory Method when you want to provide users of your library or framework with a way to extend its internal components.
* Use the Factory Method when you want to save system resources by reusing existing objects instead of rebuilding them each time.

## Applicability
Use the Factory Method when you don’t know beforehand the exact types and dependencies of the objects your code should work with.

## Getting Started

### Prerequisites

[.NET Core 3.1 SDK or later](https://dotnet.microsoft.com/download/dotnet-core/3.1)