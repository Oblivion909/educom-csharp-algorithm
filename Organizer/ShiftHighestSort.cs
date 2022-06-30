using System.Collections.Generic;

namespace Organizer
{
    public class ShiftHighestSort
    {
        //Calls to the Program class
        public Program program;
        private List<int> array;
        
        public List<int> Sort(List<int> input)
        {
            //Gets an unsorted list in the input parameter and tell it how to sort
            this.array = new List<int>(input);
            program.SortFunction(this.array, -99, array.Count - 1);
            return this.array;
        }
      
    }
}
