namespace Lib.ProblemSolving.Test;

public class Challenge2Test
{
    [Fact]
    public void TestCase1()
    {
        var value = Challenge2.DiceFacesCalculator(6, 6, 6);
        Assert.Equal(18, value);
    }

    [Fact]
    public void TestCase2()
    {
        var value = Challenge2.DiceFacesCalculator(5, 5, 5);
        Assert.Equal(15, value);
    }

    [Fact]
    public void TestCase3()
    {
        var value = Challenge2.DiceFacesCalculator(1, 2, 3);
        Assert.Equal(3, value);
    }

    [Fact]
    public void TestCase4()
    {
        var value = Challenge2.DiceFacesCalculator(1, 3, 1);
        Assert.Equal(2, value);
    }

    [Fact]
    public void TestCase5()
    {
        var value = Challenge2.DiceFacesCalculator(3, 5, 3);
        Assert.Equal(6, value);
    }

    [Fact]
    public void TestCase6()
    {
        var value = Challenge2.DiceFacesCalculator(6, 5, 4);
        Assert.Equal(6, value);
    }

    [Fact]
    public void TestCase7()
    {
        var value = Challenge2.DiceFacesCalculator(4, 5, 6);
        Assert.Equal(6, value);
    }

    [Fact]
    public void TestCase8()
    {
        var ex = Assert.Throws<Exception>(() => Challenge2.DiceFacesCalculator(7, 6, 5));
        Assert.Equal("Dice out of number range", ex.Message);
    }

    [Fact]
    public void TestCase9()
    {
        var ex = Assert.Throws<Exception>(() => Challenge2.DiceFacesCalculator(0, 6, 5));
        Assert.Equal("Dice out of number range", ex.Message);
    }

    [Fact]
    public void TestCase10()
    {
        var ex = Assert.Throws<Exception>(() => Challenge2.DiceFacesCalculator(-1, 2, 3));
        Assert.Equal("Dice out of number range", ex.Message);
    }
}