namespace Tutorial1;

public class Utility
{
    public static double CalculateAverage(int[] number)
    {
        return (double)number.Sum() / number.Length;
    }
    
    public static int FindMax(int[] number)
    {
        return number.Max();
    }
}
