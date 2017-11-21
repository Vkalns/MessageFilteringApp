using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageFilteringApp.Models
{
    public class Abbreviation
    {
        public string inShort { get; set; }
        public string inFull { get; set; }

        public Abbreviation()
        {
            inShort = string.Empty;
            inFull = string.Empty;
        }
    }
}
