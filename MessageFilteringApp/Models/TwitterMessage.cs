using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessageFilteringApp.Database;
using System.Text.RegularExpressions;

namespace MessageFilteringApp.Models
{
    class TwitterMessage : Message
    {
        public string Sender;//sender
        public List<string> hashtags;//list of all the mentions
        public List<Abbreviation> abbreviations;//List of abbreviations

        public TwitterMessage(string header, string body)
        {
            this.Header = header;
            this.Body = body;
            List<string> hashTags = FindHashTag(body);            
            
        }

        public List<string> FindHashTag(string source)
        {
            List<string> hashtags = new List<string>();
            Regex regex = new Regex(@"(#)(\w*[\w&/+-])");
            foreach (Match match in regex.Matches(source))
            {
                hashtags.Add(match.Value);
            }
            return hashtags;
        }
    }
}
