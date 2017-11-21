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
            List<string> hashTags = new List<string>();
            hashTags.Add(FindHashTag(body));
            
        }

        public string FindHashTag(string source)
        {
            string hashtag = "";
            Regex regex = new Regex(@"(#)(\w*[\w&/+-])");
            Match match = regex.Match(source);
            if (match.Success)
            {
                hashtag = match.Value;
            }
            return hashtag;
        }
    }
}
