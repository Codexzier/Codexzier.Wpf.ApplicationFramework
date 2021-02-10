using CodexzierSimpleApplicationFramework.Components.Ui.EventBus;

namespace CodexzierSimpleApplicationFramework.Commands
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
