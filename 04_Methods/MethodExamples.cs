﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _04_Methods
{
    [TestClass]
    public class MethodExamples
    {

        //Input
        //What we do
        //Output

        //Access Modifier   Return Type  Method Signature(name and list of parameters)
        public int AddTwoNumbers(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
                return sum;
        }
        public int AddTwoNumbers(int x)
        {
            return x;
        }
            

        private int MultiplyTwoNumbers(int x, int z)
        {
            int prod = x * z;
            return prod;
        }

        private int divideTwoNumbers(int apricot, int cherry)
        {
            int fruitSalad = apricot / cherry;
            return fruitSalad;
        }

        private int FindRemainder(int a, int numTwo)
        {
            int remainder = a % numTwo;
            return remainder;
        }
        private int SubtractTwoNumbers(int a, int b)
        {
            int num = a - b;
            return num;

        }

        [TestMethod]
        public void MethodTests()
        {
           int banana = AddTwoNumbers(7, 12);
            AddTwoNumbers(1, 2);
            Assert.AreEqual(19, banana);

            int subtractedBanana = SubtractTwoNumbers(10, 5);
            Assert.AreEqual(5, subtractedBanana);

            int product = MultiplyTwoNumbers(12, 5);
            Assert.AreEqual(60, product);

            int fruitSalad = divideTwoNumbers(10, 4);
            Assert.AreEqual(2, fruitSalad);

            int remainder = FindRemainder(10, 4);
            Assert.AreEqual(2, remainder);


        }
    }
}
