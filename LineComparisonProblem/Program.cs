using System.Runtime.CompilerServices;

namespace LineComparisonProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float x1;
            float y1;
            float x2;
            float y2;
            float length;

            Console.WriteLine("Welcome to Line Comparison Computation Program!");

            Console.WriteLine("\tWe will calculate the length on given line based on given points.");

/*            Console.WriteLine("Enter value for i :");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(i);*/

            Console.WriteLine("Please enter Point 1's X (X1):");
            float.TryParse(Console.ReadLine(), out x1);

            Console.WriteLine("Please enter Point 1's Y (Y1):");
            float.TryParse(Console.ReadLine(), out y1);

            Console.WriteLine("Please enter Point 2's X (X2):");
            float.TryParse(Console.ReadLine(), out x2);

            Console.WriteLine("Please enter Point 2's Y (Y2):");
            float.TryParse(Console.ReadLine(), out y2);

            //Console.WriteLine(x1 + " " + x2 + " " + y1 + " " + y2);
            //length = sqrt((x2 - x1)^2 + (y2 - y1)^2);
            length = (float) Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine("Length of given line, is: " + length);

            /*
            String s = "234";
            int sLen = s.Length;
             * String word = "srtg";
            String reword = Convert.ToString(word.Reverse());
            Console.WriteLine(word + " " + reword);*/
        }
    }
}