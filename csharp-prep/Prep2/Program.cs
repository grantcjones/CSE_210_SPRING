using System.Runtime.Serialization;
using static System.Console;
class Program
{
    static void Main(string[] args)
    {
        Write("Enter your grade percentage: ");
        string inputGrade = ReadLine();
        int myGrade = int.Parse(inputGrade);

        string letterGrade;

        if (myGrade >= 90 )
        {
            letterGrade = "A";
        }
        else if (myGrade < 90 && myGrade >= 80)
        {
            letterGrade = "B";
        }
        else if (myGrade < 80 && myGrade >= 70)
        {
            letterGrade = "C";
        }
        else if (myGrade < 70 && myGrade >= 60)
        {
           letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        int plusMinus = myGrade % 10;

        if ((letterGrade != "A" && letterGrade != "F"))
        {
            if (plusMinus >= 7)
            {
                letterGrade = letterGrade + "+";
            }
            else if (plusMinus < 3)
            {
                letterGrade = letterGrade + "-";
            }
        }

        WriteLine(letterGrade);

        if (myGrade >= 70)
        {
            Write("Congrats! You've passed this class");
        }
        else 
        {
            Write("I'm sorry, you have failed this class. Please try again.");
        }
        
    }
}