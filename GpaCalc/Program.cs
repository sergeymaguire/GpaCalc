using System;
namespace GpaCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            int creditUnit = 0;
            int totalCredits = 0;

            char grade = ' ';
            int gradePoint = 0;
            int total = 0;

            int counter = 0;
            double GPA = 0;

            creditsGradeCalc(ref creditUnit, ref totalCredits, ref grade, ref gradePoint, ref total, ref counter);

            GPA = total / totalCredits;
            Console.Write("Your GPA this semester is {0:F2}", GPA);

            Console.ReadKey();
        }

        private static void creditsGradeCalc(ref int creditUnit, ref int totalCredits, ref char grade, ref int gradePoint, ref int total, ref int counter)
        {
            do
            {
                Console.Write("Enter grade for Class #{0} (press E to exit and see GPA): ", counter += 1);
                // write some code to prevent user from entering more than 10
                char userInput = char.Parse(Console.ReadLine());

                if (userInput == 'E')
                {
                    break;
                }
                else
                {
                    grade = userInput; 
                    Console.Write("Enter credit unit(s) for grade: ");
                    creditUnit = int.Parse(Console.ReadLine());

                    gradePoint = GpaInput(grade, gradePoint);
                    total += creditUnit * gradePoint;
                    totalCredits += creditUnit;
                }

            } while (grade != 0);
        }

        private static int GpaInput(char grade, int gradePoint)
        {
            switch (grade)
            {
                case 'A':
                    gradePoint += 4;
                    break;
                case 'B':
                    gradePoint += 3;
                    break;
                case 'C':
                    gradePoint += 2;
                    break;
                case 'D':
                    gradePoint += 1;
                    break;
            }

            return gradePoint;
        }
    }
}
