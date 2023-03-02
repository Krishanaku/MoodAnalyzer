using MoodAnalyzer;

namespace TestProject1
{
    [TestClass]
    public class MoodTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange

            string s1 = "Happy";
            MoodAnalys m1 = new MoodAnalys();
            string expectedOutput = "Happy";

            //Act
            string actualOutput = m1.CheckMoodAnalyzer(s1);

            //Assert
            Assert.AreEqual(expectedOutput, actualOutput);


        }
    }
}