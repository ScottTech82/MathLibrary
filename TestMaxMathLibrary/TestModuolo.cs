using MAX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaxMathLibrary
{
    public class TestModuolo
    {
        MaxMathLibrary mathlib;
    
    public TestModuolo()
        {
        mathlib = new MaxMathLibrary();

        }
    [Theory]
    [InlineData(10, 5, 0)]
    [InlineData(9, 3, 0)]
    [InlineData(7, 5, 2)]
    public void Test1(int a, int b, decimal expected)
        {
        Assert.Equal(expected, mathlib.Moduolo(a, b));
        }
    }
}
