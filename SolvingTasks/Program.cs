namespace SolvingTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Enter your name:");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter your age:");
            int userAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your height:");
            float userHeight = float.Parse(Console.ReadLine());
            Console.WriteLine("Are you a student? (Trure/False):");
            string isStudent = Console.ReadLine();
            Console.WriteLine($"Name: {userName}, Age: {userAge}, " +
                $"Height: {userHeight}, Student: {isStudent}"); */

            /*Console.WriteLine("Enter the length: ");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width: ");
            double width = double.Parse(Console.ReadLine());

            double area = length * width;
            double perimeter = 2 * (length + width);

            Console.WriteLine("Area: " + area);
            Console.WriteLine("Perimeter: " + perimeter); */

            /* Console.WriteLine("Enter the a number: ");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            } */

            Console.WriteLine("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Do you have a vaild national ID? (yes/no): ");
            string hasValidId = Console.ReadLine();
            if (age >= 18 && hasValidId == "yes")
            {
                Console.WriteLine("You are eligible to vote.");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote.");
            }
        }
}
}
