using System;

namespace humboldt_home_sales_assignment_2_trakhak
{
    //Khali Tran
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARATIONS
            string initial;
            double total;

            int sale;

            int SilasTotal, NoahTotal, ChrisTotal;
            int sum = Silas + Noah + Chris;

            string char = "S" | "s" | "N" | "n" | "C" | "c";
            string EXIT = "Z" | "z";

            Console.WriteLine("Welcome to Humboldt Home Sales Agent Performance Calculator");
            Console.WriteLine("Please enter initials");
            initial = Console.ReadLine();

            while (initial != EXIT)
            {

                while (initial != char)
                {
                    Console.WriteLine("Invalid initials, please enter initials");
                    initial = Console.ReadLine();

                }

                Console.WriteLine($"Your Initials are {initial}. Please Enter amount of sale:");
                sale = Convert.ToInt32(Console.ReadLine());

                while (sale != EXIT)
                {
                    Console.WriteLine("Enter amount of sales");
                    sale = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine($"Your total sales is {total}. now lets show who had the highest total");

                Console.WriteLine("To run the program again please enter initials");
                initial = Convert.ToInt32(Console.ReadLine());
            }


        }

