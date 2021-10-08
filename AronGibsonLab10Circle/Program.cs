using System;

namespace AronGibsonLab10Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            int circlesCalculated=0; 
            int num=0;
            string again="y";
            do
            {
                circlesCalculated += 1;
                Circle c = new Circle(IntValidator());    
                Console.WriteLine($"Circumference {c.CalculateFormattedCircumference()}");
                Console.WriteLine($"Area: {c.CalculateFormattedArea()}");
                again = AgainValidator();
            } while (again=="y");

            Console.WriteLine($"goodbye, You created {circlesCalculated} circle objects");

        }
        public static int IntValidator()
        {
            do
            {
                Console.WriteLine("enter radius ");
                try
                {
                    int num = int.Parse(Console.ReadLine());
                    return num;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Must enter a number.");              
                }
            } while (true);     
        }

        public static string AgainValidator()
        {
            do
            {
                Console.WriteLine("Enter radius for another circle? y or n.");
                string again = Console.ReadLine();
                if (again == "y")
                    return again;
                else if (again == "n")
                    return again;
                Console.WriteLine("Must enter y or n");
            } while (true);
        }


    }
}
