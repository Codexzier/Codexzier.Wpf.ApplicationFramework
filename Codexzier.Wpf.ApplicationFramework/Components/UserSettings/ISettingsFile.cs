namespace Codexzier.Wpf.ApplicationFramework.Components.UserSettings
{
    public interface ISettingsFile
    {
        bool HasChanged();

        void SetChanged();
        void NoChanged();
    }
}