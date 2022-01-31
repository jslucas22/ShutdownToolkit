namespace ShutdownToolkit.Domain.Factory
{
    public abstract class AbstractShutdown
    {
        public string Action { get; set; }
        public abstract void ShutdownAction();
    }
}
