using System;

namespace Codexzier.Wpf.ApplicationFramework.Components.Database
{
    [Obsolete("SQLite muss ich nochmal prüfen.")]
    public class RkiDataDb
    {
        //[AutoIncrement, PrimaryKey]
        public int Id { get; set; }

        public DateTime StateTime { get; set; }

        public int[] DataValuesDbIds { get; set; }
    }
}