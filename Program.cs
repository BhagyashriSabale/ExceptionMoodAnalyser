namespace ExceptionMoodAnalyser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Exception Mood Analyser Problem");

            //UC1 With TC1 and TC2
            string message = "I am in Sad Mood";
            string message1 = "I am in Happy Mood";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            MoodAnalyser moodAnalyser1 = new MoodAnalyser(message1);
            string mood = moodAnalyser.AnalyseMood();
            string mood1 = moodAnalyser1.AnalyseMood();
            Console.WriteLine($"Mood: {mood}"); //Output SAD
            Console.WriteLine($"Mood: {mood1}");  //Output HAPPY

            //Refactor1 With TC1 and TC2
            MoodAnalyser moodAnalyser3 = new MoodAnalyser(message);
            MoodAnalyser moodAnalyser4 = new MoodAnalyser(message);
            MoodAnalyser moodAnalyser5 = new MoodAnalyser(message1);
            moodAnalyser3.SetMessage("No message provided"); //Unable determine mood throws exception
            string mood2 = moodAnalyser3.AnalyseMood();
            string mood3 = moodAnalyser4.AnalyseMood();
            string mood5 = moodAnalyser5.AnalyseMood();
            Console.WriteLine($"Mood: {mood3}");//Output SAD
            Console.WriteLine($"Mood: {mood5}");//Output HAPPY

            //UC2
            MoodAnalyser moodAnalyser6 = new MoodAnalyser(null);
            string mood4 = moodAnalyser6.AnalyseMood(); //Throws exception because message cannot null

            //UC3 and UC4
            MoodAnalyser moodAnalyser7 = MoodAnalyserFactory.CreateMoodAnalyser();
            moodAnalyser7.SetMessage("I am in Happy Mood");
            string mood7 = moodAnalyser7.AnalyseMood();
            Console.WriteLine($"Mood: {mood7}");//Output HAPPY

            //UC5 with TC1
            MoodAnalyser moodAnalyser8 = MoodAnalyserFactory.CreateMoodAnalyser("I am in Excited Mood");
            string mood8 = moodAnalyser8.AnalyseMood();
            Console.WriteLine($"Mood: {mood8}");
            MoodAnalyser moodAnalyser9 = MoodAnalyserFactory.CreateMoodAnalyser("I am in Happy Mood");
            MoodAnalyser moodAnalyser10 = MoodAnalyserFactory.CreateMoodAnalyser("I am in Happy Mood");
            bool isEqual = moodAnalyser9.Equals(moodAnalyser10);
            Console.WriteLine($"Are the MoodAnalyser objects equal? {isEqual}");
            try
            {
                MoodAnalyser moodAnalyser11 = MoodAnalyserFactory.CreateMoodAnalyser("InvalidClassName", "I am in Happy Mood");
            }
            catch (MoodAnlayserException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            try
            {
                MoodAnalyser moodAnalyser12 = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyser", "I am in Happy Mood");
            }
            catch (MoodAnlayserException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

        }
    }
}