namespace VisitorDesignPatternDocExample;

public interface IDocumentElement
{
    void Accept(IDocumentVisitor visitor);
}
