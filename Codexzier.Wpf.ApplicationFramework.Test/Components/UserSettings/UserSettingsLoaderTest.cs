using Codexzier.Wpf.ApplicationFramework.Components.UserSettings;
using NUnit.Framework;

namespace Codexzier.Wpf.ApplicationFramework.Test.Components.UserSettings
{
    [TestFixture]
    public class UserSettingsLoaderTest
    {
        [Test]
        public void Load_SettingFile()
        {
            // arrange
            var settingsLoader = UserSettingsLoader<SettingsFile>
                .GetInstance(
                    s => string.Empty, 
                    s => new SettingsFile());
            
            // act
            var result = settingsLoader.Load();

            // assert
            Assert.IsNotNull(result);
        }
        
        [Test]
        public void Load_CustomSettingFile()
        {
            // arrange
            var settingsLoader = UserSettingsLoader<TestCustomSettingsFile>
                .GetInstance(
                    s => string.Empty, 
                    s => new TestCustomSettingsFile());
            
            // act
            var result = settingsLoader.Load();

            // assert
            Assert.IsNotNull(result);
        }
    }

    public class TestCustomSettingsFile : SettingsFile
    {
    }
}