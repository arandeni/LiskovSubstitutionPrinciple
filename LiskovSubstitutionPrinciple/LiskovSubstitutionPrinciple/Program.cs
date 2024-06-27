// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using LiskovSubstitutionPrinciple;

//before implementing LSP
Apple1 apple1 = new Orange1();
Console.WriteLine(apple1.GetColour());

//after implementing LSP
IFruit apple = new Apple();
Console.WriteLine(apple.GetColor());
IFruit orange = new Orange();
Console.WriteLine(orange.GetColor());

public class Apple1 
{
    public virtual string GetColour() 
    {
        return "red";
    }
}

public class Orange1 : Apple1
{
    public override string GetColour()
    {
        return "orange";
    }
}
