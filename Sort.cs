using System;

namespace SortingTask
{
    public class Sort
    {
        public static void Main(String[] args)
        {
           String line;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("/Users/majakozlowska/SortingApp/text1.txt");
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    //write the line to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();
 
                    
                }
                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }



        }

        }
    }





