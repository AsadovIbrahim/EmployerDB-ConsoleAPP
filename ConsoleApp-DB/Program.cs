using ConsoleApp_DB.Contexts;
using ConsoleApp_DB.Entities;
using System;
using System.Collections.Generic;
using static ConsoleApp_DB.Functions.Function;
public class Program
{
    static void Main(string[] args)
    {
        bool status = true;
        dynamic key;
        int choose = 0;
        Employer[] employees = new Employer[0];

        while (status)
        {
            Console.Clear();
            Logo();

            if (choose == 0)
            {
                Console.SetCursorPosition(50, 10);
                SetConsoleColor("->ADD EMPLOYEE<-");

            }
            else
            {
                Console.SetCursorPosition(50, 10);
                Console.WriteLine("ADD EMPLOYEE");
            }

            if (choose == 1)
            {
                Console.SetCursorPosition(50, 11);
                SetConsoleColor("->SHOW ALL EMPLOYEES<-");

            }
            else
            {
                Console.SetCursorPosition(50, 11);
                Console.WriteLine("SHOW ALL EMPLOYEES");
            }

            if (choose == 2)
            {
                Console.SetCursorPosition(50, 12);
                SetConsoleColor("->REMOVE EMPLOYEES<-");

            }
            else
            {
                Console.SetCursorPosition(50, 12);
                Console.WriteLine("REMOVE EMPLOYEES");
            }

            if (choose == 3)
            {
                Console.SetCursorPosition(50, 13);
                SetConsoleColor("->CLEAR ALL EMPLOYEES<-");

            }
            else
            {
                Console.SetCursorPosition(50, 13);
                Console.WriteLine("CLEAR ALL EMPLOYEES");
            }

            if (choose == 4)
            {
                Console.SetCursorPosition(50, 14);
                SetConsoleColor("->EXIT<-");
            }
            else
            {
                Console.SetCursorPosition(50, 14);
                Console.WriteLine("EXIT");
            }

            key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    if (choose != 0) choose--;
                    else choose = 4;
                    break;
                case ConsoleKey.DownArrow:
                    if (choose != 4) choose++;
                    else choose = 0;
                    break;
                case ConsoleKey.Enter:
                    Console.Clear();
                    if (choose == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\n\nEnter Employee Name:");
                        string name = Console.ReadLine()!;
                        Console.WriteLine("--------");

                        Console.WriteLine("Enter Employee Surname:");
                        string surname = Console.ReadLine()!;
                        Console.WriteLine("--------");


                        Console.WriteLine("Enter Employee Age:");
                        byte age = Convert.ToByte(Console.ReadLine());
                        Console.WriteLine("--------");


                        Console.WriteLine("Enter Department No:");
                        int departmentNo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("--------");


                        Console.WriteLine("Enter Employee's Salary:");
                        double salary = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("--------");


                        using (var context = new EmployerDBContext())
                        {
                            Employer newEmployee = new Employer(name, surname, age, departmentNo, salary);
                            context.Employers!.Add(newEmployee);
                            context.SaveChanges();
                            Console.WriteLine("\nEmployee Added Successfully !!");
                        }


                        Console.ForegroundColor = ConsoleColor.White;
                        PressAnyKey();
                    }
                    else if (choose == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Department department = new Department(employees);
                        department.ShowAllInfo();
                        Console.ForegroundColor = ConsoleColor.White;
                        PressAnyKey();
                    }
                    else if (choose == 2)
                    {
                        Console.ForegroundColor= ConsoleColor.Yellow;
                        Department department = new Department();
                        Console.Write("Enter Id Employer To Remove:");
                        Console.WriteLine("\n------------");
                        int id = Convert.ToInt32(Console.ReadLine());
                        department.RemoveEmployee(id);
                        Console.ForegroundColor = ConsoleColor.White;
                        PressAnyKey();
                    }
                    else if (choose == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Department department = new Department();
                        department.ClearAllEmployee();
                        Console.ForegroundColor = ConsoleColor.White;
                        PressAnyKey();
                    }

                    else if (choose == 4)
                    {
                        status = false;
                    }
                    break;
            }
        }
    }
}
