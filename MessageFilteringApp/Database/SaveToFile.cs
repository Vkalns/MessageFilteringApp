using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using MessageFilteringApp.Models;
using Newtonsoft.Json;

namespace MessageFilteringApp.Database
{
    class SaveToFile
    {
        private string jsonFilePath;

        public string ErrorCode { get; set; }

        public SaveToFile()
        {
            jsonFilePath = @"D:\GoogleDrive\Napier\3rdYear\Software Development\CourseWork\MessageFilteringApp\MessageFilteringApp\Database\Messages.txt";
            ErrorCode = string.Empty;
        }

        public bool ToJson(Message message)
        {
            try
            {
                string json = JsonConvert.SerializeObject(message,Formatting.Indented);
                json = json + Environment.NewLine;
                File.AppendAllText(jsonFilePath, json.ToString());//from practical
                return true;                
                

            }
            catch(Exception ex)
            {
                ErrorCode = ex.ToString();
                return false;
            }
        }
    }
}
