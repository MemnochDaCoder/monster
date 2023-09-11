namespace Lib.ProblemSolving;

public static class Challenge1
{
    public static Challenge1Result FractionsCalculator(int[] numbers)
    {
        return new Challenge1Result();
    }
}

public class Challenge1Result
{
    public decimal Positives { get; set; }
    public decimal Negatives { get; set; }
    public decimal Zeros { get; set; }
}