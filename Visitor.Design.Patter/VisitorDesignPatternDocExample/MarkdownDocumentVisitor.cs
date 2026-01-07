namespace VisitorDesignPatternDocExample;

internal class MarkdownDocumentVisitor : IDocumentVisitor
{
    public void Visit(TitleElement titleElement)
    {
        Console.WriteLine($"# {titleElement.Text}");
        Console.WriteLine();
    }

    public void Visit(SubtitleElement subtitleElement)
    {
        Console.WriteLine($"## {subtitleElement.Text}");
        Console.WriteLine();
    }

    public void Visit(ContentElement contentElement)
    {
        Console.WriteLine(contentElement.Text);
        Console.WriteLine();
    }
}
