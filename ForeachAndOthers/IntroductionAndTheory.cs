/*
                                            Introducción
Las matrices de C# permiten almacenar secuencias de valores en una única estructura de datos. En otras palabras,
imagine una única variable que puede contener muchos valores. Una vez que tiene una única variable que almacena
todos los valores, puede ordenar los valores, invertir su orden, recorrer en bucle cada valor e inspeccionarlo
individualmente, etc.

Supongamos que trabajamos en el departamento de seguridad de una empresa que relaciona a vendedores en línea con
anunciantes que trabajan a comisión. Nos han pedido que escribamos código de C# que recorra en iteración los 
identificadores de los pedidos entrantes. Necesitamos inspeccionar cada identificador de pedido para identificar
los que pueden ser fraudulentos. Tendremos que implementar matrices para realizar esta tarea de programación.

En este módulo, creará e inicializará matrices. Establecerá y recuperará los valores de los elementos de una
matriz y accederá a cada elemento mediante su índice. Creará una lógica de bucle que le permitirá trabajar con 
cada elemento de una matriz.

Al final de este módulo, habrá trabajado con su primera estructura para contener varios valores de datos. 
Más adelante, en otros módulos, aprenderá a ordenar, filtrar, consultar, agregar y a realizar otras operaciones 
en los datos

                         Ejercicio: Introducción a los fundamentos de las matrices

Se pueden usar matrices para almacenar varios valores del mismo tipo en una sola variable. Los valores almacenados
en una matriz generalmente están relacionados. Por ejemplo, una lista de nombres de alumnos podría almacenarse en
una matriz de cadenas llamada students.

Su trabajo en el departamento de seguridad se centra en encontrar un patrón para los pedidos fraudulentos.
Quiere que el código revise los pedidos anteriores de los clientes e identifique los marcadores asociados a pedidos
fraudulentos. Su empresa espera que los marcadores se puedan usar para identificar posibles pedidos de compra 
fraudulentos en el futuro antes de que se procesen. Como no siempre se sabe de antemano cuántos pedidos hay que
revisar, no puede crear variables individuales que contengan cada identificador de pedido. 
¿Cómo se puede crear una estructura de datos que contenga varios valores relacionados?

En este ejercicio, usará matrices para almacenar y analizar una secuencia de identificadores de pedido.

*/

/*
                                            ¿Qué es una matriz?
Una matriz es una secuencia de elementos de datos individuales a los que se puede acceder a través de un nombre
de variable único. Se usa un índice numérico de base cero para acceder a cada elemento de una matriz.
Como puede ver, las matrices nos permiten recopilar datos similares que comparten un propósito o características 
comunes en una única estructura de datos para facilitar el procesamiento.

*/

/*
                        Declaración de matrices y acceso a elementos de matriz.
Una matriz es un tipo especial de variable que puede contener varios valores del mismo tipo de datos.
La sintaxis de la declaración es ligeramente diferente porque tiene que especificar tanto el tipo de
datos como el tamaño de la matriz.

1.  Para declarar una nueva matriz de cadenas que contengan tres elementos, escriba el código siguiente:
*/

//string[] fraudulentOrderIDs = new string[3];

/*
2.Dedique un minuto a examinar el código.
    El operador new crea una nueva instancia de una matriz en la memoria del equipo que puede contener tres valores
    de cadena. Para obtener más información sobre la palabra clave new, consulte el módulo “Llamada a métodos de la
    biblioteca de clases .NET mediante C#”.

    Observe que el primer conjunto de corchetes [] simplemente indica al compilador que la variable denominada
    fraudulentOrderIDs será una matriz, pero el segundo conjunto de corchetes [3] indica el número de elementos
    que puede contener la matriz.
    
    NOTA:
    Aunque en este ejemplo se muestra cómo declarar una matriz de cadenas, puede crear una matriz de todos los
    tipos de datos, incluidos los tipos primitivos como int y bool, así como tipos de datos más complejos, como
    las clases. En este ejemplo se usa la simplicidad de las cadenas para minimizar el número de ideas nuevas que
    debe comprender al principio.
*/

/*
                            Asignación de valores a los elementos de una matriz
En este punto, ha declarado una matriz de cadenas, pero todos los elementos de la matriz están vacíos.
Para acceder a un elemento de una matriz, se usa un índice numérico de base cero entre corchetes. Para asignar un
valor a un elemento de la matriz, use el valor = como si fuera una variable normal.

1.Para asignar valores de identificación de pedidos a la matriz fraudulentOrderIDs, actualice el código de
la siguiente manera:
*/

string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";

/*
Dedique un minuto a examinar el código.

Observe que usa el nombre de la matriz para acceder a los elementos de la matriz. A cada elemento se acede 
individualmente especificando el número de índice de base cero entre corchetes.

Puesto que la matriz se declara como una cadena, los valores que asigne también deben ser cadenas. En este 
escenario, va a asignar identificadores de pedido a los elementos de la matriz.

*/


/*              Intento de usar un índice que está fuera de los límites de la matriz


Podría no parecer intuitivo al principio, pero es importante recordar que estamos declarando el número de
elementos de la matriz. Sin embargo, se accede a los elementos de la matriz a partir de cero. Por lo tanto, 
para acceder al segundo elemento de la matriz, se usa el índice 1.

Es habitual que los principiantes olviden que las matrices son de base cero e intenten acceder a un elemento de
la matriz que no existe. Si comete este error, se produce una excepción en tiempo de ejecución por haber intentado
obtener acceso a un elemento que está fuera del límite de la matriz.

Para "interrumpir" intencionadamente la aplicación, intente acceder a un cuarto elemento de la matriz mediante
el valor de índice de 3.

*/

//1. En la parte inferior del archivo de código, escriba la siguiente línea de código:
fraudulentOrderIDs[3] = "D000";

//2. Asegúrese de que el código coincide con este ejemplo:

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
fraudulentOrderIDs[3] = "D000";
/*
3. En el menú Archivo Visual Studio Code, seleccione Guardar.

4. En el panel EXPLORADOR, para abrir un terminal en la ubicación de la carpeta TestProject, haga clic con el
   botón derecho en TestProject y seleccione abrir en terminal integrado.

   Se abrirá un panel de terminal que debe incluir un símbolo del sistema que muestra que el terminal está
   abierto en la ubicación de carpeta TestProject.

5. En el símbolo del sistema del terminal, para compilar el código, escriba dotnet build y presione Entrar.
    Verá el mensaje siguiente:

       Build succeeded.        
       0 Warning(s)
       0 Error(s)

 6. En el símbolo del sistema del terminal, para ejecutar el código, escriba dotnet run y presione Entrar.
    Al ejecutar la aplicación, recibirá el siguiente mensaje de error en tiempo de ejecución:

    Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.     
    at Program.<Main>$(String[] args) in C:\Users\someuser\Desktop\CsharpProjects\TestProject\Program.cs:line 6
    
    Observe las siguientes partes del error:
    Mensaje de error: System.IndexOutOfRangeException: Index was outside the bounds of the array.
    Ubicación del error: Program.cs:line 6

 7. Convierta en comentario la línea que generó el error en tiempo de ejecución.
    //fraudulentOrderIDs[3] = "D000";

Ha visto cómo asignar un valor a un elemento de la matriz. Ahora verá cómo obtener acceso a un valor que se 
almacena en un elemento de la matriz.

*/



/*                              Recuperación de valores de elementos de una matriz  
Acceder al valor de un elemento de la matriz es lo mismo que asignar un valor a un elemento de la matriz. 
Solo tiene que especificar el índice del elemento cuyo valor quiere recuperar.

1. Para escribir el valor de cada identificador de pedido fraudulento, actualice el código de la siguiente manera: 
*/

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// al ejecutar en la consola vera el siguiente mensaje:
//First: A123
//Second: B456
//Third: C789
//Reassign First: F000

/*                                  Uso de la propiedad Length de una matriz
En función de cómo se cree la matriz, es posible que no sepa de antemano cuántos elementos contiene.
Para determinar el tamaño de una matriz, puede usar la propiedad Length.
*/

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

//Este código usa la propiedad Length de la matriz, un entero, para devolver el número de elementos
//de la matriz fraudulentOrderIDs.

/*
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";
*/

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
/*
Guarde los cambios en el archivo Program.cs y, a continuación, ejecute la aplicación.
Debería ver la siguiente salida:
First: A123
Second: B456
Third: C789
Reassign First: F000
There are 3 fraudulent orders to process.
*/

