using System;
using System.Diagnostics;

namespace SortingTask
{
    public class Sort
    {
        public static void Main(String[] args)
        {

            string filePath = "C:\\Users\\Xopero\\SortingApp\\text3.txt";

            Console.WriteLine("Choose sorting algorithm:");
            Console.WriteLine("1. Bubblesort");
            Console.WriteLine("2. Quicksort");
            Console.WriteLine("3. Merge sort");
            Console.Write("Enter your choice (1-3): ");

            int choice;
            choice = Convert.ToInt16(Console.ReadLine());

            ISorts<string> sortStrategy = null;

            //strategy choice
            if (choice == 1)
            {
                sortStrategy = new BubblesortStrategy<string>();
            }
            else if (choice == 2)
            {
                sortStrategy = new QuickSortStrategy<string>();
            }
            else if (choice == 3)
            {
                sortStrategy = new MergeSortStrategy<string>();

            }
            else
            {
                Console.WriteLine("Input not valid");
            }

            var sortContext = new Context<string>(sortStrategy);

            // Sort the lines
            try
            {
                Stopwatch stopwatch = new Stopwatch();
                List<string> lines = new List<string>(File.ReadAllLines(filePath));
                int count = 0;
                Console.WriteLine("Sorted file:");
                stopwatch.Start();
                foreach (var line in sortContext.ExecuteStrategy(lines))
                {
                    Console.WriteLine(line);
                    count++;
                }
                stopwatch.Stop();
                if (count ==0 )
                {
                    Console.WriteLine("The list is empty");
                }

                
                Console.WriteLine($"Sorted elements:  {count} ");
                Console.WriteLine($"Sorting time:  {stopwatch.ToString()}");


          
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"File '{filePath}' not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("All elements have been sorted");
            }



        }

    }
}





