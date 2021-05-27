using System.Windows;
using System.Windows.Media;

namespace Codexzier.Wpf.ApplicationFramework.Components.Ui.Helpers
{
    public static class CustomHelper
    {
        public static TFrameElement GetContentPresenter<TFrameElement>(this FrameworkElement control) where TFrameElement : FrameworkElement
        {
            var num = VisualTreeHelper.GetChildrenCount(control);

            if (num == 0)
            {
                return null;
            }

            for (var index = 0; index < num; index++)
            {
                var obj = VisualTreeHelper.GetChild(control, index);

                var v = (Visual)obj;
                if (v is TFrameElement frameElement)
                {
                    return frameElement;
                }

                if (obj is FrameworkElement fe)
                {
                    var t = fe.GetContentPresenter<TFrameElement>();
                    if (t != null)
                    {
                        return t;
                    }
                }
            }

            return null;
        }
    }
}
