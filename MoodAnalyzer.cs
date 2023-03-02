using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public  class MoodAnalys
    {
        
        public string  CheckMoodAnalyzer() 
        {
            Console.WriteLine("Enter Happy or Sad to check through MoodAnalyzer");
            string mood = Console.ReadLine();
            if (mood == "Happy" || mood == "happy" ) 
            {
                return "Happy";
                

            }
            else
            {
                return "Sad";
                
            }


        }
    }
}
