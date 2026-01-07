# DesignPattern.Visitor

## Hey! 👋 Welcome to My Visitor Pattern Showcase

I wanted to explore the **Visitor design pattern** with 2 different real-world representations. Both show how to perform operations on objects without changing the objects themselves.

## What's the Visitor Pattern?

The Visitor pattern lets you add operations to objects without modifying them. Each visitor does something different when it "visits" an element.

**Key Players:**
- **Element**: Accepts visitors via `Accept` method
- **Visitor**: Defines operations for different element types
- **The Magic**: New operations = new Visitor classes (no element changes!)

---

## Double Dispatch: The Secret Sauce 🎯

The Visitor pattern relies on **double dispatch** - a fancy term for something simple:

1. **First dispatch**: Call `element.Accept(visitor)` - the runtime knows which element type you have
2. **Second dispatch**: The element calls `visitor.Visit(this)` - the runtime now knows which visitor type it is

This two-step process lets the right method get called for the right combination of element + visitor!

**Where It's Used:**
- Determining which `ConcreteVisitor` method to execute based on the element type
- In `TextDocumentVisitor.Visit(TitleElement)` vs `TextDocumentVisitor.Visit(ContentElement)` - same visitor, different element = different behavior!

---

## Example 1: 🦁 Zoo (VisitorDesignPattern)

**The Idea**: Lions and zebras (elements) receive visits from a vet and staff member (visitors).

```
VisitorDesignPattern/
├── Element.cs              # Base interface
├── ConcreteElement1.cs     # Lion
├── ConcreteElement2.cs     # Zebra
├── Visitor.cs              # Base interface
├── ConcreteVisitor1.cs     # Veterinarian
├── ConcreteVisitor2.cs     # Zoo Staff
└── Program.cs
```

**Quick Example:**
```csharp
Element lion = new ConcreteElement1();
Visitor vet = new ConcreteVisitor1();
lion.Accept(vet);  // Vet examines the lion
```

---

## Example 2: 📄 Document Formatting (VisitorDesignPatternDocExample)

**The Idea**: Document elements (title, subtitle, content) get rendered in different formats (text, markdown).

```
VisitorDesignPatternDocExample/
├── IDocumentElement.cs          # Base interface
├── TitleElement.cs, SubtitleElement.cs, ContentElement.cs
├── IDocumentVisitor.cs          # Base interface
├── TextDocumentVisitor.cs       # Renders as text
├── MarkdownDocumentVisitor.cs   # Renders as markdown
└── Program.cs
```

**Quick Example:**
```csharp
List<IDocumentElement> elements = [
    new TitleElement("Hello"),
    new ContentElement("World")
];

var textVisitor = new TextDocumentVisitor();
foreach(var element in elements)
    element.Accept(textVisitor);  // Same code, different outputs!
```

**Output:**
```
Text Format:
HELLO
-----

World

---

Markdown Format:
# Hello

World
```

---

## Why This Pattern Rocks

| Feature | Zoo | Document |
|---------|-----|----------|
| **Elements** | Lion, Zebra | Title,
