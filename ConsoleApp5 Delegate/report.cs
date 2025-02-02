using System;

namespace ConsoleApp5_Delegate
{
    public class Report
    {
        public delegate bool IlligableSales(Employee e );
        public void ProccessEmployee(Employee[] employee,string title, IlligableSales isilligable)
        {
            Console.WriteLine(title);
            Console.WriteLine("-------------------------------");
           foreach(Employee e in employee)
            {
                if (isilligable(e))
                {
                    Console.WriteLine($"ID {e.Id} Name {e.Name}| Gender {e.Gender}| sales {e.TotalSales}");
                }
            }
            Console.WriteLine("\n\n");
        }
    }
}
