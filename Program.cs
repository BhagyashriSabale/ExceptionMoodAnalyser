namespace ExceptionMoodAnalyser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a message: ");
            string message = Console.ReadLine();
            Console.WriteLine("Welcome Exception Mood Analyser Problem");
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            string mood = moodAnalyser.AnalyseMood();

            Console.WriteLine($"Mood: {mood}");
        }
    }
}