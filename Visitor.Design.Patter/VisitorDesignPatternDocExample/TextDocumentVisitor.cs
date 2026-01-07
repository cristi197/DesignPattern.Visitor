namespace VisitorDesignPatternDocExample;

internal class TextDocumentVisitor : IDocumentVisitor
{
    public void Visit(TitleElement titleElement)
    {
        Console.WriteLine(titleElement.Text.ToUpper());
        Console.WriteLine(new string('=', titleElement.Text.Length));
        Console.WriteLine();
    }
    public void Visit(SubtitleElement subtitleElement)
    {
        Console.WriteLine(subtitleElement.Text);
        Console.WriteLine(new string('-', subtitleElement.Text.Length));
        Console.WriteLine();
    }
    public void Visit(ContentElement contentElement)
    {
        Console.WriteLine(contentElement.Text);
        Console.WriteLine();
    }
}
