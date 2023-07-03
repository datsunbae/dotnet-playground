using FluentAssertions;
using Lab1Utility.MyFunc;

namespace Lab1Utility.Tests.MyFuncTests
{
    public class MyFuncTests
    {
        [Fact]
        public void MyFunc_Say_ReturnString()
        {
            //Arrange
            var myFunc = new StupidFunc();
            //Act
            string name = "datsunbae";
            var result = myFunc.Say(name);
            //Assert
            result.Should().Be($"Hello, {name}");
            result.Should().NotBeNull();
            result.Should().Contain(name);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(2, 2, 4)]
        public void MyFunc_Sum_ReturnInt(int a, int b, int expected)
        {
            //Arrange
            var myFunc = new StupidFunc();
            //Act
            int result = myFunc.Sum(a, b);
            //Assert
            result.Should().Be(expected);
            result.Should().BeInRange(1, 100);
            result.Should().NotBeInRange(-100, 0);
        }
    }
}