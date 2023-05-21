namespace ExceptionMoodAnalyser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Exception Mood Analyser Problem");

            //TC1andTC2
            string message = "I am in Sad Mood";
            string message1 = "I am in Happy Mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            MoodAnalyser moodAnalyser1 = new MoodAnalyser(message1);
            string mood = moodAnalyser.AnalyseMood();
            string mood1 = moodAnalyser1.AnalyseMood();
            Console.WriteLine($"Mood: {mood}");
            Console.WriteLine($"Mood: {mood1}");
            

        }
    }
}