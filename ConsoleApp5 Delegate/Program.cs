namespace ConsoleApp5_Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        { 
           
            var emps = new Employee[]
            {
                 new Employee { Id = 1, Name = "Issam A", Gender = "M", TotalSales = 65000m },
                 new Employee { Id = 2, Name = "Reem S", Gender = "F", TotalSales = 50000m },
                 new Employee { Id = 3, Name = "Suzan B", Gender = "F", TotalSales = 65000m },
                 new Employee { Id = 4, Name = "Sara A", Gender = "F", TotalSales = 40000m },
                 new Employee { Id = 5, Name = "Salah C", Gender = "M", TotalSales = 42000m },
                 new Employee { Id = 6, Name = "Rateb A", Gender = "M", TotalSales = 30000m },
                 new Employee { Id = 7, Name = "Abeer C", Gender = "F", TotalSales = 16000m },
                 new Employee { Id = 8, Name = "Marwan M", Gender = "M", TotalSales = 15000m }
            };
            var ob = new Report();
            //With Method
            //ob.ProccessEmployee(emps,"Sales >60000", IsGreaterThanOrEqual60000);
            //ob.ProccessEmployee(emps, "Sales >60000 && Sales>=30000m", IsBetween30000And60000);
            //ob.ProccessEmployee(emps,"Sales >30000", IsLessThan30000);
            ////With Delegate
            //ob.ProccessEmployee(emps,"Sales >60000", delegate (Employee ob1) { return ob1.TotalSales >= 60000m; });
            //ob.ProccessEmployee(emps, "Sales >60000 && Sales>=30000m", delegate (Employee ob1) { return ob1.TotalSales <= 60000m && ob1.TotalSales >= 30000m; });
            //ob.ProccessEmployee(emps, "Sales >30000", delegate (Employee ob1) { return ob1.TotalSales >= 30000m; });
            //Lambda Exepression =>
            ob.ProccessEmployee(emps, "Sales >60000",   ob1=> ob1.TotalSales >= 60000m );
            ob.ProccessEmployee(emps, "Sales >60000 && Sales>=30000m",   ob1 => ob1.TotalSales <= 60000m && ob1.TotalSales >= 30000m );
            ob.ProccessEmployee(emps, "Sales >30000",  ob1 => ob1.TotalSales >= 30000m);
            ob.ProccessEmployee(emps, "ismale",  isMale);
            Console.ReadKey();
        }
        // in compensation for this method we can put delegate (Employee ob1){return ob1.TotalSales >= 60000m}
        //at lambda Exepression You don't need this Methods 
            static bool IsGreaterThanOrEqual60000(Employee ob1) => ob1.TotalSales >= 60000m;
            static bool IsBetween30000And60000(Employee ob1) => ob1.TotalSales <= 60000m&& ob1.TotalSales>=30000m;
            static bool IsLessThan30000(Employee ob1) => ob1.TotalSales >= 30000m;
            static bool isMale(Employee ob1) => ob1.Gender == "M";
    }
}
