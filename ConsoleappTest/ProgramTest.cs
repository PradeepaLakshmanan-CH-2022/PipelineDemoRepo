using ConsoleAppPipeline;

namespace ConsoleappTest
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Helloworld helloworld = new Helloworld();
            var expected = "Hello,My Console App";
            var actual = helloworld.GetName();
            Assert.AreEqual(expected, actual);  
                }
    }
}