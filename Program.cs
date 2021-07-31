using System;

namespace Line_Comparision
{
    class Program
    {
        static void Main(string[] args)
        {
            LineComparison lineComparison1 = new LineComparison(1.2, 2.3, 4.5, 3.2);
            distance1 = lineComparison1.Length();
            LineComparison lineComparison2 = new LineComparison(1.0, 2.5, 3.5, 1.2);
            distance2 = lineComparison2.Length();
            if (distance1.CompareTo(distance2) > 0)
                Console.WriteLine("The length of first line is greater than second line.");
            else if (distance1.CompareTo(distance2) < 0)
                Console.WriteLine("The length of first line is less than second line.");
            else
                Console.WriteLine("Both the lines are equal.");
        }
        static void Main(string[] args)
        {
            Program.CheckLine();

        }
    }
}
