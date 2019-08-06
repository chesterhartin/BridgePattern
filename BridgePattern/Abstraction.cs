namespace BridgePattern
{
    /// <summary>
    /// The 'Abstraction' class
    /// </summary>
    public class Abstraction
    {
        protected Implementor _implementor;

        // Property
        public Implementor Implementor
        {
            set { _implementor = value; }
        }

        public virtual void Operation()
        {
            _implementor.Operation();
        }
    }
}
