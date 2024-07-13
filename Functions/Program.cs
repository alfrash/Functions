internal class Program
{
    // todo: push to github
    private static void Main(string[] args)
    {
        /*
        int [] numbers = [1, 2, 3, 4, 5, 6];
        Console.WriteLine($"average = {CalculateAverage(numbers)}");
        numbers = [10, 20, 30, 40, 50, 60];
        Console.WriteLine($"average = {CalculateAverage(numbers: numbers, true)}");
        int[] x = [100, 200, 300, 400, 500, 600];
        CalculateAverage(x);
        Console.WriteLine($"average = {CalculateAverage(x, true)}");
        */
    }

    

    /// <summary>
    /// Calculate the average for array of integers
    /// </summary>
    /// <param name="numbers">int[] array</param>
    /// <param name="calc"> bool calc the average or not "return 0"</param>
    /// <returns></returns>
    public static double CalculateAverage (int[] numbers, bool calc = false)
    {
        if (calc == true) {
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            double average = sum / numbers.Length;
            return average;
        }else {
            return 0;
        }
        
    }
}