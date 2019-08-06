namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction ab = new RefinedAbstraction();

            // Set implementation and call
            ab.Implementor = new ConcreteImplementorA();
            ab.Operation();

            // Change implemention and call
            ab.Implementor = new ConcreteImplementorB();
            ab.Operation();


            // example 2
            var bridge1 = new Bridge1();
            var ab1 = new AbstractBridge(bridge1);
            ab1.CallMethod1();
            ab1.CallMethod2();

            var bridge2 = new Bridge2();
            var ab2 = new AbstractBridge(bridge2);
            ab2.CallMethod1();
            ab2.CallMethod2();

            // example 3
            var customers = new Customers();

            // Set ConcreteImplementor
            customers.DataObject = new CustomersData { City = "Chicago" };

            // Exercise the bridge
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Next();
            customers.Show();

            customers.Add("Bob Dole");
            customers.ShowAll();

        }
    }
}
