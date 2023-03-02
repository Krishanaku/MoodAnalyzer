namespace MoodAnalyzer
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            MoodAnalys moodAnalyzer = new MoodAnalys();
            string s1 = moodAnalys.CheckMoodAnalyzer();
            Console.WriteLine(s1);
        }

    }
}