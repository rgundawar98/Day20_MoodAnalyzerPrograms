using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyser
    {
        public string message;
        //Refactor 
        public MoodAnalyser()
        {
            Console.WriteLine("Default constructor");
        }
        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()//(string message)// UC1
        {
            //UC2 Passing null value
            try
            {
               if(message.ToLower().Contains("happy"))
               {
                   return "Happy";
               }
               else
               {
                   return "Sad";
               }
            }
            catch(NullReferenceException ex)
            {
                //Console.WriteLine(ex.Message);
                //return "Happy";
                //UC3
               // throw new CustomMoodAnalyserException("Message should not be null",CustomMoodAnalyserException.ExceptionType.NULL_MESSAGE); //TC3.1
                throw new CustomMoodAnalyserException("Message should not be empty", CustomMoodAnalyserException.ExceptionType.EMPTY_MESSAGE); //TC3.2
            }
        }
    }
}
