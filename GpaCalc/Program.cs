using System;
namespace GpaCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPoints = 0;
            int totalCredits = 0;
            decimal GPA = 0;
            int creditUnit = 0;
            int gradePoint = 0;
            int points;
            int classNumber = 1;
            string name = getStudentName();
            string className = "";
            do
            {
                className = getClassName();

                if (className != "" && className != "e" && className != "E")
                {
                    getClassGradeAndUnits(ref creditUnit, ref gradePoint, classNumber);

                    points = creditUnit * gradePoint;
                    totalPoints = points + totalPoints;
                    totalCredits += creditUnit;
                    classNumber++;
                  

                }

            }
            while (className != "" && className != "e" && className != "E");
            GPA = (decimal)totalPoints / (decimal)totalCredits;
            Console.Write("{0} your GPA for your classes are {1:N2}", name, GPA);
            Console.ReadKey();
        }

        private static string getClassName()
        {
            string className = "";
            int counter = 0;
            Console.Write("Please enter the class you are taking:(or press E to see GPA) ", className, counter);
            return Console.ReadLine();

        }

        private static string getStudentName()
        {
            string name = "";
            while (String.IsNullOrEmpty(name))
            {
                Console.Write("please enter your name: ");
                name = Console.ReadLine();
            }

            return name;
        }

        private static void getClassGradeAndUnits(ref int creditUnit, ref int gradePoint, int classNumber)
        {


            char userLetterGrade = ' ';
            char units;

            // do
            // {
            Console.Write("Enter grade for for your class #{0}: ", classNumber);

            userLetterGrade = char.Parse(Console.ReadLine());
            Console.Write("Enter credit unit(s) for grade: ");
            units = char.Parse(Console.ReadLine());
            if (char.IsDigit(units))
            {
                creditUnit = Int32.Parse(units.ToString());
                gradePoint = GpaInput(userLetterGrade, gradePoint);

            }

            //} while (userLetterGrade != 0);
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
