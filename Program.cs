using System;

int currentAssignments = 5;

int sophiaAssignment1 = 90;
int sophiaAssignment2 = 86;
int sophiaAssignment3 = 87;
int sophiaAssignment4 = 98;
int sophiaAssignment5 = 100;

int andrewAssignment1 = 92;
int andrewAssignment2 = 89;
int andrewAssignment3 = 81;
int andrewAssignment4 = 96;
int andrewAssignment5 = 90;

int emmaAssignment1 = 90;
int emmaAssignment2 = 85;
int emmaAssignment3 = 87;
int emmaAssignment4 = 98;
int emmaAssignment5 = 68;

int loganAssignment1 = 90;
int loganAssignment2 = 95;
int loganAssignment3 = 87;
int loganAssignment4 = 88;
int loganAssignment5 = 96;

int sophiaAssignmentSum = 0;
int andrewAssignmentSum = 0;
int emmaAssignmentSum = 0;
int loganAssignmentSum = 0;

decimal sophiaScore;
decimal andrewScore;
decimal emmaScore;
decimal loganScore;

sophiaAssignmentSum = sophiaAssignment1 + sophiaAssignment2 + sophiaAssignment3 + sophiaAssignment4 + sophiaAssignment5;
andrewAssignmentSum = andrewAssignment1 + andrewAssignment2 + andrewAssignment3 + andrewAssignment4 + andrewAssignment5;
emmaAssignmentSum = emmaAssignment1 + emmaAssignment2 + emmaAssignment3 + emmaAssignment4 + emmaAssignment5;
loganAssignmentSum = loganAssignment1 + loganAssignment2 + loganAssignment3 + loganAssignment4 + loganAssignment5;


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
