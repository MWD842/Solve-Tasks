using System.Linq.Expressions;

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

        public static double CelsiusToFahrenheit(double C)
        {
            double F = (C * 9 / 5) + 32;
            return F;
        }

        public static void DisplayMenu()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("Menu\n1) Start\n2) Help\n3) Exit");
                Console.WriteLine("Enter your choice (1-3): ");
                try
                {
                    choice = int.Parse(Console.ReadLine());
                    switch(choice)
                    {
                        case 1:
                            Console.WriteLine("\nStart\n");
                            break;
                        case 2:
                            Console.WriteLine("\nHelp\n");
                            break;
                        case 3:
                            Console.WriteLine("\nExit\n");
                            return;
                    }
                    
                }
                catch
                {
                    Console.WriteLine("\nInvlid input!!\n");
                }
            } while (true);
        }

        public static bool IsEven(int num)
        {
            return num % 2 == 0;
        }

        public static double CalculateArea(double length, double width)
        {
            return length * width;
        }

        public static double CalculatePerimeter(double length, double width)
        {
            return 2 * (length + width);
        }

        static void Main(string[] args)
        {
            // TASK 1
            //Console.WriteLine("Enter your name: ");
            //string userName = Console.ReadLine();

            //PrintWelcome(userName);

            // TASK 2
            //Console.WriteLine("Enter a number to square: ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //int squaredNumber = Square(number);
            //Console.WriteLine("The square of " + number + " is: " + squaredNumber);

            // TASK 3
            //Console.WriteLine("Enter a temperature in Celsius: ");
            //double C = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("The temperature in Fahrenheit is: " + CelsiusToFahrenheit(C));

            // TASK 4
            //DisplayMenu();

            // TASK 5
            //Console.WriteLine("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());

            //if (IsEven(num))
            //{
            //    Console.WriteLine("The number is even");
            //}
            //else
            //{
            //    Console.WriteLine("The number is odd");
            //}

            // TASK 6
            Console.Write("Enter the length: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Enter the width: ");
            double width = double.Parse(Console.ReadLine());

            double area = CalculateArea(length, width);
            double perimeter = CalculatePerimeter(length, width);

            Console.WriteLine($"Area: {area}");
            Console.WriteLine($"Perimeter: {perimeter}");
        }
    }
}
