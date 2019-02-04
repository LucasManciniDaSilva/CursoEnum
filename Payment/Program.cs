using System;
using Payment.Entities;
using Payment.Entities.Enums;
namespace Payment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Department´s name:  ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter the Worker data:  ");
            Console.Write("Enter the worker name:  ");
            string name = Console.ReadLine();
            Console.Write("Enter the worker level (Junior/MidLevel/Senior):  ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Enter the Base Salary:   ");
            double salary = double.Parse(Console.ReadLine());

            Department dep = new Department(deptName);
            Worker worker = new Worker(name, level, salary, dep);


            Console.Write("Enter the numbers of contracts for this worker:  ");
            int n = int.Parse(Console.ReadLine());


            for(int i = 1; i <= n; i++)
            {
                Console.Write($"Enter the #{i} contract data:   ");
                Console.Write("Date (DD/MM/YYYY):   ");
                DateTime datetime = DateTime.Parse(Console.ReadLine());
                Console.Write("Enter the Value per Hour:  ");
                double value = double.Parse(Console.ReadLine());
                Console.Write("Duration (hours):  ");
                int hour = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(datetime, value, hour);
                worker.AddContract(contract);

            }

            Console.WriteLine();
            Console.Write("Enter the month and the year to calculate the income:  ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Name:  " + worker.Name);
            Console.WriteLine("Department:  " +worker.Department.Name);
            Console.WriteLine("Income for " +monthAndYear + " : " + worker.Income(year, month));







        }
    }
}
