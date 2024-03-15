namespace _10._RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
                    /*•	On the first input line – lost games count – integer in the range [0…1000].
                    •	On the second line – headset price – floating-point number in the range [0…1000].
                    •	On the third line – mouse price – floating-point number in the range [0…1000].
                    •	On the fourth line – keyboard price – floating-point number in the range [0…1000].
                    •	On the fifth line – display price – floating-point number in the range [0… 1000].
                    */

            int gamesLost = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double headsetCost = (gamesLost / 2) * headsetPrice;
            double mouseCost = (gamesLost / 3) * mousePrice;
            double keyboardCost = (gamesLost / 6) * keyboardPrice;
            double displayCost = (gamesLost / 12) * displayPrice;

            double totalCost = (headsetCost + mouseCost + keyboardCost + displayCost);

            Console.WriteLine($"Rage expenses: {totalCost:F2} lv.");
        }

    }
}