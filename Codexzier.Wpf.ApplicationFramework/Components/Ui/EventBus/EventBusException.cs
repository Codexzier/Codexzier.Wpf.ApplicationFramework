using System;

namespace Codexzier.Wpf.ApplicationFramework.Components.Ui.EventBus
{
    public class EventBusException : Exception
    {
        public EventBusException(string message) : base(message)
        {
        }
    }
}