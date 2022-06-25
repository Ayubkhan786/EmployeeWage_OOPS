﻿Console.WriteLine("Welcome to Employee Wage Computation");
int empAbsent = 0;
int empPresent = 1;
int empPartTime = 2;

int empWrkHrs = 0;
int empSalary = 20;
int MAX_DAYS = 20;
int MAX_HRS = 100;
int empHrs = 0, maxDays = 0;

while (empWrkHrs <= MAX_HRS && maxDays < MAX_DAYS)
{
    maxDays++;

    Random num = new Random();
    int attendance = num.Next(0, 3);

    switch (attendance)
    {
        case 0:
            Console.WriteLine("Is Absent");
            empWrkHrs = 0;
            break;
        case 1:
            Console.WriteLine("Is Present");
            empWrkHrs = 8;
            break;
        case 2:
            Console.WriteLine("Is PartTime");
            empWrkHrs = 4;
            break;
    }
    empWrkHrs += empHrs;
    Console.WriteLine("Day : " + maxDays + "\n " + "Hours : " + empWrkHrs);


    int empWage = (empWrkHrs * empSalary);

    Console.WriteLine("Per Day salary is :" + empWage);

}

int monthlyWage = (empWrkHrs * MAX_DAYS * empSalary);
Console.WriteLine("The Monthly salary is :" + monthlyWage);