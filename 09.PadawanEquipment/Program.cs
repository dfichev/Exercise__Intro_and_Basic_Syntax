/* •	The amount of money John has – floating-point number in the range [0.00…1000.00].
•	The count of students – integer in the range [0…100].
•	The price of lightsabers for a single saber – floating-point number in the range [0.00…100.00].
•	The price of robes for a single robe – floating-point number in the range [0.00…100.00].
•	The price of belts for a single belt – floating-point number in the range [0.00…100.00].
*/


double budget = double.Parse(Console.ReadLine());
int students = int.Parse(Console.ReadLine());
double lightsaberPrice = double.Parse(Console.ReadLine());
double robePrice = double.Parse(Console.ReadLine());
double beltPrice = double.Parse(Console.ReadLine());

double lightsabersCost = Math.Ceiling(students * 1.1) * lightsaberPrice;
double robeCost = students * robePrice;

int freeBelts = students / 6;

double beltCost = (students - freeBelts) * beltPrice;

double totalCost = lightsabersCost + robeCost + beltCost;

if (totalCost > budget)
{
    Console.WriteLine($" John will need {(totalCost - budget):F2}lv more.");
}
else
{
    Console.WriteLine($"The money is enough - it would cost {totalCost:F2}lv.");
}