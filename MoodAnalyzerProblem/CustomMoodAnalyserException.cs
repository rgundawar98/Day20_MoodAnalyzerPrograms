using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class CustomMoodAnalyserException : Exception
    {
        public ExceptionType exceptiontype;
        public enum ExceptionType
        {
            NULL_MESSAGE,
            EMPTY_MESSAGE
        }
        public CustomMoodAnalyserException(string msg , ExceptionType exceptiontype): base(msg) 
        {
            this.exceptiontype = exceptiontype;
            Console.WriteLine(msg);
        }
    }
}
