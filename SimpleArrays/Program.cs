using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Arrays *****");
            SimpleArrays();
            ArrayInitialization();
            DeclareImplicitArrays();
            ArrayOfObjects();
            RectMultidimensionalArray();
            JaggedMultidimensionalArray();
            PassAndReceiveArrays();
            SystemArrayFunctionality();
            Console.ReadLine();
        }

        static void SimpleArrays()
        {
            Console.WriteLine("=> SimpleArrays Array Creation.");
            int[] myInts = new int[3];
            myInts[0] = 100;
            myInts[1] = 200;
            myInts[2] = 300;
            string[] booksOnDotNet = new string[100];
            Console.WriteLine();
        }

        static void ArrayInitialization()
        {
            Console.WriteLine("=> Array Initialization");
            string[] stringArray = new string[]
                {"one","two","three"};
            Console.WriteLine("stringArray has {0} elements", stringArray.Length);
            Console.WriteLine($"stringArray has {stringArray.Length} elements");

            //Array init w/o NEW keyword
            bool[] boolArray = { false, false, true };
            Console.WriteLine("boolArray has {0} elements", boolArray.Length);

            //Array init w/ NEW keyword and size
            int[] intArray = new int[4] { 20, 22, 23, 0 };
            Console.WriteLine("intArray has {0} elements", intArray.Length);
            Console.WriteLine();

        }

        static void DeclareImplicitArrays()
        {
            Console.WriteLine("=> Implicit Array Initialization");

            //a is really int[].
            var a = new[] { 1, 10, 100, 1000 };
            Console.WriteLine($"Type of var is {a.GetType()}");
            Console.WriteLine("a is a: {0}", a.ToString());

            //b is really double[].
            var b = new[] { 1, 1.5, 2, 2.5 };
            Console.WriteLine($"b is {b.ToString()}");

            //c is really string[].
            var c = new[] { "hello", "null", "world" };
            Console.WriteLine("c is a: {0}", c.ToString());
            Console.WriteLine();


        }

        static void ArrayOfObjects()
        {
            Console.WriteLine("=> Arrays of Objects");

            object[] objects = new object[4]
            {10,false,new DateTime(1986,10,12), "this is a test" }   ;
            foreach(object o in objects)
            {
                Console.WriteLine("This is an object of type {0} with a value of \"{1}\"", o.GetType(), o);
            }

            Console.WriteLine();
        }

        static void RectMultidimensionalArray()
        {
            Console.WriteLine("=> Rectangular multidimensional array.");
            //A rectangular MD array
            int[,] myMatrix;
            myMatrix = new int[3, 4];

            //Populate 3*4 (rows/columns) array;
            for (int i = 0; i<3;i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    myMatrix[i, j] = i * j;
                }
            }

            //Print 3*4 array;
            for (int i=0;i<3;i++)
            {
                for (int j=0;j<4;j++)
                {
                    Console.Write(myMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void JaggedMultidimensionalArray()
        {
            Console.WriteLine("=> Jagged multidimensional array.");
            //A Jagged MD array (array of arrays)
            //Array of 5 different Array VV
            int[][] myJagArray = new int[5][];
            Console.WriteLine($"myJagArray.length = {myJagArray.Length}");
            //create the jagged array
            for (int i = 0; i < myJagArray.Length; i++)
            {
                myJagArray[i] = new int[i + 7];
            }
            //Print each row (remember, each element is default to zero!)
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < myJagArray.Length; j++)
                {
                    Console.Write(myJagArray[i][j] + " ");

                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void PrintArray(int[] myInts)
        {
            for (int i = 0; i < myInts.Length; i++)
            {
                Console.WriteLine("Item {0} is {1}", i, myInts[i]);
            }
        }

        static string[] GetStringArray()
        {
            string[] theStrings = { "Hello", "from", "GetStringArray" };
            return theStrings;
        }

        static void PassAndReceiveArrays()
        {
            Console.WriteLine("=> Array as params and return values");
            //pass array as parameter.
            int[] ages = { 20, 22, 23, 0 };
            PrintArray(ages);

            //Get array as return value.
            string[] strs = GetStringArray();
            foreach(string s in strs)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
        }

        static void SystemArrayFunctionality()
        {
            Console.WriteLine("=> Working with System.Array.");
            //Initialize items at startup.
            string[] gothicBands = { "Tones on Tail", "Bauhaus", "Sisters of Mercy" };

            //Print out names in declared order.
            Console.WriteLine("Here is the array");
            for(int i = 0; i<gothicBands.Length;i++)
            {
                Console.Write(gothicBands[i] + ", ");
            }
            Console.WriteLine("\n");

            //Reverse them...
            Array.Reverse(gothicBands);
            Console.WriteLine("The reversed array");
            for (int i = 0;i<gothicBands.Length;i++)
            {
                Console.Write(gothicBands[i] + ", ");
            }
            Console.WriteLine("\n");

            //Clear out all but the first one
            Console.WriteLine("Cleared out all but one");
            Array.Clear(gothicBands, 1, 2);

            for (int i =0;i<gothicBands.Length;i++)
            {
                Console.Write(gothicBands[i] + "\n");
            }
            Console.WriteLine();

        }
    }
}
