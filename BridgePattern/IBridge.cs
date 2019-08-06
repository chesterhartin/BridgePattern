namespace BridgePattern
{
    /// <summary>
    /// The 'Implementor' abstract class
    /// Helps in providing truly decoupled architecture
    /// </summary>
    public interface IBridge
    {
        void Function1();
        void Function2();
    }
}
