﻿namespace CodexzierSimpleApplicationFramework.Components.Database
{
    public class LandkreisDb
    {

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}