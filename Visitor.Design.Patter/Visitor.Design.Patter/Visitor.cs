namespace VisitorDesignPattern;

public interface Visitor
{
    void Visit(ConcreteElement1 concreteElement1);
    void Visit(ConcreteElement2 concreteElement2);
}
