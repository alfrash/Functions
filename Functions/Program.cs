using System.Runtime.CompilerServices;

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

        ArrayFindings();
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

    static void ArrayFindings()
    {
        Console.Write("Enter number of items: ");
        int arraySize = int.Parse(Console.ReadLine()!);
        int[] numbers = new int[arraySize];
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write($"enter item {i + 1} :");
            numbers[i] = int.Parse(Console.ReadLine()!);
        }
        int sum = 0;
        int smallestNumber = int.MaxValue;
        int greatestNumber = int.MinValue;
        foreach (var number in numbers)
        {
            sum += number;
            if (number < smallestNumber){
                smallestNumber = number;
            }
            if (number > greatestNumber){
                greatestNumber = number;
            }
        }   
        var average = sum / numbers.Length;
        Console.WriteLine($"Average = {average}");
        Console.WriteLine($"smallest number = {smallestNumber}");
        Console.WriteLine($"greatest number = {greatestNumber}");
    }
}