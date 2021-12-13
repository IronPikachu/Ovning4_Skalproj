using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using SkalProj_Datastrukturer_Minne;

namespace MethodTesting
{
    [TestClass]
    public class Methods
    {
        [TestMethod]
        public void ReverseActuallyReverses()
        {
            //Arrange
            string input = "Banana pie 1337 master XD";
            char[] temp = input.ToCharArray();
            string expected = new string(temp.Reverse().ToArray());
            //Act
            string actual = SkalProj_Datastrukturer_Minne.Program.ReverseText(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RecursiveEvenTests()
        {
            //Arrange
            int[] input = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] expected = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                expected[i] = 2 * input[i];
            }

            //Act
            int[] actual = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                actual[i] = SkalProj_Datastrukturer_Minne.Program.RecursiveEven(input[i]);
            }

            //Assert
            for (int i = 0; i < actual.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }

        }
        [TestMethod]
        public void TestFibonacci()
        {
            //Arrange
            int[] input = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] expected = {0, 1, 1, 2, 3, 5, 8, 13, 21, 34};

            //Act
            int[] actual = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                actual[i] = SkalProj_Datastrukturer_Minne.Program.Fibonacci(input[i]);
            }

            //Assert
            for (int i = 0; i < actual.Length; i++)
            {
                Assert.AreEqual(expected[i], actual[i]);
            }

        }
    }
}