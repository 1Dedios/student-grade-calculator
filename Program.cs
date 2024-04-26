using System;

int currentAssignments = 5;

int[] sophiaAssignmentScores = new int[] { 90, 86, 87, 98, 100 };
int[] anderwiseAssignmentScores = new int[] { 92, 89, 81, 96, 90};
int[] emmaAssignmentScores = new int[] { 90, 85, 87, 98, 68 };
int[] loganAssignmentScores = new int[] { 90, 95, 87, 88, 96 };


int sophiaAssignmentSum = 0;
int andrewAssignmentSum = 0;
int emmaAssignmentSum = 0;
int loganAssignmentSum = 0;

decimal sophiaScore;
decimal andrewScore;
decimal emmaScore;
decimal loganScore;


foreach (int score in sophiaAssignmentScores) {
    sophiaAssignmentSum += score;
}

foreach (int score in anderwiseAssignmentScores) {
    andrewAssignmentSum += score;
}

foreach (int score in emmaAssignmentScores) {
    emmaAssignmentSum += score;
}

foreach (int score in loganAssignmentScores) {
    loganAssignmentSum += score;
}

sophiaScore = (decimal)sophiaAssignmentSum / currentAssignments;
andrewScore = (decimal)andrewAssignmentSum / currentAssignments;
emmaScore = (decimal)emmaAssignmentSum / currentAssignments;
loganScore = (decimal)loganAssignmentSum / currentAssignments;

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
