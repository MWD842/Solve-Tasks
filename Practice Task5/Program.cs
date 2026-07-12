namespace Practice_Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            //int[] grades = new int[5];


            //for (int i = 0; i < grades.Length; i++)
            //{
            //    Console.Write($"Enter grade {i + 1}: ");
            //    grades[i] = int.Parse(Console.ReadLine());
            //}

            //// Output: foreach loop
            //Console.WriteLine("\nGrades entered:");
            //foreach (int grade in grades)
            //{
            //    Console.WriteLine(grade);
            //}

            // Task 2
            List<string> tasks = new List<string>();

            // Input: add 5 tasks to the list
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter task {i + 1}: ");
                string task = Console.ReadLine();
                tasks.Add(task);
            }

            // Output: print every task
            Console.WriteLine("\nYour to-do list:");
            int number = 1;
            foreach (string task in tasks)
            {
                Console.WriteLine($"{number}. {task}");
                number++;

            }

        }
    }
}
