using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Hurricane
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a NUMBER 1-5.");
            int category = Convert.ToInt32(Console.ReadLine());
           
            
            switch (category)
            {
                case 1:
                    Console.WriteLine("A category 1 hurricane is 74-95M/h or 119-153KM/h.");
                    break;

                case 2:
                    Console.WriteLine("A category 2 hurricane is 96-110M/h or 154-177KM/h.");
                    break;

                case 3:
                    Console.WriteLine("A category 3 hurricane is 111-130M/h or 178-209KM/h.");
                    break;

                case 4:
                    Console.WriteLine("A category 4 hurricane is 131-155M/h or 210-249KM/h.");
                    break;

                case 5:
                    Console.WriteLine("A category 5 hurricane is 156+M/h or 249+KM/h.");
                    break;

                default:
                    Console.WriteLine("Unknown Category.");
                    break;
                     

                    

            };
            Console.WriteLine("Press Enter To Close....");
            Console.ReadLine();





        }
    }
}
