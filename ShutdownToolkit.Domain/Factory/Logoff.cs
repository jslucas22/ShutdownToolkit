using System.Diagnostics;

namespace ShutdownToolkit.Domain.Factory
{
    public class Logoff : AbstractShutdown
    {
        public Logoff()
        {
            Action = "/l";
        }

        public override void ShutdownAction()
        {
            Process.Start("shutdown", $"{ Action}");
        }
    }
}
