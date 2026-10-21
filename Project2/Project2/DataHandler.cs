using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    public class DataHandler
    {
        
        public static void ReadFromQuestionFile(string filePath)
        {
            List<string> lines = File.ReadAllLines(filePath).ToList();
            foreach (string line in lines)
            {
                string[] questionDetails = line.Split(',');
                string type = questionDetails[1];
                string difficulty = questionDetails[2];
                string category = questionDetails[3];
                string question = questionDetails[4];
                string correct = questionDetails[5];
                List<string> incorrect = new List<string>()
                {
                    questionDetails[6], questionDetails[7], questionDetails[8]
                };

            }
        }
    }
}


