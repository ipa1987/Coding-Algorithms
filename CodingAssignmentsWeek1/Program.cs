namespace CodingAssignmentsWeek1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter the first positive integer (a): ");
            int a = int.Parse(Console.ReadLine()!);

            Console.Write("Please Enter the second positive integer (b): ");
            int b = int.Parse(Console.ReadLine()!);

            string result = Collatz.CompareCollatzSteps(a, b);
            Console.WriteLine($"The integer that takes fewer steps to reach 1 is: {result}");
        }
    }
}
