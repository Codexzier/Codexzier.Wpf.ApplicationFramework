using System;

namespace Codexzier.Wpf.ApplicationFramework.Components.Database
{
    [Obsolete("SQLite muss ich nochmal prüfen.")]
    public class DataValuesDb
    {
        //[PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public int LandkreisDbId { get; set; }
        public double WeekIncidence { get; set; }
        public int Deaths { get; set; }
        public int Cases { get; set; }
        public DateTime Date { get; set; }
    }
}