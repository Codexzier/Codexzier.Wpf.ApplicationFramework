namespace CodexzierSimpleApplicationFramework.Components.UserSettings
{
    public interface ISettingsFile
    {
        bool HasChanged { get; }

        void SetChanged();
        void NoChanged();
    }
}