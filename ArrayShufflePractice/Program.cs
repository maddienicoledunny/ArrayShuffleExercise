//Madison Dunnavant
//Array Shuffle Problem

using System;

namespace ArrayShufflePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] initialArray = new int[6];
            
            for (int i = 0; i < initialArray.Length; i++)
            {
                Console.WriteLine("Please enter an integer: ");

                //This try-catch block will check to make sure the value of the int entered is not too large or too small. 
                try
                {
                    //This try-catch block will check to make sure only integers are being entered.
                    try
                    {
                        initialArray[i] = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("ERROR: Value entered was not an integer. Please try again.");
                        i--;
                        continue;
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("ERROR: Value is too large or too small. Please try again.");
                    i--;
                    continue;
                }
            }
               
            //This will make print the values of the array in the order they were entered. 
            Console.Write("Values entered: ");
            foreach(int i in initialArray)
            {
                Console.Write(i + " ");
            }
            
            //The built-in Array.Sort will sort the array in ascending order. 
            Array.Sort(initialArray);
            Console.WriteLine();
            Console.Write("Array after sort: ");
            foreach(int j in initialArray)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();

            //Calls the ScrambleArray method 
            ScrambleArray(initialArray);
        }

        public static void ScrambleArray(int [] scramble)
        {
            Random rndm = new Random();
            
            for (int i = scramble.Length - 1; i > 0; i--)
            {
                int j = rndm.Next(0, scramble.Length - 1);

                //The next 3 lines of code will take the integer at index i in the shuffle array and store it in the variable temp. Then, index i will become replaced with the integer at index 
                //j. Lastly, the integer at index j becomes replaced with the integer stored in temp.
                int temp = scramble[i];
                scramble[i] = scramble[j];
                scramble[j] = temp;
            }

            Console.Write("Scrambled array: ");
            foreach (int k in scramble)
            {
                Console.Write(k + " ");
            }

        }
    }
}
