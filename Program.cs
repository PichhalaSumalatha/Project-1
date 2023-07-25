 using System;
 using System.IO;

namespace StudentDataRetrieval
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Path to the text file
            string filePath = "D:Student_Data.txt";

            // Check if the file exists
            if (File.Exists(filePath))
            {
                // Read all lines from the file
                string[] lines = File.ReadAllLines(filePath);

                // Display the student data
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("Student data file not found!");
            }

            Console.ReadLine();
        }

    }

}


