using System;

namespace Codexzier.Wpf.ApplicationFramework.Components.Ui.EventBus
{
    /// <summary>
    /// An exception error type from the EventBus system.
    /// </summary>
    public class EventBusException : Exception
    {
        public EventBusException(string message) : base(message)
        {
        }
    }
}