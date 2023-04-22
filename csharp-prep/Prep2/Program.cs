using System;

class Program
{
    static void Main(string[] args)
    {
        string gradeInput;
        while (true)
        {
            Console.Write("Enter your grade, It will be translated into a letter grade: ");
            gradeInput = Console.ReadLine();
            //Checks for valid input
            if (float.TryParse(gradeInput, out float number))
            {
                break; // Exit the loop if input is valid
            }
         else
            {
               Console.WriteLine("Invalid input. Please enter a number.");
            }
        }

        float grade = float.Parse(gradeInput);
        float gradeCheck = 60;
        //List created to print letter grade, using the gradeIndex variable as reference.
        List<string> letterGrade = new List<string> { "F","D","C","B","A"};
        int gradeIndex = 0;
        while (grade >= gradeCheck && gradeCheck != 100)
        {
            gradeCheck = gradeCheck + 10;
            gradeIndex = gradeIndex + 1;
        }
        string assignedGrade = letterGrade[gradeIndex];
        Console.WriteLine($"Here is your assigned grade: {assignedGrade}");

        if (grade < 70) //Check if the user passed, the fail if the grade is not at least 70
            {
                Console.WriteLine("Sorry, you did not pass. Try again! You can do it!");
            }
        else
            {
                Console.WriteLine("Congratulations on passing!");
            }

            
    }
}