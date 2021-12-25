using System;
namespace DesignPatterns.Structural.Adapter
{
    public class Client
    {
        public void Main(string[] args)
        {
            Adaptee adaptee = new();
            ITarget target = new Adapter(adaptee);

            Console.WriteLine("Adaptee interface is incompatible with the client.");
            Console.WriteLine("But with adapter client can call it's method.");

            Console.WriteLine(target.GetRequest());
        }
    }
}