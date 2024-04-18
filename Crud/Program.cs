using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Crud
{
    internal class Program
    {        
        static void Main(string[] args)  
        {
            bool bExit = false;
            while (!bExit)
            {
                Console.WriteLine("Choose an option");
                Console.WriteLine("1. Create");
                Console.WriteLine("2. Read");
                Console.WriteLine("3. Update");
                Console.WriteLine("4. Delete");
                Console.WriteLine("5. Exit");

                string iOption = Console.ReadLine();
                Operation Op = new Operation();

                switch (iOption)
                {
                    case "1":
                        Console.WriteLine("Add Employee");
                        Op.AddEmployee();
                        break;
                    case "2":
                        Console.WriteLine("View Employee");
                        Op.ViewEmployee();
                        break;
                    case "3":
                        Console.WriteLine("Update Employee");
                        Op.UpdateEmployee();
                        break;
                    case "4":
                        Console.WriteLine("Delete Employee");
                        Op.DeleteEmployee();
                        break;
                    case "5":
                        Console.WriteLine("succesfully Exit");
                        bExit = true;
                        break;
                    default:
                        Console.WriteLine("Please Select Valid Option");
                        break;
                }

            }
        }

    }
    
}
