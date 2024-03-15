namespace _04._Print_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int lastNumber = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = firstNumber; i <= lastNumber; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }
            Console.WriteLine();
            Console.Write($"Sum: {sum}");
        }
    }
}