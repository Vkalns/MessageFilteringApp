using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessageFilteringApp.Models;
using System.IO;

namespace MessageFilteringApp.Database
{

    public class LoadAbbreviations
    {
        private string _csvFilePath;
        public string ErrorCode { get; set; }
        public List<Abbreviation> Abbreviations { get; set; }

        public LoadAbbreviations()
        {
            _csvFilePath = @"D:\GoogleDrive\Napier\3rdYear\Software Development\CourseWork\MessageFilteringApp\MessageFilteringApp\Database\textwords.csv";
            ErrorCode = string.Empty;
            Abbreviations = new List<Abbreviation>();
        }
        public bool FromCsv()
        {
            try
            {
                var info = File.ReadAllLines(_csvFilePath);
                foreach (string value in info)
                {
                    var line = value.Split(',');
                    Abbreviations.Add(new Abbreviation()
                    {
                        inShort = line[0],
                        inFull = line[1]
                    });
                }
                return true;
            }
            catch (Exception ex)
            {
                ErrorCode = ex.ToString();
                return false;
            }
        }
        public List<Abbreviation> getAllAbbreviations ()
        {
            FromCsv();
            Abbreviations.ForEach(Console.WriteLine);
            return Abbreviations;
        }
        
    }
}
