using System.Security;

namespace _06._Strong_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                int factoriels = 1;

                int currentNumber = int.Parse(number[i].ToString());

                for (int j = 1; j <= currentNumber; j++)
                {
                    factoriels *= j;
                }
                sum += factoriels;
            }
            
            if (sum == int.Parse(number)) 
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            
            
            
        }
    }
}