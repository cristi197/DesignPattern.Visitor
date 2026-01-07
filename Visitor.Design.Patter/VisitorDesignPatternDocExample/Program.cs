// client

using VisitorDesignPatternDocExample;

List<IDocumentElement> elements =
[
    new TitleElement("The Visitor Design Pattern"),
    new SubtitleElement("Intent"),
    new ContentElement("Represents an operation to be performed on the elements of an object structure without changing the classes on which it operates."),
    new SubtitleElement("Is it amazing?"),
    new ContentElement("Yes")
];

Console.WriteLine("Text format:");
TextDocumentVisitor textDocumentVisitor = new();

foreach(var element in elements)
{
    element.Accept(textDocumentVisitor);
}

Console.WriteLine("Markdown format:");
MarkdownDocumentVisitor markdownDocumentVisitor = new();

foreach (var element in elements)
{
    element.Accept(markdownDocumentVisitor);
}