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
        public bool ToJson(TextMessage textMessage)//same but for TextMessages
        {
            try
            {
                string json = JsonConvert.SerializeObject(textMessage, Formatting.Indented);
                json = json + Environment.NewLine;
                File.AppendAllText(jsonFilePath, json.ToString());
                return true;


            }
            catch (Exception ex)
            {
                ErrorCode = ex.ToString();
                return false;
            }
        }

        public bool ToJson(EmailMessage emailMessage)//same but for e-mail
        {
            try
            {
                string json = JsonConvert.SerializeObject(emailMessage, Formatting.Indented);
                json = json + Environment.NewLine;
                File.AppendAllText(jsonFilePath, json.ToString());
                return true;


            }
            catch (Exception ex)
            {
                ErrorCode = ex.ToString();
                return false;
            }
        }
        public bool ToJson(TwitterMessage twitterMessage)//same but for twitter
        {
            try
            {
                string json = JsonConvert.SerializeObject(twitterMessage, Formatting.Indented);
                json = json + Environment.NewLine;
                File.AppendAllText(jsonFilePath, json.ToString());
                return true;


            }
            catch (Exception ex)
            {
                ErrorCode = ex.ToString();
                return false;
            }
        }

    }
}
