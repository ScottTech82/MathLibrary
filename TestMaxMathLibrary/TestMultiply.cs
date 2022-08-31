using MAX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaxMathLibrary
{
    public class TestMultiply
    {
        MaxMathLibrary mathlib;

        // Constructor
        public TestMultiply()
        {
            mathlib = new MaxMathLibrary();
        }


        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(5, 20, 100)]
        [InlineData(-3, -3, 9)]
        public void Test1(int a, int b, int expected)
        {
            Assert.Equal(expected, mathlib.Multiply(a, b));

        }
    }
}
    

