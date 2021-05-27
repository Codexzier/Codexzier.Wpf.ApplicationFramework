using Codexzier.Wpf.ApplicationFramework.Components.Ui.EventBus;

namespace Codexzier.Wpf.ApplicationFramework.Commands
{
    public class BaseMessage : IMessageContainer
    {
        public BaseMessage(object content)
        {
            this.Content = content;
        }
        public object Content { get; }
    }
}
