using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionMoodAnalyser
{
    internal class MoodAnalyser
    {
        private string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public void SetMessage(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {

            try
            {
               if (string.IsNullOrWhiteSpace(message))
                {
                    return "Happy Mood";
                }
                else if (message.Contains("sad", StringComparison.OrdinalIgnoreCase))
                {
                    return "Sad Mood";
                }
                else if (message.Contains("happy", StringComparison.OrdinalIgnoreCase))
                {
                    return "Happy Mood";
                }
                else
                {
                    throw new MoodAnlayserException("Unable to determine mood. Invalid message.");
                }
            }
            catch (MoodAnlayserException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                return "Error";
            }
        }
    }
}
