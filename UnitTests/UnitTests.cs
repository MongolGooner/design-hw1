using Xunit;
using design_hw1;
using Xunit.Sdk;

namespace UnitTests
{
    
    public class UnitTests 
    {
        [Fact]
        public void NoSolutionTest()
        {
            //arrange
            var a = 1;
            var b = 0;
            var c = 1;
            //act
            var result = Square.Solve(a, b, c);
            //assert
            Assert.Empty(result);
        }

        [Fact]
        public void TwoSolutionsTest()
        {
            //arrange
            var a = 1;
            var b = 0;
            var c = -1;
            //act
            var result = Square.Solve(a, b, c);
            //assert
            Assert.Equal( 2, result.Length);
        }

        [Fact]
        public void OneSolutionTest()
        {
            //arrange
            var a = 1;
            var b = 2;
            var c = 1;
            //act
            var result = Square.Solve(a, b, c);
            //assert
            Assert.Single(result);
        }

        [Fact]
        public void SmallATest()
        {
            //arrange
            var a = 0;
            var b = 2;
            var c = 1;
            //act
            
            //assert
            Assert.Throws<Exception>(()=> Square.Solve(a, b, c));
        }

        [Fact]
        public void NanInfinityTest()
        {
            //arrange
            
            //act

            //assert
            Assert.Throws<Exception>(() => Square.Solve(double.NaN,1,1));
            Assert.Throws<Exception>(() => Square.Solve(1,double.NaN,1));
            Assert.Throws<Exception>(() => Square.Solve(1,1,double.NaN));

            Assert.Throws<Exception>(() => Square.Solve(double.PositiveInfinity, 1, 1));
            Assert.Throws<Exception>(() => Square.Solve(1, double.PositiveInfinity, 1));
            Assert.Throws<Exception>(() => Square.Solve(1, 1, double.PositiveInfinity));


            Assert.Throws<Exception>(() => Square.Solve(double.NegativeInfinity, 1, 1));
            Assert.Throws<Exception>(() => Square.Solve(1, double.NegativeInfinity, 1));
            Assert.Throws<Exception>(() => Square.Solve(1, 1, double.NegativeInfinity));

        }

    }

}
