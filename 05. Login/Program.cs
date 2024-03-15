namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";

            for (int i = username.Length - 1; i >= 0; i--)
            {
                
                password += username[i];
            }

            int attempts = 0;

            while (attempts < 4)
            {
                string currentPassword = Console.ReadLine();
                attempts++;

                if (password == currentPassword)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else if (attempts == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                }
                else if (password != currentPassword) 
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                
            }
        }
    }
}