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

            string mood = "";
            MoodAnalyser m1 = new MoodAnalyser();
            string expectedOutput = "No Such Class Error";

            //Act
            string actualOutput = m1.check(mood);
            Console.WriteLine(actualOutput);


            //Assert
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
    }
