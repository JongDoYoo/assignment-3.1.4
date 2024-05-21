using System.ComponentModel.Design;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace assignment_3._1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the value of X: ");
            double valueOfX = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input the value of Y: ");
            double valueOfY = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The coordinate point " + (valueOfX, valueOfY) + "lies in the " + Quadrant(valueOfX, valueOfY));
        }
        static string Quadrant(double x, double y) 
        {
            if (x > 0 && y > 0)
            {
                return "Quadrant 1";
            }
            else if(x < 0 && y > 0)
            {
                return "Quadrant 2";
            }
            else if (x < 0 && y < 0)
            {
                return "Quadrant 3";
            }
            else 
            {
                return "Quadrant 4";
            }

        }
    }
}
