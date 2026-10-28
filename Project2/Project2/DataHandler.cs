using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Project2
{
    public class DataHandler
    {
        
         public static List<Question> ReadFromQuestionFile(string filePath)
    {
        string json = File.ReadAllText(filePath);

        List<Question> questions =
            JsonSerializer.Deserialize<List<Question>>(json)
            ?? throw new InvalidDataException(
                "No questions in list");

        return questions;
    }
    }
}


