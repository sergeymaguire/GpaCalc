using System;
namespace GpaCalc
{
    //3/04/19

    //second project

    //C# programming

    //Gpa calculator
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
            int classNumber = 1;//variables
            string name = getStudentName();
            string className = "";
            do
            {
                className = getClassName();

                if (className != "" && className != "e" && className != "E")
                {
                    getClassGradeAndUnits(ref creditUnit, ref gradePoint, classNumber);

                    points = creditUnit * gradePoint;
                    totalPoints = points + totalPoints;//calculating gpa
                    totalCredits += creditUnit;
                    classNumber++;//updating classes taken counter
                  

                }

            }
            while (className != "" && className != "e" && className != "E");// outputting gpa as long as user does not press "e" to exit
            GPA = (decimal)totalPoints / (decimal)totalCredits;
            Console.Write("{0} your GPA for your classes are {1:N2}", name, GPA);
            Console.ReadKey();
        }

        private static string getClassName()//function to ask and get class name
        {
            string className = "";
            int counter = 0;
            Console.Write("Please enter the class you are taking:(or press E to see GPA) ", className, counter);//allows you to exit after putting in a class
            return Console.ReadLine();

        }

        private static string getStudentName()//function to get student name
        {
            string name = "";
            while (String.IsNullOrEmpty(name))//makes user put in name can not leave blank
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

       
            Console.Write("Enter grade for for your class #{0}: ", classNumber);//asking for classes using a counter so it shows class 1, then class 2 for the next question etc..

            userLetterGrade = char.Parse(Console.ReadLine());
            Console.Write("Enter credit unit(s) for grade: ");
            units = char.Parse(Console.ReadLine());
            if (char.IsDigit(units))
            {
                creditUnit = Int32.Parse(units.ToString());
                gradePoint = GpaInput(userLetterGrade, gradePoint);

            }

           
        }

        private static int GpaInput(char letterGrade, int gradePoint)
        {
            switch (letterGrade)
            {
                case 'A':// allowing user to input lowercase or uppercase b
                case 'a':
                    return 4;// based on grade input is how many credits youll get

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
