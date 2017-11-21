using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessageFilteringApp.Database;

namespace MessageFilteringApp.Models
{
    public class Message
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public List<Abbreviation> abbreviations;//List of abbreviations

        public Message()
        {
            Header = string.Empty;
            Body = string.Empty;
            LoadAbbreviations loadAbbreviations = new LoadAbbreviations();
            if (loadAbbreviations.FromCsv())
            {
                abbreviations = loadAbbreviations.getAllAbbreviations();
            }
        }
    }

}
