using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizer
{
    public class Program
    {
        public static void Main(string[] _)
        {
            //Calls to the Program and the ShiftHighestSort classes.
            Program program = new Program();
            ShiftHighestSort sortByHighest = new ShiftHighestSort();
            //Makes a new list with 10 items.
            List<int> unsortedList = program.RandomIntGenerator(10);     
        }

        public List<int> RandomIntGenerator(int n)
        {
            //Calls to the ShiftHighestSort class
            ShiftHighestSort sortByHighest = new ShiftHighestSort();
            //Sets a maximum and a minimum number for the random number generator.
            int min = -99;
            int max = 99;
            //randomizes 10 integers and adds them to the list.
            Random random = new Random();
            List<int> numbers = new List<int>();
            Console.WriteLine("Unsorted list:");
            for (int i = 0; i < n; i++)
            {
                numbers.Add(random.Next(min, max));
            }
            //Prints the unsorted list.
            numbers.ForEach(i => Console.Write("{0}\t", i));
            //Call to the sort function
            SortFunction(numbers, -99, 99);
            return numbers;
        }

        public void SortFunction(List<int> list, int min, int max)
        {
            //Sorts the list that is given in the parameter on an ascending scale.
            Console.WriteLine("\n");
            Console.WriteLine("Sorted list:");
            //Prints the sorted list.
            list.Sort();
            list.ForEach(i => Console.Write("{0}\t", i));
            Console.ReadKey();
        }

    }
}
