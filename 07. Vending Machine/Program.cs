using System.Reflection.Metadata.Ecma335;

namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sum = 0;

            while (input != "Start")
            {
                double coinType = double.Parse(input);

                if (coinType == 0.1 || coinType == 0.2 || coinType == 0.5 || coinType == 1 || coinType == 2)
                {
                    sum += coinType;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coinType}");
                }
                input = Console.ReadLine();
            }
            
            string product = Console.ReadLine();

            while (product != "End")
            {
                if (product == "Nuts")
                {
                    if (sum >= 2)
                    {
                        sum -= 2;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");                       
                    }

                }
                else if (product == "Water")
                {
                    if (sum >= 0.7)
                    {
                        sum -= 0.7;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }

                }
                else if (product == "Crisps")
                {
                    if (sum >= 1.5)
                    {
                        sum -= 1.5;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Soda")
                {
                    if (sum >= 0.8)
                    {
                        sum -= 0.8;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Coke")
                {
                    if (sum >= 1.0)
                    {
                        sum -= 1.0;
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else 
                {
                    Console.WriteLine("Invalid product");
                }
                product = Console.ReadLine();

            }
            Console.WriteLine($"Change: {sum:F2}");
       
        }


    }
}