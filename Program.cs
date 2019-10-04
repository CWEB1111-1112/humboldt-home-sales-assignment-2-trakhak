using System;

namespace humboldt_home_sales_assignment_2_trakhak
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARATIONS
            string initial; 
            double total;
            string Silas = S&s, Noah = N&n, Chris = C&c;
            int SilasTotal, NoahTotal, ChrisTotal;
            int sum = Silas + Noah + Chris;
            int EXIT = Z&z;

            Console.WriteLine("Welcome to Humboldt Home Sales Agent Performance Calculator");
            Console.WriteLine("Please enter initials")
            
            while(initial != EXIT){

                if((initial = Silas)){
                Console.WriteLine("Enter sale amount");
                SilasTotal = Convert.ToInt32(Console.ReadLine());
                }

                else((initial = Noah)){
                Console.WriteLine("Enter sale amount");
                NoahTotal = Convert.ToInt32(Console.ReadLine());
                }

                else((initial = Chris)){
                Console.WriteLine("Enter sale amount");
                ChrisTotal = Convert.ToInt32(Console.ReadLine());
                }

                total = SilasTotal + NoahTotal + ChrisTotal

                Console.WriteLine("Enter initials");
                
            }

            Console.WriteLine("total all together =" + total "Silas =" + SilasTotal + "Noah =" + NoahTotal + "Chris =" + ChrisTotal);

            Console.WriteLine("Program has concluded");

        }
    }
}
