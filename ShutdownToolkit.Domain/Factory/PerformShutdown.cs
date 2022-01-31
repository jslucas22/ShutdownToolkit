namespace ShutdownToolkit.Domain.Factory
{
    public class PerformShutdown
    {
        public void DoShutdown(int action)
        {
            var shutdownAction = new ShutdownFactoryMethod();
            shutdownAction.PerformShutdown(action).ShutdownAction();
        }
    }
}
