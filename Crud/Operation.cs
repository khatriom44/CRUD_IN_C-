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
            Employee oData = new Employee();
            try
            {
                Console.WriteLine("Employee ID:");
                oData.iId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Employee Name:");
                oData.sName = Console.ReadLine();
                Console.WriteLine("Employee Age:");
                oData.iAge = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Employee Gender(m(Male)/f(Female):");
                oData.cGender = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Employee 10th Percentage:");
                oData.fPercentageTenth = float.Parse(Console.ReadLine());
                Console.WriteLine("Employee 12th Percenatge:");
                oData.dPercentage = (double)Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Is Employee?(true/False):");
                oData.bIsEmployed = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine("Employee Salary:");
                oData.lSalary = long.Parse(Console.ReadLine());

                Employee.Add(oData);
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

                int iIndex = Convert.ToInt32(Console.ReadLine());

                if (iIndex >= 1 && iIndex <= Employee.Count)
                {
                    try
                    {
                        Employee oData = new Employee();
                        Console.WriteLine("Employee ID:");
                        oData.iId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Employee Name:");
                        oData.sName = Console.ReadLine();
                        Console.WriteLine("Employee Age:");
                        oData.iAge = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Employee Gender(m(Male)/f(Female):");
                        oData.cGender = Convert.ToChar(Console.ReadLine());
                        Console.WriteLine("Employee 10th Percentage:");
                        oData.fPercentageTenth = float.Parse(Console.ReadLine());
                        Console.WriteLine("Employee 12th Percenatge:");
                        oData.dPercentage = (double)Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Is Employee?(true/False):");
                        oData.bIsEmployed = Convert.ToBoolean(Console.ReadLine());
                        Console.WriteLine("Employee Salary:");
                        oData.lSalary = long.Parse(Console.ReadLine());


                        Employee[iIndex - 1] = oData;

                        Console.WriteLine("Employee Detail Updated Successfully.");
                    }
                     catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);  
                    }
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
