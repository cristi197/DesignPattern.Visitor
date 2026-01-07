# DesignPattern.Visitor

## Hey! 👋 Welcome to My Visitor Pattern Showcase

So, I wanted to explore the Visitor design pattern and create **2 different representations** to show how it works in real-world scenarios. Let me walk you through both examples - they're pretty cool!

## What's the Visitor Pattern All About?

The Visitor pattern is basically a way to perform operations on objects without changing the objects themselves. Think of it like this: you have different types of visitors, and each one does something different when they visit your objects. Pretty neat, right?

### The Key Ingredients

- **Element**: The object that accepts visitors (it has an `Accept` method)
- **ConcreteElement**: Specific types of elements (like a Lion or a Zebra)
- **Visitor**: The interface that defines what operations can be done
- **ConcreteVisitor**: Actual implementations that do the work (like a Vet or a Zoo Staff member)

---

## My Two Examples

I've created **two different ways** to demonstrate this pattern. Check them out:

### 1. 🦁 Zoo Example (VisitorDesignPattern)

Imagine you're managing a zoo! You have different animals, and different types of visitors come by to interact with them.

#### The Scenario
We've got lions and zebras in the zoo. Sometimes a veterinarian visits to check on their health, and sometimes zoo staff members come to take care of them. We don't want to mix all this logic into the animal classes - that would be messy! So we use the Visitor pattern.

#### What We Have
- **Elements**: 
  - `ConcreteElement1` = **Lion** 🦁
  - `ConcreteElement2` = **Zebra** 🦓
  
- **Visitors**:
  - `ConcreteVisitor1` = **Veterinarian** - checks health, provides treatments
  - `ConcreteVisitor2` = **Zoo Staff Member** - handles feeding, cleaning, etc.

#### Project Files
```
VisitorDesignPattern/
├── Element.cs              # Base interface for elements (animals)
├── ConcreteElement1.cs     # Lion implementation
├── ConcreteElement2.cs     # Zebra implementation
├── Visitor.cs              # Base interface for visitors
├── ConcreteVisitor1.cs     # Veterinarian implementation
├── ConcreteVisitor2.cs     # Zoo staff member implementation
└── Program.cs              # Demo application - client
```

#### How You Use It
```csharp
// Create animals
Element lion = new ConcreteElement1();
Element zebra = new ConcreteElement2();

// Create visitors
Visitor vet = new ConcreteVisitor1();
Visitor staffMember = new ConcreteVisitor2();

// Let visitors do their thing!
lion.Accept(vet);              // Vet checks the lion
zebra.Accept(vet);             // Vet checks the zebra
lion.Accept(staffMember);      // Staff member cares for the lion
```

The cool part? If we need a new type of visitor (like a trainer or a photographer), we just create a new Visitor class - no need to touch the animal classes!

---

### 2 📄 Document Formatting Example (VisitorDesignPatternDocExample)

Now let's say you have some document content that needs to be displayed in different formats. This is where the Document example shines!

#### The Scenario
You've got a document with titles, subtitles, and content. Sometimes you want to display it as plain text, and sometimes as markdown. Instead of adding formatting logic to each element type, we use visitors to handle the different output formats.

#### What We Have
- **Elements**:
  - `TitleElement` - The main title
  - `SubtitleElement` - Section headers
  - `ContentElement` - Body text

- **Visitors**:
  - `TextDocumentVisitor` - Renders everything as nice plain text with ASCII decorations
  - `MarkdownDocumentVisitor` - Renders everything as markdown

#### Project Files
```
VisitorDesignPatternDocExample/
├── IDocumentElement.cs           # Base interface for elements
├── TitleElement.cs               # Title element
├── SubtitleElement.cs            # Subtitle element
├── ContentElement.cs             # Content element
├── IDocumentVisitor.cs           # Base interface for visitors
├── TextDocumentVisitor.cs        # Plain text formatter
├── MarkdownDocumentVisitor.cs    # Markdown formatter
└── Program.cs                    # Demo application - client
```

#### How You Use It
```csharp
// Create document structure
List<IDocumentElement> elements =
[
    new TitleElement("The Visitor Design Pattern"),
    new SubtitleElement("Intent"),
    new ContentElement("Represents an operation to be performed..."),
    new SubtitleElement("Is it amazing?"),
    new ContentElement("Yes")
];

// Render as plain text
Console.WriteLine("Text format:");
TextDocumentVisitor textVisitor = new();
foreach(var element in elements)
{
    element.Accept(textVisitor);
}

// Render as markdown
Console.WriteLine("Markdown format:");
MarkdownDocumentVisitor markdownVisitor = new();
foreach (var element in elements)
{
    element.Accept(markdownVisitor);
}
```

#### What You Get

**Text Format:**
```
THE VISITOR DESIGN PATTERN
===========================

INTENT
------

Represents an operation to be performed...

IS IT AMAZING?
--------------

Yes
```

**Markdown Format:**
```
# The Visitor Design Pattern

## Intent

Represents an operation to be performed...

## Is it amazing?

Yes
```

Want to add JSON formatting? Just create a new `JsonDocumentVisitor` - no need to touch the elements!

---

## Why I Made Both Examples

Each example shows different strengths of the Visitor pattern:

| Aspect | Zoo Example | Document Example |
|--------|------------|-----------------|
| **What It Does** | Different people do different things with the same animals | Same content, different output formats |
| **Elements** | Animals (Lion, Zebra) | Document parts (Title, Subtitle, Content) |
| **Visitors** | Different roles (Vet, Staff) | Different formats (Text, Markdown) |
| **Why It's Cool** | Easy to add new roles without changing animals | Easy to add new formats without changing elements |

---

## The Best Part About This Pattern

✨ **Easy to Extend**: Need something new? Just add a new Visitor - the elements stay the same!

✨ **Clean Code**: Operations live in Visitors, not scattered through your element classes

✨ **Type Safe**: Each Visitor knows exactly what types of elements it can work with

✨ **Flexible**: Run different operations on the same objects without any hassle

---

## Tech Stack

- **.NET 10**
- **C# 14.0**
