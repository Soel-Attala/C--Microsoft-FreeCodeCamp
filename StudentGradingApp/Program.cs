
/*
En este proyecto guiado, usaremos Visual Studio Code para desarrollar una aplicación de C#.
La aplicación usará matrices, instrucciones foreach e instrucciones if para implementar una lista de parámetros
de diseño. Comenzaremos por crear las variables de matriz que contengan los datos de la aplicación.
Para completar el proyecto, desarrollaremos instrucciones foreach y if que implementarán los objetivos
de diseño de la aplicación.
*/


/*
Estamos desarrollando una aplicación Student Grading que automatiza el cálculo de las calificaciones para 
los alumnos de una clase. Los parámetros de la aplicación son:

Cree una aplicación de consola de C#.

Comience con cuatro alumnos. Cada alumno tiene cinco notas de examen.

Cada nota de examen es un valor entero, de 0 a 100, donde 100 representa el 100 % correcto.

La calificación global del examen de un alumno es el promedio de sus cinco notas de examen.

Criterios para las tareas de créditos adicionales:

Incluya notas de tareas de créditos adicionales en la matriz de notas del alumno.

Las asignaciones de créditos adicionales valen el 10 % de una nota de examen (al calcular la nota numérica final).

Agregaremos las notas de las tareas de créditos adicionales a la nota total del examen del alumno antes de calcular
la calificación numérica final.

La aplicación debe asignar automáticamente calificaciones con letras en función de la nota final calculada para
cada alumno.

La aplicación debe generar o mostrar el nombre de cada alumno y la nota con formato.

La aplicación debe admitir la incorporación de otros alumnos y de otras notas sin que ello afecte al código en gran medida.

Ya hemos completado una versión inicial de la aplicación. El proyecto de código de inicio para este módulo de proyecto 
guiado incluye un archivo Program.cs con las características de código siguientes:

El código declara las variables que se usan para definir los nombres de los alumnos y las notas de los exámenes individuales para cada alumno.
El código incluye las variables y los algoritmos que se usan para sumar las notas de los exámenes y calcular la nota media de los exámentes para cada alumno.
El código incluye una calificación con letra codificada de forma rígida que el desarrollador debe aplicar manualmente.
El código incluye instrucciones Console.WriteLine() para mostrar el informe de las calificaciones del alumno.
El objetivo es actualizar el código existente para incluir las siguientes características:

Use matrices para almacenar los nombres de los alumnos y las notas de las tareas.

Use una instrucción foreach para recorrer en iteración los nombres de los alumnos como bucle de programa externo.

Use una instrucción if dentro del bucle externo para identificar el nombre del alumno actual y acceder a las notas de las tareas de ese alumno.

Use una instrucción foreach dentro del bucle externo para recorrer en iteración la matriz de las notas de las tareas y sumar los valores.

Use un algoritmo actualizado dentro del bucle externo para calcular la nota media de los exámenes para cada alumno.

Utilice una construcción if-elseif-else dentro del bucle externo para evaluar la nota media de los exámenes y asignar automáticamente una calificación con letra.

Integre las notas de los créditos adicionales al calcular la calificación numérica y con letra final del alumno de la siguiente manera:

El código debe detectar las tareas de créditos adicionales en función del número de elementos de la matriz de notas del alumno.
El código debe aplicar el factor de ponderación del 10 % a las tareas de créditos adicionales antes de agregar notas de créditos adicionales a la suma de las calificaciones de los exámenes.

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

    decimal currentStudentGrade = 0;
     

    //inicializamos el contador para el numero de asignaturas
    int gradedAssignments = 0;

        //sumatoria de notas
        foreach (int score in studentScores)
        {
        // Incrementamos el contador en 1
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
            sumAssignmentScores += score;
        else
            sumAssignmentScores += score / 10;
        }

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



    Console.WriteLine("Student\t\tGrade");
    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}\n");



}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
Console.ReadLine();

