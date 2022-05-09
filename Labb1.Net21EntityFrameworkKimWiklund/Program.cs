using Labb1.Net21EntityFrameworkKimWiklund.Models;
using System;


namespace Labb1.Net21EntityFrameworkKimWiklund
{
    class Program
    {
        static void Main(string[] args)
        {
            LabbDBContext context = new LabbDBContext();
            

            Console.WriteLine("Login \n--------------\n1: Employee \n2: Administrator\n");
            
            try
            {
                int firstMenuInput = Convert.ToInt32(Console.ReadLine());
                
                if (firstMenuInput == 1)
                {
                    EmployeeChosen();
                }
                if (firstMenuInput == 2)
                {
                    AdminChosen();
                }
                if (firstMenuInput < 1 || firstMenuInput > 2)
                {
                    Console.WriteLine("You have entered an Invalid Number (1 or 2)");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("You have entered an Invalid Number (1 or 2)");
            }
            // Employee chosen now we go through the steps to request leave by asking a series of questions.
            void EmployeeChosen()
            {
                var employees = context.Employees;
                
                foreach (var item in employees)
                {
                    
                    Console.WriteLine(item.EmployeeId + " - " + item.FirstName + " " + item.LastName);

                }
                Console.WriteLine("Chose Employee (1-7)");
                int choseEmployeeInput = Convert.ToInt32(Console.ReadLine());

                var employeeChosen = context.Leaves;
                
                foreach (var item in employeeChosen)
                {
                    if (item.FEmployeeId == choseEmployeeInput)
                    {
                        Console.WriteLine($"Welcome {item.Employees.FirstName} {item.Employees.LastName}");
                    }
                }
                Console.WriteLine("For what Reason are you requesting Leave? (Sick, Vab, Unpaid or Vacation");
                string choseReasonInput = Console.ReadLine();
                Console.WriteLine("From when does this Leave start? (yyyy / MM / dd)");
                DateTime startDate = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("When does this Leave end? (yyyy / MM / dd)");
                DateTime endDate = Convert.ToDateTime(Console.ReadLine());

                Leaves leaves = new Leaves()
                {
                    Reason = choseReasonInput,
                    StartDate = startDate,
                    EndDate = endDate,
                    FEmployeeId = choseEmployeeInput,
                    RegistrationTime = DateTime.Now.Date
            
                };
                context.Leaves.Add(leaves);
                context.SaveChanges();
                
                Console.WriteLine("You have added a Requested Leave!");
            }
            
            // Admin was chosen now we select if we want History for a month or employee.
            void AdminChosen()
            {
                Console.WriteLine("You have chosen Admin");
                Console.WriteLine("Do you want to look at a specific persons History(1) or a Monthly History(2)? (1-2)");
             
                try
                {
                    int adminInput = Convert.ToInt32(Console.ReadLine());

                    if (adminInput == 1)
                    {
                        HistoryChosen();
                    }
                    if (adminInput == 2)
                    {
                        MonthlyChosen();
                    }
                    if (adminInput < 1 || adminInput > 2)
                    {
                        Console.WriteLine("You have entered an Invalid Number (1 or 2)");
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("You have entered an Invalid Number ");
                }
            }
            // History chosen now we select an employee and get their history of Requested Leaves.
            void HistoryChosen()
            {
                var employees = context.Employees;

                foreach (var item in employees)
                {

                    Console.WriteLine(item.EmployeeId + " - " + item.FirstName + " " + item.LastName);

                }
                Console.WriteLine("Chose Employee (1-7)");
                int inputHistory = Convert.ToInt32(Console.ReadLine());
                

                var leavesEmployeeHistory = context.Leaves;

                foreach (var item in leavesEmployeeHistory)
                {
                    if (item.FEmployeeId == inputHistory)
                    {
                        Console.WriteLine(item.Reason + " - " + item.StartDate.Date.ToString("yyyy/MM/dd") + " - " + item.EndDate.Date.ToString("yyyy/MM/dd") + " " + "Employee ID:" + item.FEmployeeId);
                    }
                }
            }

            // Monthly History has been Chosen. Now we select a month and Get all Requested Leaves for that Month.
            void MonthlyChosen()
            {
                Console.WriteLine("Please Enter a Month (1-12)");
                int inputMonth = Convert.ToInt32(Console.ReadLine());
                
                var leavesMonthHistory = context.Leaves;
               

                foreach (var item in leavesMonthHistory)
                {
                    if ((item.StartDate.Month >= inputMonth) && (item.EndDate.Month <= inputMonth))
                    {                        
                        Console.WriteLine(item.Reason + " - " + item.StartDate.Date.ToString("yyyy/MM/dd") + " - " + item.EndDate.Date.ToString("yyyy/MM/dd") + " " + "Employee ID:" + item.FEmployeeId); 
                    }
                }
            }
        }
        // Unused idea.
        //public static int GetInput()
        //{
        //    int val = Int32.Parse(Console.ReadLine());
        //    return val;
        //}
    }    
}
