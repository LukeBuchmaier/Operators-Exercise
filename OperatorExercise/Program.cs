using System.ComponentModel.DataAnnotations;
using System.Security.AccessControl;

namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //explicit typing
            string variableName = "Hello";
            //inferred typing
            var varName = "Hello";
            // var is best practice; use this moving forward unless otherwise specified

            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;

            if (a == 17 && b == 4) Console.WriteLine($"{a}/{b} equals {quotient} with a remainder of {remainder}");

          
            Console.WriteLine("Hello, let's calculate the area of a circle! Give me a number for your radius:");
            //Allows user to input radius
            double realRadius;
            bool v = double.TryParse(Console.ReadLine(), out realRadius);
            //Calculate area of circle
            var areaOfCircle = CaculateArea(realRadius);
            Console.WriteLine($"the area of a circle with a radius of {realRadius} is {areaOfCircle}");
                    
        }
        public static double CaculateArea (double radius)
        {
            return Math.PI * (radius * radius);
        }
    }
}