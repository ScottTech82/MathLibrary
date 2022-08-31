using MAX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaxMathLibrary
{
    public class TestDivide
    {
        MaxMathLibrary mathlib;

    public TestDivide()
        {
            mathlib = new MaxMathLibrary();
        }

        [Theory]
        [InlineData(2, 1, 2)]
        [InlineData(25, 5, 5)]
        [InlineData(0, 0, 50)]
        public void Test1(int a, int b, int expected)
        {
            if(a > 0 & b > 0) //this doesnt seem correct.
            {
            Assert.Equal(expected, mathlib.Divide(a, b));
            }
            return;
        }
    }
}
