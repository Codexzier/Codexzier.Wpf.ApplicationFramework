using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using WpfAppTemplateForNuget.Components.Data;
using WpfAppTemplateForNuget.Components.RkiCoronaLandkreise;

namespace WpfAppTemplateForNuget.Components.LegacyData
{
    internal class LegacyDataConverter
    {
        public int Run(string path)
        {
            var newComponent = RkiCoronaLandkreiseComponent.GetInstance();
            var files = this.GetRkiFiles(path).ToList();

            foreach (var item in files)
            {
                var legacyData = JsonConvert.DeserializeObject<LegacyDataFormat>(File.ReadAllText(item));

                var date = legacyData.lastUpdate.RemoveTimeFromLastUpdateString();

                var newFilename = $"{HelperExtension.SubFolderRkiData()}/{HelperExtension.RkiFilename}-{date}.json";

                if (File.Exists(newFilename)) continue;

                var landkreise = new Landkreise();
                var d = DateTime.Parse(date);
                landkreise.Date = d;
                landkreise.Districts = legacyData.districts.Select(s =>
                    new Landkreis
                    {
                        Name = s.name,
                        Date = d,
                        Deaths = s.deaths,
                        WeekIncidence = s.weekIncidence
                    }
                ).ToList();

                newComponent.SaveToFile(landkreise, newFilename);
            }

            return files.Count();
        }

        private IEnumerable<string> GetRkiFiles(string path)
        {
            var files = Directory
                .GetFiles(path)
                .Where(w => w.Contains(HelperExtension.RkiFilename));

            return files;
        }
    }
}