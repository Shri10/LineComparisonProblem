using System.Drawing;
using System.Runtime.CompilerServices;

namespace LineComparisonProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program!");

            Console.WriteLine("\tWe will calculate if the given 2 lines are equal based on given points.");

            var line1 = GetLine(1);
            var line2 = GetLine(2);

            int comparisonResult = line1.CompareTo(line2);

            Console.WriteLine("\tLength of Line 1: " + line1.Length + " & Length of Line 2: " + line2.Length + "\n");
            if (comparisonResult == 0)
            {
                Console.WriteLine("\tLine 1 & Line 2 are EQUAL (Based on their Length)");
            }
            else if (comparisonResult > 0)
            {
                Console.WriteLine("\tLength of Line 1 is greater than Line 2.");
            }
            else
            {
                Console.WriteLine("\tLength of Line 2 is greater than Line 1.");
            }
        }

        static Line GetLine(int lineNumber)
        {
            Console.WriteLine($"Please enter Line {lineNumber}'s Point 1's X (X1):");
            float x1 = float.Parse(Console.ReadLine());

            Console.WriteLine($"Please enter Line {lineNumber}'s Point 1's Y (Y1):");
            float y1 = float.Parse(Console.ReadLine());

            Console.WriteLine($"Please enter Line {lineNumber}'s Point 2's X (X2):");
            float x2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"Please enter Line {lineNumber}'s Point 2's Y (Y2):");
            float y2 = float.Parse(Console.ReadLine());

            var startPoint = new Point(x1, y1);
            var endPoint = new Point(x2, y2);

            return new Line(startPoint, endPoint);
        }

    }


    public class Point
    {
        public float X { get; }
        public float Y { get; }

        public Point(float x, float y)
        {
            X = x;
            Y = y;
        }
    }

    public class Line
    {
        public Point StartPoint { get; }
        public Point EndPoint { get; }
        public float Length { get; }

        public Line(Point startPoint, Point endPoint)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
            Length = CalculateLength();
        }

        private float CalculateLength()
        {
            return (float)Math.Sqrt(Math.Pow(EndPoint.X - StartPoint.X, 2) + Math.Pow(EndPoint.Y - StartPoint.Y, 2));
        }

        public int CompareTo(Line otherLine)
        {
            return Length.CompareTo(otherLine.Length);
        }
    }

}