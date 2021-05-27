using Codexzier.Wpf.ApplicationFramework.Components.Ui.EventBus;

namespace Codexzier.Wpf.ApplicationFramework.Commands
{
    /// <summary>
    /// The base object of a message sent via the EventBus system.
    /// </summary>
    public class BaseMessage : IMessageContainer
    {
        /// <summary>
        /// Base Ctor to setup parameter with a content object.
        /// </summary>
        /// <param name="content"></param>
        public BaseMessage(object content) => this.Content = content;

        /// <summary>
        /// The content object must be cast or unboxing to the send type.
        /// </summary>
        public object Content { get; }
    }
}
