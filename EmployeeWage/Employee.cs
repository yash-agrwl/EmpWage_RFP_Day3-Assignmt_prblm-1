﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Employee
    {
        const int IsAbsent = 0;
        const int IsFullTime = 1;
        const int IsPartTime = 2;
        const int WagePerHr = 20;
        const int FullTimeHr = 8;
        const int PartTimeHr = 4;
        public static int Check()
        {
            Random random = new Random();
            return random.Next(0, 3);
        }
        public static string Attendance(int empCheck)
        {
            if (empCheck == IsFullTime)
                return "Present and Full Time";
            else if (empCheck == IsPartTime)
                return "Present but Part Time";
            else
                return "Absent";
        }
        public static int DailyEmpWage(int empCheck)
        {
            int empHrs;
            if (empCheck == IsFullTime)
                empHrs = FullTimeHr;
            else if (empCheck == IsPartTime)
                empHrs = PartTimeHr;
            else
                empHrs = 0;
            int empWage = empHrs * Employee.WagePerHr;
            return empWage;
        }
    }
}
