using System.Diagnostics;

namespace ShutdownToolkit.Domain.Factory
{
    public class Sleep : AbstractShutdown
    {
        public Sleep()
        {
            Action = "/h";
        }

        public override void ShutdownAction()
        {
            Process.Start("shutdown", $"{Action}");
        }
    }
}
