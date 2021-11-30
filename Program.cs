using System;

namespace LabBasedAssignment2
{
    // Area of Circle
    internal class Circle
    {
        static void Main(string[] args)
        {
            Console.Write("ENTER A RADIUS= ");
            int r=Convert.ToInt32(Console.ReadLine());
            double a = r * r * 3.14;
            Console.WriteLine($"AREA OF CIRCLE= {a}");
            Console.ReadLine();
        }
    }
}