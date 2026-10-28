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
        
         /// <summary>
        /// Reads questions from the supplied JSON file.
        /// </summary>
        public static List<Question> ReadFromQuestionFile(string filePath)
        {
            string json = File.ReadAllText(filePath);

            List<Question> questions =
                JsonSerializer.Deserialize<List<Question>>(json)
                ?? throw new InvalidDataException(
                    "The JSON file did not contain a question list.");

            if (questions.Count == 0)
            {
                throw new InvalidDataException(
                    "The question list is empty.");
            }

            foreach (Question question in questions)
            {
                if (question == null ||
                    string.IsNullOrWhiteSpace(question.Question1) ||
                    string.IsNullOrWhiteSpace(question.Category) ||
                    string.IsNullOrWhiteSpace(question.Difficulty) ||
                    string.IsNullOrWhiteSpace(question.Correct) ||
                    question.Incorrect == null ||
                    question.Incorrect.Length != 3)
                {
                    throw new InvalidDataException(
                        "A question has missing or invalid data.");
                }
            }

            return questions;
        }
    }
}


