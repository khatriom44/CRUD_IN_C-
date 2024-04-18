using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud
{
    internal class Operation
    {
        public static List<Employee> Employee = new List<Employee>();
        //ADD Employee
        public void AddEmployee()
        {
            try
            {
                Console.WriteLine("Employee ID:");
                int iEmployeeId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Employee Name:");
                string sEmployeeName = Console.ReadLine();
                Console.WriteLine("Employee Age:");
                int iEmployeeAge = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Employee Gender(m(Male)/f(Female):");
                char cEmployeeGender = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Employee 10th Percentage:");
                float fEmployeePercentageTenth = float.Parse(Console.ReadLine());
                Console.WriteLine("Employee 12th Percenatge:");
                double dEmployeePercenatge = (double)Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Is Employee?(true/False):");
                bool bIsEmployee = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine("Employee Salary:");
                long lemployeeSalary = long.Parse(Console.ReadLine());

                Employee Data = new Employee(iEmployeeId, sEmployeeName, iEmployeeAge, cEmployeeGender, fEmployeePercentageTenth, dEmployeePercenatge, bIsEmployee, lemployeeSalary);
                Employee.Add(Data);
                Console.WriteLine("Employee Detail added successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //View Employee Detail
        public void ViewEmployee()
        {
            Console.WriteLine("Employee Detail:");
            for (int i = 0; i < Employee.Count; i++)
            {
                Console.WriteLine($"Employee {i + 1}:");
                Console.WriteLine("Employee ID: " + Employee[i].iId);
                Console.WriteLine("Employee Name: " + Employee[i].sName);
                Console.WriteLine("Employee Age: " + Employee[i].iAge);
                Console.WriteLine("Employee Gender: " + Employee[i].cGender);
                Console.WriteLine("10th Percentage: " + Employee[i].fPercentageTenth);
                Console.WriteLine("12th Percentage: " + Employee[i].dPercentage);
                Console.WriteLine("Is employee: " + Employee[i].bIsEmployed);
                Console.WriteLine("Employee Salary: " + Employee[i].lSalary);
                Console.WriteLine("\n");
            }
        }

        //Update Employee Detail
        public void UpdateEmployee()
        {

            if (Employee.Count == 0)
            {
                Console.WriteLine("Please first add Employee");
            }
            else
            {
                Console.WriteLine("Enter the Employee Index you want to change :");
                //string sOldEmployee = Console.ReadLine();
                //int iIndex = Employee.FindIndex(Employee => Employee == sOldEmployee);

                int iIndex = Convert.ToInt32(Console.ReadLine()) - 1;

                if (iIndex >= 1 && iIndex < Employee.Count)
                {
                    Console.WriteLine("Employee ID:");
                    int iEmployeeId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Employee Name:");
                    string sEmployeeName = Console.ReadLine();
                    Console.WriteLine("Employee Age:");
                    int iEmployeeAge = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Employee Gender(m(Male)/f(Female):");
                    char cEmployeeGender = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("Employee 10th Percentage:");
                    float fEmployeePercentageTenth = float.Parse(Console.ReadLine());
                    Console.WriteLine("Employee 12th Percenatge:");
                    double dEmployeePercenatge = (double)Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Is Employee?(true/False):");
                    bool bIsEmployee = Convert.ToBoolean(Console.ReadLine());
                    Console.WriteLine("Employee Salary:");
                    long lemployeeSalary = long.Parse(Console.ReadLine());

                    Employee Data = new Employee(iEmployeeId, sEmployeeName, iEmployeeAge, cEmployeeGender, fEmployeePercentageTenth, dEmployeePercenatge, bIsEmployee, lemployeeSalary);

                    Employee[iIndex] = Data;

                    Console.WriteLine("Employee Detail Updated Successfully.");
                }
                else
                {
                    Console.WriteLine("Enter Valid Index");
                }

            }

        }

        //Delete Employee Detail
        public void DeleteEmployee()
        {
            try
            {
                if (Employee.Count == 0)
                {
                    Console.WriteLine("Please First Add Employee");
                }
                else
                {
                    Console.WriteLine("Enter the Employee Index You want to delete : ");
                    //string sEmployeeName = Console.ReadLine();
                    //int iIndex = Employee.FindIndex(Employee => Employee == sEmployeeName);
                    int iIndex = Convert.ToInt32(Console.ReadLine()) - 1;
                    Employee.RemoveAt(iIndex);
                    Console.WriteLine("Employee Detail Deleted Successfully.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : Please Enter valid Employee Index");
            }
        }
    }
}
