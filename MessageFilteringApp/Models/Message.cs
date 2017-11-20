using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageFilteringApp.Models
{
    public class Message
    {
        public string Header { get; set; }
        public string Body { get; set; }

        public Message()
        {
            Header = string.Empty;
            Body = string.Empty;
        }
    }

}
