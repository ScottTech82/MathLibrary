using MAX;

namespace TestMaxMathLibrary
{
    public class TestAdd
    {

        MaxMathLibrary mathlib;

        // Constructor
        public TestAdd()
        {
            mathlib = new MaxMathLibrary();
        }


        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(0, 0, 0)]
        [InlineData(-11, 10, -1)]
        public void Test1(int a, int b, int expected)
        {
            Assert.Equal(expected, mathlib.Add(a, b));
            
        }
    }
}