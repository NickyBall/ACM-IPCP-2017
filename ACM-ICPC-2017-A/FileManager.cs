using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ACM_ICPC_2017_A
{
    public class FileManager
    {
        public List<string> GetFileInFolder(string QuestionFolder) => Directory.GetFiles($"{Directory.GetCurrentDirectory()}\\Files\\{QuestionFolder.ToUpper()}").Where(f => Regex.IsMatch(f, @"sample-\d.in")).ToList();

        public List<string> GetContentFromFile(string FilePath)
        {
            List<string> Lines = new List<string>();
            using (StreamReader reader = new StreamReader(FilePath))
            {
                while (!reader.EndOfStream)
                {
                    Lines.Add(reader.ReadLine());
                }
            }
            return Lines;
        }
    }
}
