using System;

namespace Codexzier.Wpf.ApplicationFramework.Components.Database
{
    [Obsolete("SQLite muss ich nochmal prüfen.")]
    public class DatabaseQueryCreatorException : Exception
    {
        public DatabaseQueryCreatorException(string message) : base(message)
        {
        }
    }
}