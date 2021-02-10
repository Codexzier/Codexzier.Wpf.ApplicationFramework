using Newtonsoft.Json;

namespace CodexzierSimpleApplicationFramework.Components.UserSettings
{
    public class SettingsFile : ISettingsFile
    {
        private int _sizeX;
        private int _sizeY;
        private string _applicationWindowState;
        private int _applicationPositionX;
        private int _applicationPositionY;


        public SettingsFile() => this.HasChanged = false;
        public SettingsFile(bool hasChanged) => this.HasChanged = hasChanged;

        [JsonIgnore]
        public bool HasChanged { get; private set; }

        public void SetChanged() => this.HasChanged = true;
        public void NoChanged() => this.HasChanged = false;

        public int SizeX
        {
            get => this._sizeX; set
            {
                this._sizeX = value;
                this.SetChanged();
            }
        }
        public int SizeY
        {
            get => this._sizeY;
            set
            {
                this._sizeY = value;
                this.SetChanged();
            }
        }

        public string ApplicationWindowState
        {
            get => this._applicationWindowState;
            set
            {
                this._applicationWindowState = value;
                this.SetChanged();
            }
        }

        public int ApplicationPositionX
        {
            get => this._applicationPositionX;
            set
            {
                this._applicationPositionX = value;
                this.SetChanged();
            }
        }
        public int ApplicationPositionY
        {
            get => this._applicationPositionY;
            set
            {
                this._applicationPositionY = value;
                this.SetChanged();
            }
        }
    }
}