namespace VisitorDesignPattern;

public class ConcreteElement1 : Element // lion
{
    public void Accept(Visitor visitor) // accept a visitor - a vet
    {
        visitor.Visit(this); // visit the concrete element - take care the lion
    }

    public string Operation1()
    {
        return "concreteElement1: Operation1";
    }

    public string Operation2()
    {
        return "concreteElement1: Operation2";
    }
}
