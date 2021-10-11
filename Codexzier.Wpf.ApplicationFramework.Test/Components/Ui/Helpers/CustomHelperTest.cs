using Codexzier.Wpf.ApplicationFramework.Components.Ui.EventBus;
using Codexzier.Wpf.ApplicationFramework.Components.Ui.Helpers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace Codexzier.Wpf.ApplicationFramework.Test.Components.Ui.Helpers
{
    [TestFixture, SingleThreaded]
    public class CustomHelperTest
    {
        [Test, STAThread]
        public void GetContentReference()
        {
            // TODO: Probelm mit dem STA. Eigentlich hatte ich dazu schonmal eine Lösung.

            //// arrange
            //var customControl = new SideHostControl();

            //// act
            //var result = customControl.GetContentPresenter<ContentPresenter>();

            //// assert
            //Assert.IsNotNull(result);
        }
    }
}
