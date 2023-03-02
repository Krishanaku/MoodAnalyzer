using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzer
{
    public  class MoodAnalys
    {
        
        public string  CheckMoodAnalyzer(string mood) 
        {
            
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
