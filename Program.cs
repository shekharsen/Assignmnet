using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Litware_Lib;

namespace EmployeeManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Employee Registration
                Console.WriteLine("-----Enter the new Employee details-----");
                Console.WriteLine("     Enter Employee Number");
                int Emp_No = int.Parse(Console.ReadLine());
                Console.WriteLine("     Enter Employee Name");
                string Emp_Name = Console.ReadLine();
                Console.WriteLine("     Enter Employee Salary");
                double Emp_Salary = double.Parse(Console.ReadLine());

                //New Employee Entry
                Employee EMP = new Employee();
                EMP.Employee_Registration(Emp_No, Emp_Name, Emp_Salary);
                EMP.Show_GrossSalary();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
