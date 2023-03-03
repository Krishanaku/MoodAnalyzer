using MoodAnalyserDemo;
using MoodAnalyzer;

namespace TestProject1
{
    [TestClass]
    public class MoodTest
    {
        [TestMethod]
        public void MoodAnalyser_Success()
        {

            string mood = "Happy";
            MoodAnalyser m1 = new MoodAnalyser();
            string expectedOutput = "Happy";

            //Act 
            string actualOutput = m1.check(mood);

            //Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
    }
