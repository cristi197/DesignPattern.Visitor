# DesignPattern.Visitor

## Introduction to the Visitor Pattern

The Visitor pattern is a behavioral design pattern that allows you to add new functionality to existing object structures without modifying those structures. It's particularly useful when you have a set of classes that you want to operate on, and you need to perform different operations on them depending on their types.

### Key Concepts

- **Element**: The interface that defines an `Accept` method to receive a visitor
- **ConcreteElement**: Concrete implementations of elements that accept visitors
- **Visitor**: The interface that defines visit methods for each concrete element type
- **ConcreteVisitor**: Concrete implementations that define the actual operations to perform on elements

## Zoo Example Implementation

This project demonstrates the Visitor pattern using a **zoo scenario**:

### The Problem
A zoo has different animals (like lions and zebras) and various visitors (like a veterinarian and a zoo staff member). We need to perform different operations on these animals depending on who is visiting them, without cluttering the animal classes with visitor-specific logic.

### The Solution
- **Elements**: 
  - `ConcreteElement1` represents a **Lion**
  - `ConcreteElement2` represents a **Zebra**
  
- **Visitors**:
  - `ConcreteVisitor1` represents a **Veterinarian (Vet)** - examines and treats animals
  - `ConcreteVisitor2` represents a **Zoo Staff Member** - performs general care and management tasks

### How It Works

Each animal (lion, zebra) can accept a visitor through the `Accept` method. When a visitor arrives, the animal knows what the visitor does:
- The **Vet** performs medical operations (examinations, treatments)
- The **Zoo Staff Member** performs general care operations (feeding, cleaning)

By using the Visitor pattern, we can easily add new types of visitors without modifying the animal classes. For example, if we need a veterinary trainer or a zoo educator, we can simply create new visitor implementations.

## Project Structure

```
Visitor.Design.Patter/
├── Element.cs           # Base interface for elements (animals)
├── ConcreteElement1.cs  # Lion implementation
├── ConcreteElement2.cs  # Zebra implementation
├── Visitor.cs           # Base interface for visitors
├── ConcreteVisitor1.cs  # Veterinarian implementation
├── ConcreteVisitor2.cs  # Zoo staff member implementation
└── Program.cs           # Demo application - client
```

## Usage

The pattern allows you to define operations on animals dynamically:

```csharp
// Create animals
Element lion = new ConcreteElement1();
Element zebra = new ConcreteElement2();

// Create visitors
Visitor vet = new ConcreteVisitor1();
Visitor staffMember = new ConcreteVisitor2();

// Animals accept visitors
lion.Accept(vet);      // Vet examines the lion
zebra.Accept(vet);     // Vet examines the zebra
lion.Accept(staffMember);  // Staff member cares for the lion
```

## Benefits

- **Separation of Concerns**: Animal logic is separate from visitor logic
- **Easy Extension**: Add new visitor types without modifying existing code
- **Type-Safe**: Visitor methods are specific to element types
- **Flexible Operations**: Different operations can be performed on the same objects

## Target Framework

- **.NET 10**
- **C# 14.0**
