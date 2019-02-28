using System;
namespace GpaCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPoints = 0;
            int totalCredits = 0;
            double GPA = 0;
            //string name = Console.ReadLine();


            creditsGradeCalc(ref totalCredits, ref totalPoints);
            if (totalCredits != 0)
            {
                GPA = totalPoints / totalCredits;
                //Console.WriteLine("Hello what is your name? ", name);
                Console.Write("Your GPA for your classes are {0:F2}", GPA);
            }
            else
            {
                Console.Write("You put in a char for units instead of an integer");
            }
            Console.ReadKey();
        }

        private static void creditsGradeCalc(ref int totalCredits, ref int totalPoints)
        {
            int points;
            int creditUnit = 0;
            char userLetterGrade = ' ';
            int gradePoint = 0;
            char units;
            int counter = 0;
            do
            {
                Console.Write("Enter grade for for your classes #{0} (press E to exit): ", counter);

                userLetterGrade = char.Parse(Console.ReadLine());

                if (userLetterGrade == 'e' || userLetterGrade == 'E')
                {
                    break;
                }
                else
                {
                    
                    Console.Write("Enter credit unit(s) for grade: ");
                    units = char.Parse(Console.ReadLine());
                    if (char.IsDigit(units))
                    {
                        creditUnit = Int32.Parse(units.ToString());
                        gradePoint = GpaInput(userLetterGrade, gradePoint);
                        points = creditUnit * gradePoint;
                        totalPoints = points + totalPoints;
                        totalCredits += creditUnit;
                        counter++;
                    }

                }

            } while (userLetterGrade != 0);
        }

        private static int GpaInput(char letterGrade, int gradePoint)
        {
            switch (letterGrade)
            {
                case 'A':
                case 'a':
                    return 4;

                case 'B':
                case 'b':
                    return 3;

                case 'C':
                case 'c':
                    return 2;

                case 'D':
                case 'd':
                    return 1;

            }

            return 0;
        }
    }
}
