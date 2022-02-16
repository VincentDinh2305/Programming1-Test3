using System;
    /*
     * Name: DINH HOANG VIET PHUONG
     * Date: April 09, 2021
     * Student number: 301123263
     */
namespace Test03
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        private static void DisplayMenu()
        {
            Console.WriteLine("+---------------------COMP100------------------------+");
            Console.WriteLine("|           a) Working with Newton's Law             |");
            Console.WriteLine("|           b) Height Converter                      |");
            Console.WriteLine("|           c) Sine and Cosine Table                 |");
            Console.WriteLine("|           d) Number Frequency                      |");
            Console.WriteLine("|                                                    |");
            Console.WriteLine("|           x) To exit the program                   |");
            Console.WriteLine("+----------------------------------------------------+");
            Console.Write("Press the letter corresponding to your choice: ");
        }
        #region Menu
        private static void Main(string[] args)
        {
            string letter;
            do
            {
                Program.DisplayMenu();
                letter = Console.ReadLine().ToUpper();
                string alp = letter;
                if (alp == "A")
                {
                    Program.DemoQuestion3();
                }
                else if (alp == "B")
                {
                    Program.DemoQuestion4();
                }
                else if (alp == "C")
                {
                    Program.DemoQuestion5();
                }
                else if (alp == "D")
                {
                    Program.DemoQuestion6();
                }
                else if (alp != "X")
                {
                    Console.WriteLine("ERROR: Invalid input");
                }
            }
            while (letter != "X");
        }
        #endregion

        #region 03
        private static void DemoQuestion3()
        {
            Console.WriteLine("\n\n**********Begin Question 3 **********");
            double num1 = 5.972E+24;
            double num2 = 7.348E+22;
            double num3 = 384400000;
            Console.WriteLine($"Mass of earth: {num1:e} kg");
            Console.WriteLine($"Mass of the moon:{num2:e} kg");
            Console.WriteLine($"The distance between them:{num3:e} m");
            Console.WriteLine($"The force of attraction:{Program.CalculateGravitationalAttraction(num1, num2, num3):e}N");               
            Console.WriteLine("\n**********End Question 3 **********\n\n");
        }
        private static double CalculateGravitationalAttraction(double mass1, double mass2, double distance)
        {
            double numG = 6.673E-11;
            double num = numG * mass1 * mass2 / distance / distance;
            return num;
        }
        #endregion

        #region 04
        private static void DemoQuestion4()
        {
            Console.WriteLine("\n\n**********Begin Question 4 **********");
            Program.HeightConversion(75);
            Program.HeightConversion(100);
            Program.HeightConversion(290);
            Console.WriteLine("\n\n**********End Question 4 **********\n\n");
        }

        private static void HeightConversion(int height)
        {
            int num1 = height / 100;
            int num2 = height % 100;
            Console.WriteLine($"          {height,3}cm {num1,3}m {num2,4}cm");
        }
        #endregion

        #region 05
        private static void DemoQuestion5()
        {
            double num1;
            double num2;
            double num3 = 0.5;
            Console.WriteLine("\n\n**********Begin Question 5 **********");            
            Console.WriteLine("        Angle     Sine   Cosine");
            for (int i = 0; i < 10; i++)
            {
                Program.SineCosine(num3, out num1, out num2);
                Console.WriteLine($"   {num3,10:f4} {num1,8:f4} {num2,8:f4}");
                num3 += 0.01;
            }
            Console.WriteLine("\n**********End Question 5 **********\n\n");
        }
        private static void SineCosine(double angle, out double sine, out double cosine)
        {
            sine = Math.Sin(angle);
            cosine = Math.Cos(angle);
        }
        #endregion

        #region 06
        private static void DemoQuestion6()
        {
            Console.WriteLine("\n\n**********End Question 6 **********");
            int[] numArray = Program.GenerateRandomIntArray(1, 100);
            Program.DisplayIntArray(numArray);
            Program.DisplayIntArray(Program.CalculateNumberFrequencies(numArray));
            Console.WriteLine("\n**********End Question 6 **********\n\n");
        }

        private static int[] CalculateNumberFrequencies(int[] array)
        {
            int[] numArray = new int[10];
            int[] numArray1 = array;
            for (int i = 0; i < (int)numArray1.Length; i++)
            {
                numArray[numArray1[i] / 10]++;
            }
            return numArray;
        }               
     
        private static void DisplayIntArray(int[] numbers)
        {
            int[] numArray = numbers;
            for (int i = 0; i < (int)numArray.Length; i++)
            {
                Console.WriteLine($"{numArray[i],3}");
            }
        }    

        private static int[] GenerateRandomIntArray(int numberOfItems, int largestValue)
        {
            int[] numArray = new int[numberOfItems];
            Random random = new Random();
            for (int i = 0; i < numberOfItems; i++)
            {
                numArray[i] = random.Next(largestValue);
            }
            return numArray;
        }
        #endregion
    }
}
