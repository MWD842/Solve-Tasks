namespace Practice_Task4
{
    internal class Program
    {
        public static void PrintWelcome(string userName)
        {
            
            Console.WriteLine($"Welcome to Spark to Code, {userName}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string userName = Console.ReadLine();

            PrintWelcome(userName);
        }
    }
}
