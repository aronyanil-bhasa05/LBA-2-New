using System;

namespace LabBasedAssignment2
{
    //Character to ASCII and Vice Versa
    internal class asciiConversion
    {
        static void Main ()
        {       
            Console.WriteLine("Press 1 for Character to ASCII value conversion");
            Console.WriteLine("Press 2 for ASCII value to Character conversion");
            Console.Write("Enter Option= ");
            int op = Convert.ToInt32(Console.ReadLine());
            if (op==1)
            {
                Console.Write("Enter your Character= ");
                char c=Convert.ToChar(Console.ReadLine());
                int n=Convert.ToInt32 (c);
                Console.WriteLine($"Result= {n}");
                Console.ReadLine();
            }
            else if (op==2)
            {
                Console.Write("Enter your Number= ");
                int n = Convert.ToInt32(Console.ReadLine());
                char c = Convert.ToChar(n);
                Console.WriteLine($"Result= {c}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Wrong Option Selected");
                Console.ReadLine();
            }
        }
    }
}
