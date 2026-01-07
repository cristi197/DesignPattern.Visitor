namespace VisitorDesignPattern;

public class ConcreteElement2 : Element // zebra
{
    public void Accept(Visitor visitor) // accept a visitor - a vet
    {
        visitor.Visit(this); // visit the concrete element - take care the zebra
    }

    public string Operation1()
    {
        return "concreteElement2: Operation1";
    }

    public string Operation2()
    {
        return "concreteElement2: Operation2";
    }
}
