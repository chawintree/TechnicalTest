using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechnicalTest.TaskTwo;

namespace TechnicalTest.Tests
{
    [TestClass]
    public class TaskTwoTests
    {
        [TestMethod]
        public void CanAddLettersToTextInput()
        {
            TextInput input = new TextInput();
            var expectedResult = "Hi";

            input.Add('H');
            input.Add('i');

            var result = input.GetValue();

            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void CanAddNumberToTextInput()
        {
            TextInput input = new TextInput();
            var expectedResult = "12";

            input.Add('1');
            input.Add('2');

            var result = input.GetValue();

            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void CanAddLettersAndNumbersToTextInput()
        {
            TextInput input = new TextInput();
            var expectedResult = "H1";

            input.Add('H');
            input.Add('1');

            var result = input.GetValue();

            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void CanAddNumberToNumberInput()
        {
            NumberInput input = new NumberInput();
            var expectedResult = "12";

            input.Add('1');
            input.Add('2');

            var result = input.GetValue();

            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CannotAddLettersToNumberInput()
        {
            NumberInput input = new NumberInput();

            input.Add('H');
        }
    }
}
