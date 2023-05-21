namespace ExceptionMoodAnalyser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Exception Mood Analyser Problem");

            string message = "I am in Sad Mood";
           
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            string mood = moodAnalyser.AnalyseMood();

            Console.WriteLine($"Mood: {mood}");
        }
    }
}