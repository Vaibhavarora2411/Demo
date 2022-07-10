using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vaibhav_assignment.Classes;
using Vaibhav_assignment.Classes.Exercise4an6.Classes;
using Vaibhav_assignment.Classes.Exercise5;

namespace Vaibhav_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter 1 to run Exercise-1");
                Console.WriteLine("Enter 2 to run Exercise-2");
                Console.WriteLine("Enter 3 to run Exercise-3");
                Console.WriteLine("Enter 4 to run Exercise-4");
                Console.WriteLine("Enter 5 to run Exercise-5");
                Console.WriteLine("Enter 6 to run Exercise-6");
                Console.WriteLine("Enter 7 to run Exercise-7");
                var inputValue = Console.ReadLine();
                switch (inputValue.ToLower())
                {
                    case "1":
                        Exercise1();
                        break;
                    case "2":
                        Exercise2();
                        break;
                    case "3":
                        Exercise3();
                        break;
                    case "4":
                        Exercise4();
                        break;
                    case "5":
                        Exercise5();
                        break;
                    case "6":
                        Exercise6();
                        break;
                    case "7":
                        Exercise7();
                        break;

                    default:
                        Console.WriteLine("Invalid Value");
                        break;
                }
                Console.WriteLine("Do you want to continue Y/N");
                if (Console.ReadLine().ToUpper() == "N")
                {
                    break; //exit while
                }
            }
        }

        private static void Exercise1()
        {
            Exercise1Cls exercise1Cls = new Exercise1Cls();
            Console.WriteLine("Enter the input value");
            var inputValue = Console.ReadLine();

            Console.WriteLine("1. Convert to int using Convert");
            Console.WriteLine("2. Convert to int using Parse");
            Console.WriteLine("3. Convert to int using TryParse");
            Console.WriteLine("4. Convert to float using Parse");
            Console.WriteLine("5. Convert to float using TryParse");
            Console.WriteLine("6. Convert to bool using Parse");
            Console.WriteLine("7. Convert to bool using TryParse");
            Console.WriteLine("8. Convert to bool using Convert.ToBoolean");
            var optionValue = Console.ReadLine();
            switch (optionValue.ToLower())
            {
                case "1":
                    int outputValue = exercise1Cls.ParseIntegerbyParseInt(inputValue);
                    Console.WriteLine("The converted value is : {0}", outputValue);
                    break;
                case "2":
                    outputValue = exercise1Cls.ParseIntegerbyConvertInt(inputValue);
                    Console.WriteLine("The converted value is : {0}", outputValue);
                    break;
                case "3":
                    outputValue = exercise1Cls.ParseIntegerbyTryParse(inputValue);
                    Console.WriteLine("The converted value is : {0}", outputValue);
                    break;
                case "4":
                    float outputValue_1 = exercise1Cls.ParseFloatbyParse(inputValue);
                    Console.WriteLine("The converted value is : {0}", outputValue_1);
                    break;
                case "5":
                    outputValue_1 = exercise1Cls.ParseFloatbyTryParse(inputValue);
                    Console.WriteLine("The converted value is : {0}", outputValue_1);
                    break;
                case "6":
                    bool outputValue_2 = exercise1Cls.ParseBoolbyTryParse(inputValue);
                    Console.WriteLine("The converted value is : {0}", outputValue_2);
                    break;
                case "7":
                    outputValue_2 = exercise1Cls.ParseBoolbyParse(inputValue);
                    Console.WriteLine("The converted value is : {0}", outputValue_2);
                    break;
                case "8":
                    outputValue_2 = exercise1Cls.ParseBoolbyConvert(inputValue);
                    Console.WriteLine("The converted value is : {0}", outputValue_2);
                    break;
                default:
                    break;
            }
        }

        private static void Exercise2()
        {

            Object o1 = new Object();
            Object o2 = new Object();
            o1 = "X";
            o2 = "X";
            Exercise2Cls exercise2Cls = new Exercise2Cls();
            exercise2Cls.CompareObjects();
        }

        private static void Exercise3()
        {
            int outputvalue1, outputvalue2;
            outputvalue1 = 1;
            outputvalue2 = 0;
            while (outputvalue1 >= outputvalue2)
            {
                if (outputvalue1 >= outputvalue2)
                {
                    Console.WriteLine("first number should be less then the second nummber");
                }
                else
                {
                    break;
                }

                Console.WriteLine("Enter the first number input value");
                var inputValue = Console.ReadLine();
                while (int.TryParse(inputValue, out outputvalue1) == false)
                {
                    Console.WriteLine("Enter the first number input value");
                    inputValue = Console.ReadLine();
                }

                Console.WriteLine("Enter the second number input value");
                var inputValue2 = Console.ReadLine();
                while (int.TryParse(inputValue2, out outputvalue2) == false)
                {
                    Console.WriteLine("Enter the second number input value");
                    inputValue2 = Console.ReadLine();
                }
            }

            Exercise3Cls exercise3Cls = new Exercise3Cls();
            exercise3Cls.PrimeNumbers(outputvalue1, outputvalue2);
        }

        private static void Exercise5()
        {
            DuckExercise duckExercise = new DuckExercise();
            duckExercise.ExecuteExercise5();
        }

        private static void Exercise7()
        {
            DuckExercise duckExercise = new DuckExercise();
            duckExercise.ExecuteExercise5();
            duckExercise.ExecuteExercise7();
        }

        private static void Exercise4()
        {
            EqupmentExercise equipmentExercise = new EqupmentExercise();
            equipmentExercise.Exercise4();
        }

        private static void Exercise6()
        {
            EqupmentExercise equipmentExercise = new EqupmentExercise();
            equipmentExercise.Exercise6();
        }
    }
}
