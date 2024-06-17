using System;
using System.Diagnostics;


/**
 * BubbleSort sortuje każdy element osobno. To przy dużych setach danych może sprawia, że jest on bardzo niewydajny.
 * 
 * QuickSort wybiera jeden element jako pivot i rozdziela array dookoła niego przestawiając pivot
 * na właściwe posortowane miejsce. Nie jest to najlepszy wybór na mniejsze sety danych, jednak radzi sobie świetnie 
 * przy większych plikach. 
 * 
 * 
 * Merge Sort dzieli dane na mniejsze części do momentu kiedy nie mogą zostać podzielone. Potem łączy je ze sobą 
 * w jedną posortowaną array. Działa dobrze przy mniejszych jak i większych setach danych. 
 */
namespace SortingTask
{
    public class Sort
    {
        public static void Main(String[] args)
        {
            

            //  string filePath = "C:\Users\Xopero\SortingApp\TestFiles\text1.txt";

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
                sortStrategy = new Bubblesort<string>();
            }
            else if (choice == 2)
            {
                sortStrategy = new QuickSort<string>();
            }
            else if (choice == 3)
            {
                sortStrategy = new MergeSort<string>();

            }
            else
            {
                Console.WriteLine("Input not valid");
            }

            var sortContext = new Context<string>(sortStrategy);

            Console.WriteLine("Enter a file path of a file you want to sort: ");
            string filePath = Console.ReadLine();

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



        }

    }
}





