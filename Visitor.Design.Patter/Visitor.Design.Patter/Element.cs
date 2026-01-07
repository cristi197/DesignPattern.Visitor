namespace VisitorDesignPattern;

public interface Element
{
    void Accept(Visitor visitor);
}
