using System;

namespace BridgePattern
{
    /// <summary>
    /// The 'ConcreteImplementorB' class
    /// </summary>
    public class Bridge2 : IBridge
    {
        public void Function1()
        {
            Console.WriteLine("Bridge2.Function1");
        }

        public void Function2()
        {
            Console.WriteLine("Bridge2.Function2");
        }
    }
}
