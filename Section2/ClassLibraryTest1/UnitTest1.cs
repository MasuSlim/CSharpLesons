using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLibraryPractice
{
    public static class Class1
    {
        public static int Addition(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}


namespace ClassLibraryTest1
{
    [TestClass]
    public class UnitTest1
    {

        
        [TestMethod]
        public void TestMethod1()
        {
            int result = ClassLibraryPractice.Class1.Addition(10, 5);
            Assert.AreEqual(result, 14);
        }
    }
}