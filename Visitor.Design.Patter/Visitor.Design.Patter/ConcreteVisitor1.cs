using VisitorDesignPattern;

public class ConcreteVisitor1 : Visitor
{
    public void Visit(ConcreteElement1 element)
    {
        var message = element.Operation1();
        Console.WriteLine($"Concrete Visitor1: {message}");
    }
    public void Visit(ConcreteElement2 element)
    {
        var message = element.Operation2();
        Console.WriteLine($"Concrete Visitor1: {message}");
    }
}
