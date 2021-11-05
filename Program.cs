using System;

namespace Kalkulator_1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculator";
            Console.WriteLine("Author : Yudhitya M. Renandra");
            Console.WriteLine("Fun Project\n");
            Calc();
        }
        static void Calc()
        {
            mathOperation math = new mathOperation();
            double a = 0;
            double b = 0;
            string operation = "0";
            Console.WriteLine("=============CALCULATOR=============\n");
            Console.Write("Input First Number : ");
            try
            {
                a = double.Parse(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                string isNum = "y";
                while (isNum == "y")
                {
                    Console.WriteLine("Only Input Number");
                    Console.Write("Input First Number : ");
                    try
                    {
                        a = double.Parse(Console.ReadLine());
                        isNum = "n";
                    }
                    catch (System.FormatException)
                    {
                        isNum = "y";
                    }  
                }
            }
            
            Console.Write("Input Second Number : ");
            try
            {
                b = double.Parse(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                string isNum = "y";
                while (isNum == "y")
                {
                    Console.WriteLine("Only Input Number");
                    Console.Write("Input Second Number : ");
                    try
                    {
                        b = double.Parse(Console.ReadLine());
                        isNum = "n";
                    }
                    catch (System.FormatException)
                    {
                        isNum = "y";
                    }
                }
            }
            
            Console.WriteLine("List of operation ");
            Console.WriteLine("[1] Addition         (+)");
            Console.WriteLine("[2] Subtraction      (-)");
            Console.WriteLine("[3] Multiplication   (*)");
            Console.WriteLine("[4] Division         (/)");
            Console.Write("Select an operation(1/2/3/4) : ");
            
            operation = Console.ReadLine();
        
            while (operation != "1" && operation != "2" && operation != "3" && operation != "4" )
            {
                Console.WriteLine("Your choice is not available");
                Console.Write("Select an operation(1/2/3/4) : ");
                operation = Console.ReadLine();
            }
            
            double Result= 0;
            switch (operation)
            {
                case "1":
                Result= math.Add(a,b);
                Console.WriteLine($"Result {a} + {b} = {Result}"); 
                break;
                
                case "2":
                Result= math.Minus(a,b);
                Console.WriteLine($"Result {a} - {b} = {Result}"); 
                break;

                case "3":
                Result= math.Times(a,b);
                Console.WriteLine($"Result {a} * {b} = {Result}"); 
                break;

                case "4":
                if (b == 0)
                {
                    Console.WriteLine("Cant divided by zero(0)");
                }
                else
                {
                    Result= math.Divided(a,b);
                    Console.WriteLine($"Result {a} / {b} = {Result}"); 
                }
                break;
            }
            Console.WriteLine();
            againCount();

            Console.ReadKey();
        }
        static void againCount()
        {
            Console.Write("Do you still want to count?(y/n) : ");
            string again = Console.ReadLine();
            if (again == "y")
            {
                Calc();
            }
            else
            {
                Environment.Exit(0);
            }
        }
    
    }
    class mathOperation
    {
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Minus(double a, double b)
        {
            return a - b;
        }
        public double Times(double a, double b)
        {
            return a * b;
        }
        public double Divided(double a, double b)
        {
            return a / b;
        }
    }
}
