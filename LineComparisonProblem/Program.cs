using System.Runtime.CompilerServices;

namespace LineComparisonProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Line 1
            float xA1;
            float yA1;
            float xA2;
            float yA2;
            float length1;
            //Line 1 Over

            //Line 2
            float xB1;
            float yB1;
            float xB2;
            float yB2;
            float length2;
            //Line 2 Over

            Console.WriteLine("Welcome to Line Comparison Computation Program!");

            Console.WriteLine("\tWe will calculate if the given 2 lines are equal based on given points.");

            //Line 1
            Console.WriteLine("Please enter Line 1's Point 1's X (X1):");
            float.TryParse(Console.ReadLine(), out xA1);

            Console.WriteLine("Please enter Line 1's Point 1's Y (Y1):");
            float.TryParse(Console.ReadLine(), out yA1);

            Console.WriteLine("Please enter Line 1's Point 2's X (X2):");
            float.TryParse(Console.ReadLine(), out xA2);

            Console.WriteLine("Please enter Line 1's Point 2's Y (Y2):");
            float.TryParse(Console.ReadLine(), out yA2);

            length1 = (float)Math.Sqrt(Math.Pow(xA2 - xA1, 2) + Math.Pow(yA2 - yA1, 2));

            Console.WriteLine("Length of Line 1, is: " + length1 + "\n");
            //Line 1 Over

            //Line 2
            Console.WriteLine("Please enter Line 2's Point 1's X (X1):");
            float.TryParse(Console.ReadLine(), out xB1);

            Console.WriteLine("Please enter Line 2's Point 1's Y (Y1):");
            float.TryParse(Console.ReadLine(), out yB1);

            Console.WriteLine("Please enter Line 2's Point 2's X (X2):");
            float.TryParse(Console.ReadLine(), out xB2);

            Console.WriteLine("Please enter Line 2's Point 2's Y (Y2):");
            float.TryParse(Console.ReadLine(), out yB2);

            length2 = (float)Math.Sqrt(Math.Pow(xB2 - xB1, 2) + Math.Pow(yB2 - yB1, 2));

            Console.WriteLine("Length of Line 2, is: " + length2 + "\n");
            //Line 2 Over

            //Checking if Line1 length is same as Line2 length
            Console.WriteLine("\tLength of Line 1: "+length1 + " & Length of Line 2: "+length2 + "\n");
            if (length1.Equals(length2))
            {
                Console.WriteLine("\tLine 1 & Line 2 are EQUAL (Based on their Length)");
            }
            else
            { 
                Console.WriteLine("\tLine 1 & Line 2 are NOT EQUAL (Based on their Length)");
            }
        }
    }
}