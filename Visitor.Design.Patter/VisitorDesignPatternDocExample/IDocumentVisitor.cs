namespace VisitorDesignPatternDocExample;

public interface IDocumentVisitor
{
    void Visit(TitleElement titleElement);
    void Visit(SubtitleElement subtitleElement);
    void Visit(ContentElement contentElement);
}
