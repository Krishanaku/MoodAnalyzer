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

            //Arrange
            MoodAnalyser m1 = new MoodAnalyser();
            MoodAnalyser m2 = new MoodAnalyser();
            object expectedOutput = "Object are Different";

            //Act 
            object actualOutput = m1.Equals(m2);

            //Assert
            Assert.AreEqual(expectedOutput, actualOutput);

        }
    }
}