using System.Diagnostics;

namespace ShutdownToolkit.Domain.Factory
{
    public class Restart : AbstractShutdown
    {
        public Restart()
        {
            Action = "shutdown -t 0 -r";
        }

        public override void ShutdownAction()
        {
            Process.Start("CMD.exe", $@"/C {Action}");
        }
    }
}
