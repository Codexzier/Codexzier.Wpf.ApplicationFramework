using System;

namespace Codexzier.Wpf.ApplicationFramework.Components.Database
{
    [Obsolete("SQLite muss ich nochmal prüfen.")]
    public class LandkreisDb
    {

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}