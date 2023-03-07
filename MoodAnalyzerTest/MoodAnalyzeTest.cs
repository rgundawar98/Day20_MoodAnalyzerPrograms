using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerProblem;

namespace MoodAnalyzerTest
{
    [TestClass]
    public class MoodAnalyzeTest
    {
        //TC 1.1 Given "I am in sad Mood" message should return SAD
        [TestMethod]
        [TestCategory("TestForSad")]
        // [DataRow(null,"Object refernce not to set an instance of object")]
        //TC 2.1
      //  [DataRow(null,"Happy")]  
        public void TestFor_AnalyzeMood_Sad(string message , string expected)
        {
           // string message = "I am in sad Mood";
            //string expected = "SAD";
           // MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            //string actual = moodAnalyser.AnalyseMood(message);
            //if (actual == expected)
            //{
            //  Assert.AreEqual(expected, actual);
            //}//uc1
            //Console.WriteLine(expected);
            
             MoodAnalyser moodAnalyser = new MoodAnalyser(message);
             string actual = moodAnalyser.AnalyseMood();
             if (actual != null)
             Assert.AreEqual(expected, actual);
        }

        //TC 1.2 Given "I am in happy Mood" message should return HAPPY
        //[TestMethod]
        //[TestCategory("TestForHappy")]
        //public void TestFor_AnalyzeMood_Happy()
        //{
        //  string message = "I am in happy mood";
        //  string expected = "HAPPY";
        //  MoodAnalyser moodAnalyser = new MoodAnalyser();
        //  string actual = moodAnalyser.AnalyseMood(message);
        //  //Refactor TC1.2
        //  //string actual = moodAnalyser.AnalyseMood();
        //  if(message == actual)
        //  {
        //     Assert.AreEqual(actual,expected);
        //  }
        //  Console.WriteLine(expected);
        //}

        [TestMethod]
        [TestCategory("TestForCustomException")]
        public void Given_Message_Should_Return_CustomException()
        {
            //TC 3.1 Given NULL Mood Should Throw MoodAnalysisException
           // string expected = "Message should not be null";
            //TC3.2 Given emoty mood should Throw MoodAnalysisException 
            string expected = "Message should not be empty";
            try
            {
                //Arrange
                string message = null;
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                //Act
                string actual = moodAnalyser.AnalyseMood();
            }
            catch(CustomMoodAnalyserException ex)
            {
                Assert.AreEqual(expected,ex.Message);
            }
        }

    }
}
