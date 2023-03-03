using MoodAnalyzer;

namespace TestProject1
{
    [TestClass]
    public class MoodTest
    {
        [TestMethod]
        public void MoodAnalyser_Success()
        {
            // Arrange
            //MoodAnalyser m1 = new MoodAnalyser("happy");
            MoodAnalyser m1 = new MoodAnalyser("Sad");

            // Act
            var result = m1.mood();

            // Assert
            Assert.AreEqual("Sad", result);



        }
    }
}