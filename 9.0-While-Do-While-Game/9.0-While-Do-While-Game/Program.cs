/*
Desafío de código: escribir código para implementar las reglas de juego
Estas son las reglas para el juego de batalla que necesita implementar en el proyecto de código:

Debes usar la instrucción do-while o la instrucción while como un bucle de juego externo.
El héroe y el monstruo comenzarán con 10 puntos de salud.
Todos los ataques serán un valor comprendido entre 1 y 10.
El héroe atacará primero.
Imprima la cantidad de salud que ha perdido el monstruo y su salud restante.
Si la salud del monstruo es mayor que 0, puede atacar al héroe.
Imprima la cantidad de salud que ha perdido el héroe y su salud restante.
Continúe con esta secuencia de ataque hasta que la salud del monstruo o del héroe sea cero o menos.
Imprima el ganador.
*/

int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");

/*
Examinar la diferencia entre las iteraciones de instrucción do y while
Como ha visto, C# admite cuatro tipos de instrucciones de iteración: for, foreach, do-while y while.
La documentación de referencia del lenguaje de Microsoft describe estas instrucciones de la siguiente manera:

La instrucción for ejecuta su cuerpo mientras una expresión booleana especificada (la condición) se evalúa como true.
La instrucción foreach enumera los elementos de una colección y ejecuta su cuerpo para cada elemento de la colección.
La instrucción do-while ejecuta condicionalmente su cuerpo una o varias veces.
La instrucción while no ejecuta condicionalmente su cuerpo o lo hace varias veces.

Las iteraciones for y foreach parecen estar claramente diferenciadas entre sí y de las iteraciones do-while y while.
Sin embargo, las definiciones de las instrucciones do-while y while parecen ser bastante similares.
Saber cuándo elegir entre un do-while y un while parece más arbitrario, e incluso puede ser un poco confuso.
Algunos proyectos de desafío pueden ayudar a aclarar las diferencias.

En este desafío, se le presentarán condiciones para tres proyectos de codificación independientes. 
Cada proyecto requerirá que implemente un bloque de código de iteración mediante una instrucción do-while o while.
Deberá evaluar las condiciones especificadas para elegir entre las instrucciones do-while y while. Puede cambiar
después de comenzar si su primera opción no funciona tan bien como esperaba.

Las condiciones del proyecto de codificación se pueden usar para ayudarle a seleccionar entre las instrucciones
do-while y while. Lo que sabe, o no sabe, sobre la expresión booleana que se evaluará, a veces puede ayudarle a 
seleccionar entre las instrucciones do-while y while. En este ejercicio de desafío, las condiciones del proyecto
incluyen información que se usará para construir la expresión booleana.

Administrar la entrada de usuario durante este desafío
Cuando se usa una instrucción Console.ReadLine() para obtener la entrada de usuario, es habitual usar una cadena
de tipo que acepta valores NULL (designada string?) para la variable de entrada y, a continuación, evaluar el valor
especificado por el usuario. El siguiente ejemplo de código utiliza una cadena de tipo que acepta 
valores NULL para capturar la entrada del usuario. La iteración continúa mientras el valor proporcionado
por el usuario es NULL:


string? readResult;
Console.WriteLine("Enter a string:");
do
{
    readResult = Console.ReadLine();
} while (readResult == null);

La expresión booleana evaluada por la instrucción while se puede usar para asegurarse de que la entrada
del usuario cumple un requisito especificado. Por ejemplo, si un mensaje pide al usuario que escriba 
una cadena que incluya al menos tres caracteres, se podría usar el siguiente código:
*/


string? readResult;
bool validEntry = false;
Console.WriteLine("Enter a string containing at least three characters:");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validEntry = true;
        }
        else
        {
            Console.WriteLine("Your input is invalid, please try again.");
        }
    }
} while (validEntry == false);


/*
Proyecto de código 1: escritura de código que valida la entrada de enteros:
Estas son las condiciones que el primer proyecto de codificación debe implementar:

La solución debe incluir una iteración do-while o while.

Antes del bloque de iteración: la solución debe usar una instrucción Console.WriteLine() para 
solicitar al usuario un valor de enteros entre 5 y 10.

Dentro del bloque de iteración:

La solución debe usar una instrucción Console.ReadLine() para obtener la entrada del usuario.

La solución debe asegurarse de que la entrada es una representación válida de un entero.

Si el valor del entero no está comprendido entre 5 y 10, el código debe usar una instrucción 
Console.WriteLine() para solicitar al usuario un valor del entero entre 5 y 10.

La solución debe garantizar que el valor de enteros está comprendido entre 5 y 10 antes de salir
de la iteración.

Debajo (después) del bloque de código de iteración, la solución debe usar una instrucción
Console.WriteLine() para informar al usuario de que se ha aceptado su valor de entrada.
*/

/*
Proyecto de código 2: escritura de código que valida la entrada de cadena
Estas son las condiciones que el segundo proyecto de codificación debe implementar:

La solución debe incluir una iteración do-while o while.

Antes del bloque de iteración, la solución debe usar una instrucción Console.WriteLine() para
solicitar al usuario uno de los tres nombres de rol: Administrador, Director o Usuario.

Dentro del bloque de iteración:

La solución debe usar una instrucción Console.ReadLine() para obtener la entrada del usuario.
La solución debe garantizar que el valor especificado coincide con una de las tres opciones de rol.
La solución debe usar el método Trim() en el valor de entrada para omitir los caracteres de espacio
iniciales y finales.
La solución debe usar el método ToLower() en el valor de entrada para omitir el caso.
Si el valor especificado no coincide con una de las opciones de rol, el código debe usar una instrucción Console.WriteLine()
para solicitar al usuario una entrada válida.
Debajo (después) del bloque de código de iteración, la solución debe usar una instrucción Console.WriteLine() para informar
al usuario de que se ha aceptado su valor de entrada.

Marcar como comentario todo el código en el panel editor de Visual Studio Code

Selección de todas las líneas de código en el editor de código
En el menú Edición, seleccione Alternar comentario de bloque.
Escriba el código que implementa cada condición para el proyecto de código 2.

Ejecute la aplicación y compruebe que el código valida la entrada de usuario en función de los requisitos especificados.

Por ejemplo, al ejecutar la aplicación, debe rechazar valores de entrada como "Admin", pero debe aceptar un valor de entrada
de "administrator".

*/

/*
 Proyecto de código 3: escritura de código que procesa el contenido de una matriz de cadenas
Estas son las condiciones que el tercer proyecto de codificación debe implementar:

La solución debe usar la siguiente matriz de cadenas para representar la entrada en la lógica de codificación:

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

La solución debe declarar una variable de enteros denominada periodLocation que se pueda usar para contener la ubicación del 
carácter de punto dentro de una cadena.

La solución debe incluir un bucle externo foreach o for que se pueda usar para procesar cada elemento de cadena de la matriz.
La variable de cadena que procesará dentro de los bucles debe denominarse myString.

En el bucle externo, la solución debe usar el método IndexOf() de la clase String para obtener la ubicación del primer
carácter de punto de la variable myString. La llamada al método debe ser similar a myString.IndexOf("."). Si no hay ningún
carácter de punto en la cadena, se devolverá un valor de -1.

La solución debe incluir un bucle interno do-while o while que se pueda usar para procesar la variable myString.

En el bucle interno, la solución debe extraer y mostrar (escribir en la consola) cada frase contenida en cada una de las 
cadenas que se procesan.

En el bucle interno, la solución no debe mostrar el carácter de punto.

En el bucle interno, la solución debe usar los métodos Remove(), Substring() y TrimStart() para procesar la información 
de cadena.

Marcar como comentario todo el código en el panel editor de Visual Studio Code

Selección de todas las líneas de código en el editor de código
En el menú Edición, seleccione Alternar comentario de bloque.
Escriba el código que implementa cada condición enumerada para el proyecto de código 3.

Ejecute la aplicación y compruebe que la salida cumple los requisitos.

*/

//PROYECTO 1

Console.WriteLine("PROYECTO 1");
string valueEntered = "";
int numValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        valueEntered = readResult;
    }

    validNumber = int.TryParse(valueEntered, out numValue);

    if (validNumber == true)
    {
        if (numValue <= 5 || numValue >= 10)
        {
            validNumber = false;
            Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
        }
    }
    else
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
} while (validNumber == false);

Console.WriteLine($"Your input value ({numValue}) has been accepted.");

readResult = Console.ReadLine();



//PROYECTO 2

Console.WriteLine("PROYECTO 2");

string roleName = "";


do
{
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        roleName = readResult.Trim();
    }

    if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user")
    {
        validEntry = true;
    }
    else
    {
        Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
    }

} while (validEntry == false);

Console.WriteLine($"Your input value ({roleName}) has been accepted.");
readResult = Console.ReadLine();


//PROYECTO 3

Console.WriteLine("PROYECTO 3");
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }

    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}