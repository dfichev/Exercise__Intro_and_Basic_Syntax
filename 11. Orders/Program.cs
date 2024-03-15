int orders = int.Parse(Console.ReadLine());
double totalPrice = 0;
for (int i = 1; i <= orders; i++)
{
    double pricePerCapsule = double.Parse(Console.ReadLine());
    int days = int.Parse(Console.ReadLine());
    int capsules = int.Parse(Console.ReadLine());
    double orderCost = ((days * capsules) * pricePerCapsule);
    Console.WriteLine($"The price for the coffee is: ${orderCost:F2}");
    totalPrice += orderCost;
}
Console.WriteLine($"Total: ${totalPrice:F2}");