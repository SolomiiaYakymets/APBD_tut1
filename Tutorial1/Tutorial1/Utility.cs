namespace Tutorial1;

public class Utility
{
    public static double CalculateAverage(int[] num)
    {
        return (double)num.Sum() / num.Length;
    }
    
    public static int FindMax(int[] number)
    {
        return number.Max();
    }
}
