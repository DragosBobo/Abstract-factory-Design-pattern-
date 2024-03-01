class Program
{
    static void Main(string[] args)
    {
        ClientCode(new TruckCreator());

        Console.ReadKey();
    }
    public static void ClientCode(Creator creator)
    {
        Console.WriteLine("Client Code said that : " );
        creator.Transport();
    }
}
class Truck : IProduct
{
    public void Deliver()
    {
        Console.WriteLine("Deliver by truck ");
    }
}
class Ship : IProduct
{
    public void Deliver()
    {
        Console.WriteLine("Deliver by ship ");
    }
}
interface IProduct
{
    void Deliver();
}
 

abstract class Creator
{
    public abstract IProduct FactoryMethod();
    public void Transport()
    {
        var product = FactoryMethod();
        product.Deliver();
    }
}

class TruckCreator : Creator
{
    public override IProduct FactoryMethod()
    {
       return new Truck();
    }
}
class ShipCreator :  Creator
{
    public override IProduct FactoryMethod()
    {
        return new Ship();
    }

}