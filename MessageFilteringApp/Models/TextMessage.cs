using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessageFilteringApp.Database;
using System.Text.RegularExpressions;

namespace MessageFilteringApp.Models
{
    public class TextMessage : Message 
    {
        public string sender;
        public string messageText;

        public TextMessage(string header, string body)
        {
            this.Header = header;
            this.Body = body;
            this.sender = FindSender(body);
            

        }

        public string FindSender(string source)
        {
            string number = "";
            Regex regex = new Regex(@"(\d{11})");
            Match match = regex.Match(source);
            if (match.Success)
            {
                number = match.Value;
            }
            return number;
        }
    }
}
