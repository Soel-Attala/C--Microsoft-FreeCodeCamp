/*
La aplicación Student Grading se usa para calcular y notificar calificaciones de alumnos en función de su examen
calificado y de las asignaciones de crédito adicionales. Su objetivo en este desafío es actualizar el código que
genera un informe de puntuación de acuerdo con los requisitos actualizados del profesor.

En este primer ejercicio de desafío, tiene que crear instancias de las variables necesarias para el informe de
puntuación actualizado y, a continuación, actualizar la instrucción Console.WriteLine() que escribe las
calificaciones de los alumnos en la consola.

La aplicación actualizada debe:

usar las matrices y los valores de matriz existentes de todos los cálculos de calificaciones de alumnos.
usar la estructura anidada proporcionada por las instrucciones foreach y if existentes.
declarar e inicializar cualquier otra variable de entero que sea necesaria para calcular las sumas.
declarar e inicializar cualquier otra variable decimal que sea necesaria para los cálculos y valores de los informes de puntuación.

El formato del informe de puntuación actualizado es:

                      __________________________________________________________________
                      |  Student         Exam Score      Overall Grade   Extra Credit  |
                      |                                                                |
                      |  Sophia          0               95.8    A       0 (0 pts)     |
                      |  Andrew          0               91.2    A-      0 (0 pts)     |
                      |  Emma            0               90.4    A-      0 (0 pts)     |
                      |  Logan           0               93      A       0 (0 pts)     |
                      |________________________________________________________________|


Ejercicio: Actualización de los valores calculados

La aplicación Student Grading se usa para calcular y notificar calificaciones de alumnos en función de su examen
calificado y de las asignaciones de crédito adicionales. Su objetivo en este desafío es actualizar el código que
calcula las calificaciones de los alumnos de acuerdo con los requisitos actualizados del profesor.


*/

/*
ESPECIFICACIONES
En este segundo ejercicio de desafío, tiene que crear instancias de las variables necesarias para el informe de 
puntuación actualizado, completar los cálculos necesarios y, a continuación, actualizar la instrucción Console.WriteLine()
que escribe las calificaciones de los alumnos en la consola.

La aplicación actualizada debe:

Usar las matrices y los valores de matriz existentes de todos los cálculos de calificaciones de alumnos.

Usar la estructura anidada proporcionada por las instrucciones foreach y if existentes.

Calcular la suma de las puntuaciones de exámenes y asignaciones de crédito adicionales
mediante las variables del primer ejercicio o el código original.

Calcular el promedio de las puntuaciones de los exámenes y los créditos adicionales mediante las variables del
primer ejercicio o el código original.

Calcular la puntuación numérica final de la siguiente manera: agregue el 10 % de la suma de puntuación de crédito
adicional a la suma de puntuación del examen y, a continuación, divida ese valor por el número de exámenes.

Calcular los puntos de crédito adicionales obtenidos de la siguiente manera: divida el 10 % de la suma de puntuación
de crédito adicional por el número de exámenes.

*/

using System;
using System.Xml.Linq;

int examAssignments = 5;

// declaracion de arrays con las notas de cada alumno:

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };


// Nombres de los alumnos:
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };


int[] studentScores = new int[10];

string currentStudentLetterGrade = "";



foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Becky")
        studentScores = beckyScores;

    else if (currentStudent == "Chris")
        studentScores = chrisScores;

    else if (currentStudent == "Eric")
        studentScores = ericScores;

    else if (currentStudent == "Gregor")
        studentScores = gregorScores;

    else
        continue;

    int sumAssignmentScores = 0;
    decimal examSum = 0;
    decimal currentStudentGrade = 0;
    decimal examScores = 0;
    decimal extraCredits = 0;
    decimal creditSum = 0;

    //inicializamos el contador para el numero de asignaturas
    int gradedAssignments = 0;

    //sumatoria de notas
    foreach (int score in studentScores)
    {
        // Incrementamos el contador en 1
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
           examSum = sumAssignmentScores += score;
        
        else
        {
            sumAssignmentScores += score / 10;
            creditSum += score / 10;
        }
      
        
        
         
    }
    examScores = (decimal)(examSum) / examAssignments;
    extraCredits = (decimal)(creditSum)/examAssignments;
    
    currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";

    else currentStudentLetterGrade = "F";



    Console.WriteLine("Student\t\tExamScore\t\tOverall\t\tGrade\t\tExtraCredit");
    Console.WriteLine($"{currentStudent}\t\t {examScores}\t\t\t {currentStudentGrade}\t\t  {currentStudentLetterGrade}\t\t{examScores}({extraCredits})\n");



}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
Console.ReadLine();
