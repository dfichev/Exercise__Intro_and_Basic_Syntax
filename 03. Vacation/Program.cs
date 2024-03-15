namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double cost = 0;

            switch (groupType)
            {
                case "Students":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            cost = peopleCount * 8.45;
                            break;
                        case "Saturday":
                            cost = peopleCount * 9.80;
                            break;
                        case "Sunday":
                            cost = peopleCount * 10.46;
                            break;
                    }
                    if (peopleCount >= 30)
                        cost *= 0.85;
                    break;
                case "Business":
                    if (peopleCount >= 100)
                        peopleCount -= 10;
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            cost = peopleCount * 10.90;
                            break;
                        case "Saturday":
                            cost = peopleCount * 15.60;
                            break;
                        case "Sunday":
                            cost = peopleCount * 16.00;
                            break;
                    }
                    break;
                case "Regular":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            cost = peopleCount * 15.00;
                            break;
                        case "Saturday":
                            cost = peopleCount * 20.00;
                            break;
                        case "Sunday":
                            cost = peopleCount * 22.50;
                            break;
                    }
                    if (peopleCount >= 10 && peopleCount <= 20)
                        cost *= 0.95;
                    break;
            }
            Console.WriteLine($"Total price: {cost:F2}");
        }
    }
}