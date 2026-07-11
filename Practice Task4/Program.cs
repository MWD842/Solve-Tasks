namespace Practice_Task4
{
    internal class Program
    {
        public static void PrintWelcome(string userName)
        {
            
            Console.WriteLine($"Welcome to Spark to Code, {userName}");
        }

        public static int Square(int number)
        {
            int result = number * number;
            return result;
        }

        static void Main(string[] args)
        {   
            // TASK 1
            //Console.WriteLine("Enter your name: ");
            //string userName = Console.ReadLine();

            //PrintWelcome(userName);


            // TASK 2
            Console.WriteLine("Enter a number to square: ");
            int number = Convert.ToInt32(Console.ReadLine());
            
            int squaredNumber = Square(number);
            Console.WriteLine("The square of " + number + " is: " + squaredNumber);
        }
    }
}
