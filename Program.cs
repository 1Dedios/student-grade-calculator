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
decimal sophiaTotalScore;
decimal andrewTotalScore;
decimal emmaTotalScore;
decimal loganTotalScore;

foreach (int score in sophiaAssignmentScores) {

    // integrate extra credit scores for each student
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

sophiaTotalScore = (decimal)sophiaAssignmentSum / currentAssignments;
andrewTotalScore = (decimal)andrewAssignmentSum / currentAssignments;
emmaTotalScore = (decimal)emmaAssignmentSum / currentAssignments;
loganTotalScore = (decimal)loganAssignmentSum / currentAssignments;

/*
- put the scores into an array and process in a for each with the if else letter grade statements - O(n)
- then process the above array into a for each as well that assigns the scores to each student letter grade variable - O(n)
*/

decimal[] studentScores = {sophiaTotalScore, andrewTotalScore, emmaTotalScore, loganTotalScore};
string[] studentLetterGrades = new string[studentScores.Length*2];

for (int i = 0; i < studentScores.Length; i++) 
{
    // if else statements to generate letter grades
    if (studentScores[i] >= 97) {
        // A+
        studentLetterGrades[i] = "A+";
        
    } else if (studentScores[i] >= 93) {
        // A
        studentLetterGrades[i] = "A";
    } else if (studentScores[i] >= 90) {
        // A-
        studentLetterGrades[i] = "A-";

    } else if (studentScores[i] >= 87) {
        //B+
        studentLetterGrades[i] = "B+";

    } else if (studentScores[i] >= 83) {
        // B
        studentLetterGrades[i] = "B";

    } else if (studentScores[i] >= 80) {
        //B-
        studentLetterGrades[i] = "B-";  
        
    } else if (studentScores[i] >= 77) {
        //C+
        studentLetterGrades[i] = "C+";

    } else if (studentScores[i] >= 73) {
        //C
        studentLetterGrades[i] = "C";

    } else if (studentScores[i] >= 70) {
        //C-
        studentLetterGrades[i] = "C-"; 

    } else if (studentScores[i] >= 67) {
        //D+
        studentLetterGrades[i] = "D+";

    } else if (studentScores[i] >= 63) {
        // D
        studentLetterGrades[i] = "D";

    } else if (studentScores[i] >= 60) {
        //D-
        studentLetterGrades[i] = "D+";

    } else
        // F 
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
