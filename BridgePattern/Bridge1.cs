using System;

namespace BridgePattern
{
    /// <summary>
    /// The 'ConcreteImplementorA' class
    /// </summary>
    public class Bridge1 : IBridge
    {
        public void Function1()
        {
            Console.WriteLine("Bridge1.Function1");
        }

        public void Function2()
        {
            Console.WriteLine("Bridge1.Function2");
        }
    }
}
