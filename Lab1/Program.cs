using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Bunga Laelatul Muna -----");
            Console.WriteLine("---------- JI230003 -----------");
            Console.WriteLine("===============================");
            Console.WriteLine("| 1. Check Even or Odd        |");
            Console.WriteLine("| 2. Calculate BMI            |");
            Console.WriteLine("| 3. Generate Fibonacci Series|");
            Console.WriteLine("| 4. Calculate Carry Mark     |");
            Console.WriteLine("===============================");
            Console.Write("Choose Menu (1/2/3/4): ");
          

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice) // switch case(bracnhing statement), actually can use 'If' also but in the brief task should use switch case
                {
                    //======= Case to run Checker Even or Odd Number ========
                    case 1:
                        Console.Write("Enter Integer Number : ");
                        int number = int.Parse(Console.ReadLine());
                        CheckEvenOdd(number);
                        break;
                    //======= Case to run Calculator BMI  ========
                    case 2:
                        Console.Write("Enter Weight (kg): ");
                        float weight = float.Parse(Console.ReadLine());
                        Console.Write("Enter Height (m): ");
                        float height = float.Parse(Console.ReadLine());
                        float bmi = CalculateBMI(weight, height);
                        string bmiCategory = GetBMICategory(bmi);
                        Console.WriteLine("BMI: " + bmi + " Category: " + bmiCategory ); //manual method to insert string with values
                        break;
                    //======= Case to run Fibonacci Series  ========
                    case 3:
                        Console.Write("Enter the lengt Fibbonaci: ");
                        int nFibbo = int.Parse(Console.ReadLine());
                        Console.Write("Seri Fibonacci: ");
                        GenerateFibonacciSeries(nFibbo);
                        Console.WriteLine();
                        break;
                    //======= Case to run Mark Carry Values by the Data  ========
                    case 4:
                        float[] student = { 67, 55, 89, 34 }; // this is array to contain  mark student

                        Console.WriteLine("Carry Marks for Students:"); 
                        for (int i = 0; i < student.Length; i++) // for looping contain array, so I don't need to write manually carry marks students.
                        {
                            float mark = student[i]; //variable mark containt student current values (from 0 and increase ++ until length student)
                            float carryMark = CalculateCarryMark(mark); // to calculate current values carry mark
                            Console.WriteLine("* Student " + (i + 1) + " : Mark = " + mark + " | Carry Mark = " + carryMark); //without interpolar string looks long codes
                        }
                        break;
                    default:
                        Console.WriteLine("InValid.");
                        break;
                
                }
            }
            else
            {
                Console.WriteLine("Option invalid, Please enter integer number(1/2/3/4).");
            }
        }
        //=========== Fun to Checking Even or Odd ==============
        static void CheckEvenOdd(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine(number + " is Even.");
            }
            else
            {
                Console.WriteLine(number + " is Odd");
            }
        }

        //=========== Fun to Calculate BMI ==============
        static float CalculateBMI(float weight, float height)
        {
            return weight / (height * height);
        }

        static string GetBMICategory(float bmi)
        {
            string category; //category index by health page indonesia
            switch (bmi) 
            {
                case float _ when bmi < 17.5: 
                    category = "Underweight";
                    break;
                case float _ when bmi < 24.9:
                    category = "Normal Weight";
                    break;
                case float _ when bmi < 27.9:
                    category = "Overweight";
                    break;
                default:
                    category = "Obese";
                    break;
            }
            return category;
        }

        //=========== Fun to Generate Fibbonaci ==============
        static void GenerateFibonacciSeries(int n)
        {
            int a = 0, b = 1, c;
            Console.Write($"{a}, {b}"); // using interpolar string, looks clean codes. 
            for (int i = 2; i < n; i++)
            {
                c = a + b;
                Console.Write($", {c}");
                a = b;
                b = c;
            }
        }

        //=========== Fun to Calculate Carry Mark ==============
        static float CalculateCarryMark(float mark)
        {
            return (float) (mark * 0.6); //it is packet to return float data type, usually when double or int u can use "return variable"
        }
    }
}
