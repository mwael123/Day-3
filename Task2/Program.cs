using System.Collections;
using System.Collections.Generic;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char choice = 'T';
            List<int> numbers = new List<int>();
           
            do
            {
                string formattedList = "str";
                Console.WriteLine("-----------------------------------------------------------------");
                Console.WriteLine("P - Print numbers");
                Console.WriteLine("A - Add a number");
                Console.WriteLine("M - Display mean of the numbers");
                Console.WriteLine("S - Display the smallest number");
                Console.WriteLine("L - Display the largest number");
                Console.WriteLine("C - Clear");
                Console.WriteLine("F - Find");
                Console.WriteLine("Q - Quite");
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine("Enter your choice");
                choice = char.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 'P':
                    case 'p':
                        if (numbers == null || numbers.Count == 0)
                        {
                            Console.WriteLine("[] - the list is empty");

                        }
                        else
                        {
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                formattedList = string.Join(" ", numbers);
                            }

                            Console.WriteLine($"[{formattedList}]");


                        }
                        break;

                    case 'A':
                    case 'a':
                        Console.WriteLine("Enter num to be added here");
                        int Addnum = int.Parse(Console.ReadLine());
                        bool isduplicate = false;

                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if(numbers[i] == Addnum)
                            {
                                isduplicate = true;
                                break;
                            }
                        }
                        if (isduplicate)
                        {
                            Console.WriteLine($"{Addnum} is already in the list.");
                        }
                        else
                        {
                            numbers.Add(Addnum);
                            Console.WriteLine($"{Addnum} added.");
                        }
                        break;
                    case 'M':
                    case 'm':
                        if(numbers==null || numbers.Count == 0)
                        {

                            Console.WriteLine("Unable to calculate the mean - no data");
                        }
                        else
                        {
                         int sum = 0;
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                sum += numbers[i]; 
                            }
                            double mean = (double)sum / numbers.Count;
                            Console.WriteLine($"Mean = {mean}");

                        }
                        break;
                    case 'S':
                    case 's':
                        if(numbers==null || numbers.Count == 0)
                        {

                            Console.WriteLine("The list is empty");
                        }
                        else
                        {
                         int smallest = numbers[0];
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] < smallest)
                                {

                                    smallest = numbers[i];
                                }


                            }
                            Console.WriteLine($"th smallest number is  {smallest}");

                        }
                        break;
                    case 'L':
                    case 'l':
                        if(numbers==null || numbers.Count == 0)
                        {

                            Console.WriteLine("The list is empty");
                        }
                        else
                        {
                         int largest = numbers[0];
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] > largest)
                                {

                                    largest = numbers[i];
                                }


                            }
                            Console.WriteLine($"the largest number is  {largest}");

                        }
                        break;
                    case 'C':
                    case 'c':
                        if(numbers==null || numbers.Count == 0)
                        {

                            Console.WriteLine("The list is already empty");
                        }
                        else
                        {
                            numbers.Clear();
                            Console.WriteLine("Cleared sucessfully");
                            
                        }
                        break;
                    case 'F':
                    case 'f':
                        
                        Console.WriteLine("Enter number to search for:");
                        int searchNum = int.Parse(Console.ReadLine());

                        if (numbers == null || numbers.Count == 0)
                        {

                            Console.WriteLine("The list is empty");
                        }
                        else
                        {
                            bool found = false;
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] == searchNum)
                                {
                                    Console.WriteLine($"Number {searchNum} found at index {i}.");
                                    found = true;
                                    break;
                                }
                            }

                            if (!found)
                            {
                                Console.WriteLine($"Number {searchNum} not found in the list.");
                            }
                        }
                        break;
                    case 'Q':
                    case 'q':
                        Console.WriteLine("Goodbye");
                        break;
                     
                }
            }
            while (choice != 'Q' && choice != 'q');


        }
    }
}
