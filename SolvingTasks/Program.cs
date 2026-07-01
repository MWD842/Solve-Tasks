namespace SolvingTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter your age:");
            int userAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your height:");
            float userHeight = float.Parse(Console.ReadLine());
            Console.WriteLine("Are you a student? (Trure/False):");
            string isStudent = Console.ReadLine();
            Console.WriteLine($"Name: {userName}, Age: {userAge}, " +
                $"Height: {userHeight}, Student: {isStudent}");
        }
    }
}
