using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MessageFilteringApp.Models
{
    class EmailMessage : Message
    {
        public string sender;
        public string Subject;

        public EmailMessage(string header, string body)
        {
            this.Header = header;
            this.Body = body;
            sender = FindSender(body);
        }

        public string FindSender(string source)
        {
            string email = "";
            Regex regex = new Regex(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*)@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])");
            Match match = regex.Match(source);
            if (match.Success)
            {
                email = match.Value;
            }
            return email;
        }

        public List<string> FindURLs(string source)
        {
            
            Regex regex = new Regex(@"(http|ftp|https):\/\/[\w-]+(\.[\w-]+)+([\w.,@?^=%&:/~+#-]*[\w@?^=%&/~+#-])");
            List<string> urls = new List<string>();
            
            foreach (Match match in regex.Matches(source))
            {
                urls.Add(match.Value);
            }
            return urls;


        }
    }
}
