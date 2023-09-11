namespace Lib.ProblemSolving.Test;

public class Challenge3Test
{
    [Fact]
    public void TestCase1()
    {
        var value = Challenge3.FindLessCostPath(new int[][]
        {
            new int[] { 42, 51, 22, 10, 0 },
            new int[] { 2, 50, 7, 6, 15 },
            new int[] { 4, 36, 8, 30, 20 },
            new int[] { 0, 40, 10, 100, 1 }
        });
        Assert.Equal(140, value);
    }

    [Fact]
    public void TestCase2()
    {
        var value = Challenge3.FindLessCostPath(new int[][]
        {
            new int[] { 77, 43, 89, 88, 72, 20 },
            new int[] { 10, 72, 98, 39, 30, 6 },
            new int[] { 34, 39, 81, 23, 83, 30 },
            new int[] { 8, 64, 86, 51, 69, 46 },
            new int[] { 56, 21, 5, 3, 25, 62 },
            new int[] { 12, 98, 66, 92, 83, 25 },
        });
        Assert.Equal(301, value);
    }

    [Fact]
    public void TestCase3()
    {
        var value = Challenge3.FindLessCostPath(new int[][]
        {
            new int[] { 61, 86, 59, 80, 71, 70, 99, 55 },
            new int[] { 48, 49, 85, 9, 50, 93, 40, 0 },
            new int[] { 34, 61, 26, 32, 11, 18, 2, 1 },
            new int[] { 51, 76, 65, 91, 74, 39, 91, 77 },
            new int[] { 78, 96, 33, 49, 94, 75, 47, 29 },
            new int[] { 96, 55, 74, 39, 28, 88, 57, 4 },
            new int[] { 65, 13, 86, 95, 69, 88, 1, 88 },
            new int[] { 85, 7, 30, 74, 40, 78, 3, 75 },
        });
        Assert.Equal(465, value);
    }

    [Fact]
    public void TestCase4()
    {
        var value = Challenge3.FindLessCostPath(new int[][]
        {
            new int[] { 42 }
        });
        Assert.Equal(0, value);
    }

    [Fact]
    public void TestCase5()
    {
        var value = Challenge3.FindLessCostPath(new int[][]
        {
            new int[] { 20, 1, 49, 64, 98, 4, 14, 50, 12, 82, 11, 36, 64, 93, 13, 39 },
            new int[] { 52, 85, 39, 77, 98, 33, 88, 84, 22, 40, 66, 13, 41, 18, 44, 44 },
            new int[] { 85, 23, 80, 61, 64, 16, 73, 19, 18, 45, 87, 84, 58, 25, 74, 28 },
            new int[] { 4, 51, 33, 99, 70, 76, 65, 85, 55, 9, 87, 42, 19, 34, 56, 71 },
            new int[] { 82, 81, 6, 22, 63, 30, 28, 51, 75, 38, 22, 23, 68, 65, 1, 3 },
            new int[] { 64, 1, 94, 63, 49, 53, 88, 9, 75, 25, 75, 60, 27, 58, 41, 57 },
            new int[] { 26, 14, 100, 100, 26, 95, 55, 78, 58, 95, 18, 3, 61, 25, 57, 98 },
            new int[] { 20, 57, 91, 21, 52, 1, 58, 42, 49, 2, 20, 28, 54, 34, 65, 39 },
            new int[] { 55, 72, 34, 66, 52, 0, 33, 5, 15, 20, 13, 98, 7, 40, 12, 47 },
            new int[] { 89, 43, 99, 33, 20, 67, 86, 70, 62, 78, 98, 80, 47, 3, 45, 98 },
        });
        Assert.Equal(704, value);
    }

    [Fact]
    public void TestCase6()
    {
        var value = Challenge3.FindLessCostPath(new int[][]
        {
            new int[] { 61, 58, 36, 35, 24, 59, 60, 40, 37, 1 },
            new int[] { 75, 98, 27, 42, 30, 12, 45, 87, 42, 41 },
            new int[] { 98, 86, 11, 70, 100, 48, 66, 33, 0, 85 },
            new int[] { 95, 90, 1, 73, 68, 42, 64, 92, 41, 74 },
            new int[] { 76, 72, 5, 20, 50, 82, 74, 98, 50, 52 },
            new int[] { 82, 75, 60, 70, 21, 64, 27, 35, 45, 100 },
            new int[] { 20, 70, 40, 22, 1, 50, 4, 22, 57, 13 },
            new int[] { 45, 2, 15, 84, 7, 67, 36, 75, 98, 40 },
            new int[] { 65, 15, 53, 95, 23, 5, 94, 65, 89, 48 },
            new int[] { 77, 7, 63, 28, 62, 16, 86, 99, 12, 79 },
            new int[] { 53, 66, 52, 25, 50, 88, 72, 92, 15, 28 },
            new int[] { 6, 61, 39, 62, 88, 32, 87, 29, 80, 3 },
            new int[] { 52, 1, 29, 63, 30, 20, 48, 5, 8, 58 },
            new int[] { 92, 33, 88, 7, 63, 90, 95, 34, 61, 90 },
            new int[] { 33, 19, 78, 92, 51, 96, 93, 70, 55, 86 },
            new int[] { 86, 92, 86, 27, 50, 22, 23, 61, 55, 37 },
            new int[] { 38, 23, 64, 95, 28, 72, 63, 57, 7, 92 },
            new int[] { 82, 76, 36, 60, 99, 77, 100, 22, 64, 26 },
            new int[] { 22, 68, 1, 19, 7, 68, 53, 75, 2, 69 },
            new int[] { 90, 15, 72, 96, 87, 59, 27, 15, 4, 38 },
        });
        Assert.Equal(791, value);
    }

    [Fact]
    public void TestCase7()
    {
        var value = Challenge3.FindLessCostPath(new int[][]
        {
            new int[] { 42, 35, 16 },
            new int[] { 15, 84, 32 },
            new int[] { 99, 0, 17 },
        });
        Assert.Equal(125, value);
    }

    [Fact]
    public void TestCase8()
    {
        var value = Challenge3.FindLessCostPath(new int[][]
        {
            new int[] { 65, 15, 53, 95, 23, 5, 94, 65, 89, 48 },
            new int[] { 77, 7, 63, 28, 62, 16, 86, 99, 12, 79 },
            new int[] { 53, 66, 52, 25, 50, 88, 72, 92, 15, 28 },
            new int[] { 6, 61, 39, 62, 88, 32, 87, 29, 80, 3 },
            new int[] { 52, 1, 29, 63, 30, 20, 48, 5, 8, 58 },
            new int[] { 92, 33, 88, 7, 63, 90, 95, 34, 61, 90 },
            new int[] { 33, 19, 78, 92, 51, 96, 93, 70, 55, 86 },
            new int[] { 86, 92, 86, 27, 50, 22, 23, 61, 55, 37 },
        });
        Assert.Equal(589, value);
    }

    [Fact]
    public void TestCase9()
    {
        var value = Challenge3.FindLessCostPath(new int[][]
        {
            new int[] { 82, 81, 6, 22, 63, 30, 28, 51, 75, 38, 22, 23, 68, 65, 1, 3 },
            new int[] { 64, 1, 94, 63, 49, 53, 88, 9, 75, 25, 75, 60, 27, 58, 41, 57 },
            new int[] { 26, 14, 100, 100, 26, 95, 55, 78, 58, 95, 18, 3, 61, 25, 57, 98 },
            new int[] { 20, 57, 91, 21, 52, 1, 58, 42, 49, 2, 20, 28, 54, 34, 65, 39 },
        });
        Assert.Equal(734, value);
    }

    [Fact]
    public void TestCase10()
    {
        var value = Challenge3.FindLessCostPath(new int[][]
        {
            new int[] { 34, 61, 26, 32, 11, 18, 2, 1 },
            new int[] { 51, 76, 65, 91, 74, 39, 91, 77 },
            new int[] { 78, 96, 33, 49, 94, 75, 47, 29 },
            new int[] { 96, 55, 74, 39, 28, 88, 57, 4 },
        });
        Assert.Equal(291, value);
    }
}