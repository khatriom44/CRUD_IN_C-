using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud
{
    internal class Employee
    {

        public int iId { get; set; } 

        public string sName { get; set; }

        public int iAge { get; set; }

        public char cGender { get; set; }

        public float fPercentageTenth {  get; set; }

        public double dPercentage {  get; set; }

        public bool bIsEmployed {  get; set; }

        public long lSalary {  get; set; }

        public Employee(int iEmployeeId,string sEmployeeName,int iEmployeeAge,char cEmployeeGender,float fEmployeePercentageTenth,double demployeePercentage,bool bIsEmployee,long lEmployeeSalary )
        {
            iId = iEmployeeId;
            sName = sEmployeeName;
            iAge = iEmployeeAge;
            cGender = cEmployeeGender;
            fPercentageTenth = fEmployeePercentageTenth;
            dPercentage = demployeePercentage;
            bIsEmployed = bIsEmployee;
            lSalary = lEmployeeSalary;
        }

    }
}
