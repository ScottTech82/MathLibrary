using MAX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaxMathLibrary
{
    public class TestSubtract
    {
        MaxMathLibrary mathlib2;

        public TestSubtract()
        {
            mathlib2 = new MaxMathLibrary(); //creating an instance of MaxMathLibrary
        }
        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(15, 5, 10)]
        [InlineData(int.MinValue, 1, int.MaxValue)]
        public void TestSubtraction(int a, int b, int expected)
        {
            Assert.Equal(expected, mathlib2.Subtract(a, b));
        }
    }
}
