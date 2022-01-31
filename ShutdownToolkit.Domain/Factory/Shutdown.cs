using System.Diagnostics;

namespace ShutdownToolkit.Domain.Factory
{
    public class Shutdown : AbstractShutdown
    {
        public Shutdown()
        {
            Action = "shutdown -t 0 -s";
        }

        public override void ShutdownAction()
        {
            Process.Start("CMD.exe", $@"/C {Action}");
        }
    }
}
