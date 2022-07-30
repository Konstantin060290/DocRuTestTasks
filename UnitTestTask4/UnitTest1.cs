using DocRuTestTasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTask4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckSum1()
        {
            int expected = 6;
            // act
            int result = Program.MyFunc(123);
            // assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void CheckSum2()
        {
            int expected = 2;
            // act
            int result = Program.MyFunc(5555);
            // assert
            Assert.AreEqual(expected, result);
        }
    }
}
