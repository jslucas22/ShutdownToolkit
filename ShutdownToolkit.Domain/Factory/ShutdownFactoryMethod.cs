using ShutdownToolkit.Domain.Enums;
using System;

namespace ShutdownToolkit.Domain.Factory
{
    public sealed class ShutdownFactoryMethod
    {
        public AbstractShutdown PerformShutdown(int action)
        {
            AbstractShutdown shutdown;
            switch (action)
            {
                case (int)ShutdownActionEnum.Shutdown: shutdown = new Shutdown(); break;
                case (int)ShutdownActionEnum.Restart: shutdown = new Restart(); break;
                case (int)ShutdownActionEnum.Logoff: shutdown = new Logoff(); break;
                case (int)ShutdownActionEnum.Sleep: shutdown = new Sleep(); break;
                default: throw new ApplicationException($"It was not possible to execute the action -> {action}");
            }
            return shutdown;
        }
    }
}
