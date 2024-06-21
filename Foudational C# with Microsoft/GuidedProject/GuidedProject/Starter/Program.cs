using System;

int currentAssignments = 5;

int[] sophiaScores = { 90, 86, 87, 98, 100 };
int[] andrewScores = { 92, 89, 81, 96, 90 };
int[] emmaScores = { 90, 85, 87, 98, 68 };
int[] loganScores = { 90, 95, 87, 88, 96 };

string[] studentsNames = { "Sophia", "Andrew", "Emma", "Logan" };

int sophiaSum = 0;
int andrewSum = 0;
int emmaSum = 0;
int loganSum = 0;


foreach (string studentName in studentsNames)
{
    switch (studentName)
    {
        case "Sophia":
            foreach (int score in sophiaScores)
            {
                sophiaSum += score;
            }
            break;
        case "Andrew":
            foreach (int score in andrewScores)
            {
                andrewSum += score;
            }
            break;
        case "Emma":
            foreach (int score in emmaScores)
            {
                emmaSum += score;
            }
            break;
        case "Logan":
            foreach (int score in loganScores)
            {
                loganSum += score;
            }
            break;
    }

}

decimal sophiaScore;
decimal andrewScore;
decimal emmaScore;
decimal loganScore;



sophiaScore = (decimal)sophiaSum / currentAssignments;
andrewScore = (decimal)andrewSum / currentAssignments;
emmaScore = (decimal)emmaSum / currentAssignments;
loganScore = (decimal)loganSum / currentAssignments;

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
