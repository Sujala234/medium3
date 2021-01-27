using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium3
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            Employee emp = new Employee();
            List<Employee> empList = new List<Employee>();
            void SortAndPrintEmployee()
            {
                empList.Sort();
                Console.WriteLine("The sorted employee list\n");
                foreach (var item in empList)
                {
                    Console.WriteLine("Employee ID: {0}\nName: {1}\nAge: {2}\nSalary:{3}\n--------------\n", item.Id, item.Name, item.Age, item.Salary);

                }
            }
            void PrintEmployee()
            {
                Console.WriteLine("Please enter the employee Name\n");
                string employeeName = Console.ReadLine();
                var result = from item in empList where item.Name == employeeName select item;
                foreach (Employee empobj in result)
                {
                    Console.WriteLine(empobj);
                }
            }
            do
            {
                emp.TakeEmployeeDetailsFromUser();
                empList.Add(new Employee() { Id = emp.Id, Name = emp.Name, Age = emp.Age, Salary = emp.Salary });
                Console.WriteLine("To continue entering employee details enter 1, to exit enter 0");
                input = Convert.ToInt32(Console.ReadLine());
            } while (input != 0);


            SortAndPrintEmployee();
            PrintEmployee();

            Console.ReadKey();
        }
    }
}