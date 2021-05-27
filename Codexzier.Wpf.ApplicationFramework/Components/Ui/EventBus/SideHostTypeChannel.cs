using System;

namespace Codexzier.Wpf.ApplicationFramework.Components.Ui.EventBus
{
    public class SideHostTypeChannel
    {
        public SideHostTypeChannel(int channel, Type typeView)
        {
            this.Channel = channel;
            this.TypeView = typeView;
        }

        public int Channel { get; }

        public Type TypeView { get; }
    }
}