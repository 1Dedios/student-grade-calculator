using System;

int currentAssignments = 5;

int[] sophiaAssignmentScores = new int[] { 90, 86, 87, 98, 100, 94, 90};
int[] andrewAssignmentScores = new int[] { 92, 89, 81, 96, 90, 89};
int[] emmaAssignmentScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganAssignmentScores = new int[] { 90, 95, 87, 88, 96, 96};

double sophiaAssignmentSum = 0;
int andrewAssignmentSum = 0;
int emmaAssignmentSum = 0;
int loganAssignmentSum = 0;

decimal sophiaTotalScore;
decimal andrewTotalScore;
decimal emmaTotalScore;
decimal loganTotalScore;

int extraAssignmentWeight = 10;
int gradedAssignments = 0;

foreach (int score in sophiaAssignmentScores) 
{

    if (gradedAssignments >= currentAssignments)
    {
        sophiaAssignmentSum += score / extraAssignmentWeight;
    }
    else
    {
        sophiaAssignmentSum += score;
    }
    gradedAssignments++;
    
}

gradedAssignments = 0;

foreach (int score in andrewAssignmentScores) 
{

    if (gradedAssignments >= currentAssignments)
    {
        andrewAssignmentSum += score / extraAssignmentWeight;
    }
    else 
    {
        andrewAssignmentSum += score;
    }
    gradedAssignments++;
}

gradedAssignments = 0;

foreach (int score in emmaAssignmentScores) 
{
    if (gradedAssignments >= currentAssignments)
    {
        emmaAssignmentSum += score / extraAssignmentWeight;
    }
    else
    {
        emmaAssignmentSum += score;
    }
    gradedAssignments++;
}

gradedAssignments = 0;

foreach (int score in loganAssignmentScores) 
{
    if (gradedAssignments >= currentAssignments)
    {
        loganAssignmentSum += score / extraAssignmentWeight;
    }
    else 
    {
        loganAssignmentSum += score;
    }
    gradedAssignments++;
}

sophiaTotalScore = (decimal)sophiaAssignmentSum / currentAssignments;
andrewTotalScore = (decimal)andrewAssignmentSum / currentAssignments;
emmaTotalScore = (decimal)emmaAssignmentSum / currentAssignments;
loganTotalScore = (decimal)loganAssignmentSum / currentAssignments;

decimal[] studentScores = {sophiaTotalScore, andrewTotalScore, emmaTotalScore, loganTotalScore};
string[] studentLetterGrades = new string[studentScores.Length*2];

for (int i = 0; i < studentScores.Length; i++) 
{
    decimal score = studentScores[i];

    if (score >= 97) {
        studentLetterGrades[i] = "A+";
        
    } else if (score >= 93) {
        studentLetterGrades[i] = "A";

    } else if (score >= 90) {
        studentLetterGrades[i] = "A-";

    } else if (score >= 87) {
        studentLetterGrades[i] = "B+";

    } else if (score >= 83) {
        studentLetterGrades[i] = "B";

    } else if (score >= 80) {
        studentLetterGrades[i] = "B-";  
        
    } else if (score >= 77) {
        studentLetterGrades[i] = "C+";

    } else if (score >= 73) {
        studentLetterGrades[i] = "C";

    } else if (score >= 70) {
        studentLetterGrades[i] = "C-"; 

    } else if (score >= 67) {
        studentLetterGrades[i] = "D+";

    } else if (score >= 63) {
        studentLetterGrades[i] = "D";

    } else if (score >= 60) {
        studentLetterGrades[i] = "D+";

    } else
        studentLetterGrades[i] = "F";
}

string sophiaLetterGrade = studentLetterGrades[0]; 
string andrewLetterGrade = studentLetterGrades[1];
string emmaLetterGrade = studentLetterGrades[2];
string loganLetterGrade = studentLetterGrades[3];

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + sophiaTotalScore + "\t" + sophiaLetterGrade);
Console.WriteLine("Andrew:\t\t" + andrewTotalScore + "\t" + andrewLetterGrade);
Console.WriteLine("Emma:\t\t" + emmaTotalScore + "\t" + emmaLetterGrade);
Console.WriteLine("Logan:\t\t" + loganTotalScore + "\t" + loganLetterGrade);

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
