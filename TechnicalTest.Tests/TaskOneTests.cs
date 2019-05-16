using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TechnicalTest.Tests
{
    [TestClass]
    public class TaskOneTests
    {
        [TestMethod]
        public void CanReverseString()
        {
            var value = "MyString";
            var expectedResult = "gnirtSyM";

            var result = TaskOne.ReverseString(value);

            Assert.AreEqual(value, expectedResult);
        }

        [TestMethod]
        public void CanCheckIsPalindrome()
        {
            var value = "racecar";

            var result = TaskOne.IsPalindrome(value);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanCheckIsPalindromeWithUpperCase()
        {
            var value = "Racecar";

            var result = TaskOne.IsPalindrome(value);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CanSumNumbersFromOne()
        {
            var value = 100;
            var expectedResult = 5050;

            var result = TaskOne.SumOfNumbersFromOne(value);

            Assert.IsTrue(result == expectedResult);
        }

    }
}
