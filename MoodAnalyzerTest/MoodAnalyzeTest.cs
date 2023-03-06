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
        public void TestFor_AnalyzeMood_Sad()
        {
            string message = "I am in sad Mood";
            string expected = "SAD";
            MoodAnalyser  moodAnalyser = new MoodAnalyser();
            string actual = moodAnalyser.AnalyseMood(message);
            if (actual == expected)
            {
                Assert.AreEqual(expected, actual);
            }
            Console.WriteLine(expected);
        }

        //TC 1.2 Given "I am in happy Mood" message should return HAPPY
        [TestMethod]
        [TestCategory("TestForHappy")]
        public void TestFor_AnalyzeMood_Happy()
        {
            string message = "I am in happy mood";
            string expected = "HAPPY";
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string actual = moodAnalyser.AnalyseMood(message);
            if(actual == expected)
            {
                Assert.AreEqual(expected, actual);
            }
            Console.WriteLine(expected);
        }
    }
}
