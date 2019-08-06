namespace BridgePattern
{
    /// <summary>
    /// The 'RefinedAbstraction' class
    /// </summary>
    public class AbstractBridge : IAbstractBridge
    {
        public IBridge bridge;

        public AbstractBridge(IBridge bridge)
        {
            this.bridge = bridge;
        }

        public void CallMethod1()
        {
            this.bridge.Function1();
        }

        public void CallMethod2()
        {
            this.bridge.Function2();
        }
    }
}
