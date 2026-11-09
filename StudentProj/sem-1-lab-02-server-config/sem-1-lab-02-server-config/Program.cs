namespace lab_1_sem_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxUsersCount = 4000;

            Random random = new Random();
            int usersCount = random.Next(50, 4001);
            int serverPing = random.Next(150, 301);
            int usersPing = random.Next(30, 101);
            
            int usersHalfCount = maxUsersCount / 2;
            int usersHalfPing = serverPing / 2;

            string correctName = "name";
            string correctPassword = "123";

            Console.WriteLine("Welcome to server!");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your password: ");
            string password = Console.ReadLine();

            if (name == correctName && password == correctPassword)
            {
                Console.WriteLine("Sucsessful!");
            }
            else
            {
                Console.WriteLine("Password or name is invalid. Sorry, you're not granted access to the server.");
                return;
            }

            Console.Write("Do you wan't to check server status? y/n ");
            string yn = Console.ReadLine();
            if (yn == "n" || yn != "y")
                return;
            else
                Console.WriteLine("OK!");

            Console.WriteLine("");
            Console.WriteLine("Server status");
            Console.WriteLine($"users count: {usersCount}");
            Console.WriteLine($"users ping: {usersPing}ms");
            Console.WriteLine($"server ping: {serverPing}ms");

            string result = "";
            if (usersCount == maxUsersCount || usersPing >= serverPing)
            {
                result = "Server can't be starting";
            }
            else if (usersCount > usersHalfCount || usersPing > usersHalfPing)
            {
                result = "Server can be starting, but under a heavy load";
            }
            else
            {
                result = "Server can be starting";
            }

            Console.WriteLine("");
            Console.WriteLine("Result: ");
            Console.Write(result);
        }
    }
}
