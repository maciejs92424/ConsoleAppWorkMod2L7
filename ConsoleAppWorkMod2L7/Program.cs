using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppWorkMod2L7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tasks from module 2 lesson 7");
        label1:
            Console.WriteLine("1. Comparison of created numbers");
            Console.WriteLine("2. Parity - even or odd number");
            Console.WriteLine("3. Positive or negative number");
            Console.WriteLine("4. Leap Year or Not");
            Console.WriteLine("5. Minimum age of a parliamentarian");
            Console.WriteLine("6. The height category");
            Console.WriteLine("7. Which number is the largest");
            Console.WriteLine("8. Access to Studies");
            Console.WriteLine("9. Temperature control");
            Console.WriteLine("10. Triangle possible or not");
            Console.WriteLine("11. Pupil assessment");
            Console.WriteLine("12. The day of week");
            Console.WriteLine("13. Simple calc");
            Console.WriteLine("Enter task number");
            int.TryParse(Console.ReadLine(), out int i);
            switch (i)
            {
                case 1://Equal numbers
                    Console.WriteLine("Enter first number:");
                    int.TryParse(Console.ReadLine(), out int a);
                    Console.WriteLine("Enter second number:");
                    int.TryParse(Console.ReadLine(), out int b);
                    if (a == b)
                    {
                        Console.WriteLine($"The number {a} is equal {b}");
                    }
                    else
                    {
                        Console.WriteLine($"The number {a} is not equal {b}");
                    }
                    break;
                case 2://Even or odd
                    Console.WriteLine("Enter the number:");
                    int.TryParse(Console.ReadLine(), out a);
                    if ((a != 0) & (a % 2 == 0))
                    {
                        Console.WriteLine($"The number {a} is even");
                    }
                    else
                    {
                        Console.WriteLine($"The number {a} is odd");
                    }
                    break;
                case 3://Positive or negative 
                    Console.WriteLine("Enter the number:");
                    int.TryParse(Console.ReadLine(), out a);
                    if (a == 0)
                    {
                        Console.WriteLine($"The number {a} is neutral");
                    }
                    else if (a > 0)
                    {
                        Console.WriteLine($"The number {a} is positive");
                    }
                    else
                    {
                        Console.WriteLine($"The number {a} is negative");
                    }
                    break;
                case 4://Leap year - sprawdz
                    Console.WriteLine("Enter a year:");
                    int.TryParse(Console.ReadLine(), out a);
                    int x = a % 4;
                    x = a % 100;
                    x = a % 400;

                    if (((a % 4 == 0) & (a % 100 != 0)) | (a % 400 == 0))
                    {
                        Console.WriteLine($"The year {a} is leap");
                    }
                    else
                    {
                        Console.WriteLine($"The year {a} is not leap");
                    }
                    break;
                case 5:
                    Console.WriteLine("Enter your age:");
                    int.TryParse(Console.ReadLine(), out a);
                    if (a >= 21)
                    {
                        Console.WriteLine("You can become a parliamentarian");
                    }
                    else
                    {
                        Console.WriteLine("You can't become a parliamentarian");
                    }
                    break;
                case 6:
                    Console.WriteLine("Enter your height:");
                    int.TryParse(Console.ReadLine(), out a);
                    //ver1 if 
                    if (a > 0 & a <= 140)
                    {
                        Console.WriteLine("You are a dwarf");
                    }
                    else if (140 < a & a <= 160)
                    {
                        Console.WriteLine("You are short");
                    }
                    else if (160 < a & a <= 170)
                    {
                        Console.WriteLine("You are average");
                    }
                    else if (170 < a & a < 200)
                        Console.WriteLine("You are tall");
                    else if (a >= 200)
                        Console.WriteLine("You are a giant");
                    else
                    {
                        Console.WriteLine("Wrong number");

                    };
                    //ver2 switch
                    switch (a)
                    {
                        case <= 140:
                            Console.WriteLine("You are a dwarf");
                            break;
                        case > 140 and <= 160:
                            Console.WriteLine("You are short");
                            break;
                        case > 160 and <= 170:
                            Console.WriteLine("You are average");
                            break;
                        case > 170 and <= 200:
                            Console.WriteLine("You are average");
                            break;
                        case > 200:
                            Console.WriteLine("You are a giant");
                            break;
                        default:
                            Console.WriteLine("Wrong number");
                            break;
                    }
                    break;
                case 7://The highest number
                    Console.WriteLine("Enter first number:");
                    int.TryParse(Console.ReadLine(), out a);
                    Console.WriteLine("Enter second number:");
                    int.TryParse(Console.ReadLine(), out b);
                    Console.WriteLine("Enter third number:");
                    int.TryParse(Console.ReadLine(), out int c);
                    int d = a >= b ? a : b;
                    d = d >= c ? d : c;
                    Console.WriteLine($"The highest number is {d}");
                    break;
                case 8:
                    //access to studies
                    Console.WriteLine("Enter Math score:");
                    int.TryParse(Console.ReadLine(), out a);
                    Console.WriteLine("Enter Physic score:");
                    int.TryParse(Console.ReadLine(), out b);
                    Console.WriteLine("Enter Chemistry score:");
                    int.TryParse(Console.ReadLine(), out c);
                    if ((a + b + c > 180) | (a + b > 150) | (a + c > 150))
                    {
                        Console.WriteLine("Candidate admitted to recruitment");
                    }
                    else Console.WriteLine("Candidate don't admitted to recruitment");
                    break;
                case 9:
                    //Temperature control
                    Console.WriteLine("Enter the temperature value");
                    int.TryParse(Console.ReadLine(), out a);
                    string tempByName = a switch
                    {
                        <= 0 => "It's damn cold",
                        > 0 and <= 10 => "It's cold",
                        > 10 and <= 20 => "it's chilly",
                        > 20 and <= 30 => "It's just right",
                        > 30 and <= 40 => "It's starting to get weak, because it's hot",
                        > 40 => "A come on, I'm moving to Alaska"
                        //_ => "Wrong value"
                    };
                    Console.WriteLine($"{tempByName}");
                    break;
                case 10:
                    //Triangle 
                    Console.WriteLine("Enter first side of the triangle:");
                    int.TryParse(Console.ReadLine(), out a);
                    Console.WriteLine("Enter second side of the triangle:");
                    int.TryParse(Console.ReadLine(), out b);
                    Console.WriteLine("Enter third side of the triangle:");
                    int.TryParse(Console.ReadLine(), out c);
                    if ((a + b > c) & (a + c > b) & (b + c > a))
                    {
                        Console.WriteLine($"Triangle {a},{b},{c} possible to build");
                    }
                    else Console.WriteLine("Triangle isn't possible to build");
                    break;
                case 11:
                    //Pupil assessment
                    Console.WriteLine("Enter your grade as a number from 1 to 6");
                    int.TryParse(Console.ReadLine(), out a);
                    string tempAssessment = a switch
                    {
                        6 => "excellent",
                        5 => "very good",
                        4 => "good",
                        3 => "satisfactory",
                        2 => "acceptable",
                        1 => "insufficient",
                        _ => "Wrong value"
                    };
                    Console.WriteLine($"{tempAssessment}");
                    break;
                case 12://Day of week
                    Console.WriteLine("Enter day no from 1 to 7");
                    int.TryParse(Console.ReadLine(), out a);
                    string tempDayNo = a switch
                    {
                        1 => "Monday",
                        2 => "Thuesday",
                        3 => "Wednesday",
                        4 => "Thuersday",
                        5 => "Friday",
                        6 => "Saturday",
                        7 => "Sunday",
                        _ => "Incorrect value"
                    };
                    Console.WriteLine($"{tempDayNo}");
                    break;
                case 13://Simple calc
                    double first, second, result;
                    Console.Write("Enter first number: ");
                    first = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    second = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter operator: *,/, +, -:  \r\n");
                    char op = Console.ReadKey().KeyChar;
                    switch (op)
                    {
                        case '+':
                            result = first + second;
                            Console.WriteLine("\r\n{0} + {1} = {2}", first, second, result);
                            break;
                        case '-':
                            result = first - second;
                            Console.WriteLine("\r\n{0} - {1} = {2}", first, second, result);
                            break;
                        case '*':
                            result = first * second;
                            Console.WriteLine("\r\n{0} * {1} = {2}", first, second, result);
                            break;
                        case '/':
                            result = first / second;
                            Console.WriteLine("\r\n{0} / {1} = {2}", first, second, result);
                            break;
                        default:
                            Console.WriteLine("\r\nInvalid Operator");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Enter correct value");
                    break;
            }
            Console.WriteLine("To continue? Y|N");
            switch (Console.ReadLine())
            {
                case "Y" or "y":
                    goto label1;
                default:
                    Console.WriteLine("End");
                    break;
            }
        } 
    }
}


