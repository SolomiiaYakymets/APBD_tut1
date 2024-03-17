namespace Tutorial1;

public class Utility
{
    public static double CalculateAverage(int[] n)
    {
        return (double)n.Sum() / n.Length;
    }
    
    public static int FindMax(int[] number)
    {
        return number.Max();
    }
}
