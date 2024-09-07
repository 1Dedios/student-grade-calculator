using System;

int currentAssignments = 5;
int extraAssignmentWeight = 10;

int[] sophiaAssignmentScores = [90, 86, 87, 98, 100, 94, 90];
int[] andrewAssignmentScores = [92, 89, 81, 96, 90, 89];
int[] emmaAssignmentScores = [90, 85, 87, 98, 68, 89, 89, 89];
int[] loganAssignmentScores = [90, 95, 87, 88, 96, 96];

// put names of students in array
string[] studentNames = ["Sophia", "Andrew", "Emma", "Logan"];
int[] studentAssignmentSums = new int[currentAssignments*2];
string[] studentLetterGrades = new string[studentNames.Length*2];



foreach (string name in studentNames)
{
    if (name.Equals("Sophia"))
        studentAssignmentSums = sophiaAssignmentScores;
    else if (name.Equals("Andrew"))
        studentAssignmentSums = andrewAssignmentScores;
    else if (name.Equals("Emma"))
        studentAssignmentSums = emmaAssignmentScores;
    else if (name.Equals("Logan"))
        studentAssignmentSums = loganAssignmentScores;

    int gradedAssignments = 0;
    int currentStudentSums = 0;
    decimal currentTotalScore = 0;

    foreach (int score in studentAssignmentSums) 
    {
        if (gradedAssignments >= currentAssignments)
        {
            currentStudentSums += score / extraAssignmentWeight;
        }
        else
        {
            currentStudentSums += score;
        }
        gradedAssignments++;
    }

    currentTotalScore = (decimal)currentStudentSums / currentAssignments;

    // calculate the letter grade based on the total score and assign to current studentLetter
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
