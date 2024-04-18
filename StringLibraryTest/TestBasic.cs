namespace StringLibraryTest;
using Moq;
using StringLibrary;
using Xunit;

public class ATests
{
    [Fact]
    public void F1_Returns_Correct_Value()
    {
        // Arrange
        var a = new A();
        int input = 1;
        int expectedOutput = 2; // Input + 1

        // Act
        int result = a.F1(input);

        // Assert
        Assert.Equal(expectedOutput, result);
    }

    [Fact]
    public void F2_Returns_Correct_Value()
    {
        // Arrange
        var a = new A();
        int input = 1;
        int expectedOutput = 3; // Input + 2

        // Act
        int result = a.F2(input);

        // Assert
        Assert.Equal(expectedOutput, result);
    }

    [Fact]
    public void F3_Returns_Correct_Value()
    {
        // Arrange
        var a = new A();
        int input = 1;
        int expectedOutput = 4; // Input + 3

        // Act
        int result = a.F3(input);

        // Assert
        Assert.Equal(expectedOutput, result);
    }

    [Fact]
    public void F4_Returns_Correct_Value()
    {
        // Arrange
        var a = new A();
        int input = 1;
        int expectedOutput = 5; // Input + 4

        // Act
        int result = a.F4(input);

        // Assert
        Assert.Equal(expectedOutput, result);
    }

    [Fact]
    public void F5_Returns_Correct_Value()
    {
        // Arrange
        var a = new A();
        int x = 5;
        int y = 2;
        double expectedOutput = 2.5; // x / y

        // Act
        double result = a.F5(x, y);

        // Assert
        Assert.Equal(expectedOutput, result);
    }

    [Fact]
    public void F6_Returns_Correct_Value()
    {
        // Arrange
        var a = new A();
        int input = 3;
        int expectedOutput = 8; // Input + 5

        // Act
        int result = a.F6(input);

        // Assert
        Assert.Equal(expectedOutput, result);
    }

    [Fact]
    public void F7_Returns_Correct_Value()
    {
        // Arrange
        var a = new A();
        string input = "hello";
        string expectedOutput = "hello more stuff"; // Input + " more stuff"

        // Act
        string result = a.F7(input);

        // Assert
        Assert.Equal(expectedOutput, result);
    }

    

}
public class BTests
{
    [Fact]
    public void G1_Returns_Correct_Value()
    {
        // Arrange
        var mockA = new Mock<A>();
        int input = 1;
        int expectedOutput = 10; 
        mockA.Setup(a => a.F8(It.IsAny<int>())).Returns(expectedOutput);
        var b = new B(mockA.Object);

        // Act
        int result = b.G1(input);

        // Assert
        Assert.Equal(expectedOutput, result);
    }

}