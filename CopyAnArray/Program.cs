using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyAnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initial array
            int [] list = new int[] { 4, 8, 12, -54, 78, -98, 1, 69, 91, -100};

            //Copying that array
            int [] copy = new int [list.Length];
            for (int index = 0; index < list.Length; index++)
            {
                copy[index] = list[index];
            }

            //Print original array
            for (int index = 0; index <list.Length; index++)
            {
                Console.WriteLine(list[index] + " ");
            }
            Console.WriteLine();

            //Print the copy
            for (int index = 0; index <copy.Length; index++)
            {
                Console.WriteLine(copy[index] + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
