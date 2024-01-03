using System;
using System.Collections;


/*                                              Introducción
El lenguaje de programación C# permite crear aplicaciones que emplean lógica de toma de decisiones.

Imagine que quiere mostrar información diferente al usuario final en función de algunas reglas de negocio.
Por ejemplo, ¿qué ocurre si quiere mostrar un mensaje especial en la factura de un cliente en función de su región
geográfica? ¿Y si quiere conceder a un cliente un descuento en función del tamaño de su pedido? ¿O si quiere mostrar
el puesto de un empleado en función de su nivel dentro de la empresa? En cada caso, sería necesario agregar la lógica
de decisión.

Al final de este módulo, podrá escribir código que pueda cambiar el flujo de la ejecución del código en función de algunos criterios.
*/

/*                      Ejercicio: Desarrollo de lógica de decisión con instrucciones if
La mayoría de las aplicaciones incluyen un gran número de rutas de acceso de ejecución. Por ejemplo, una aplicación
podría implementar diferentes rutas de ejecución en función de la opción de menú que seleccione un usuario. Los desarrolladores
hacen referencia al código que implementa diferentes rutas de ejecución como bifurcaciones de código.

La instrucción más utilizada para crear bifurcaciones de código es if. La instrucción if se basa en una expresión
booleana que se incluye entre paréntesis. Si la expresión es verdadera, se ejecutará el código que sigue a la instrucción if.
De lo contrario, el entorno de ejecución de .NET omitirá el código y no lo ejecutará.

En este ejercicio, practicará la escritura de instrucciones if mediante la creación de un juego. 
Primero definirá las reglas del juego y las implementarás en el código.

Usará el método Random.Next() para simular el lanzamiento de tres dados de seis caras.
Para calcular la puntuación, evaluará los valores obtenidos. 

    * Si la puntuación es mayor que un total arbitrario, se mostrará un mensaje de éxito al usuario. 
    * Si la puntuación está por debajo del límite, se mostrará un mensaje de fracaso al usuario.
    * Si dos dados cualesquiera muestran el mismo valor, se obtienen dos puntos extra por obtener un doble.
    * Si los tres dados muestran el mismo valor, se obtienen seis puntos extra por obtener un triple.
    * Si la suma de los tres dados, junto con los puntos extra, es igual o mayor que 15, gana el juego. De lo contrario, pierde.
*/
/*
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
*/
//Dedique un minuto a revisar el código que está ejecutando.

/*
Para empezar, cree una nueva instancia de la clase System.Random y almacene una referencia al objeto en una variable
denominada dice. A continuación, llamamos al método Random.Next() en el objeto dice tres veces y proporcionamos
los límites inferior y superior para limitar los valores posibles entre 1 y 6 (el límite superior es exclusivo).
Guardamos los tres números aleatorios en las variables roll1, roll2 y roll3, respectivamente.

A continuación, se suman los tres dados y se guarda el valor en una variable entera denominada total.

Por último, use el método WriteLine() para mostrar los tres valores mediante la interpolación de cadenas.

Al ejecutar el código, debería ver el mensaje que se indica a continuación (los números serán diferentes).

Dice roll: 4 + 5 + 2 = 11;
*/

/*  Incorporación de una instrucción if para mostrar diferentes mensajes según el valor de la variable total
        1.En el editor de Visual Studio Code, busque el cursor en la parte inferior del archivo de código 
          y cree una línea de código en blanco.
        2.Para crear tu primera característica de juego, escribe las siguientes instrucciones if.  

if (total >= 15)
{
    Console.WriteLine("You win!");
}

if (total < 15)
{
    Console.WriteLine("Sorry, you lose.");
}

*/



/*
Estas dos instrucciones if se usan para administrar los escenarios de éxito y fracaso. 
Dedique un minuto a examinar la primera instrucción if.

Observe que la instrucción if tiene tres partes:

La palabra clave if.
Una expresión booleana entre paréntesis ().
Un bloque de código delimitado por llaves { }.

En tiempo de ejecución, se evalúa la expresión booleana total > 14. Si se trata de una instrucción verdadera
(el valor de total es mayor que 14), el flujo de ejecución continuará con el código definido en el bloque de
código. En otras palabras, se ejecutará el código entre llaves.

Sin embargo, si la expresión booleana es falsa (el valor de total no es mayor que 14), el flujo de ejecución
omitirá el bloque de código. En otras palabras, no se ejecutará el código entre llaves.

Por último, la segunda instrucción if controla el mensaje si el usuario pierde. En la unidad siguiente,
usaremos una variación en la instrucción if para acortar estas dos instrucciones en una sola y expresar con
mayor claridad nuestra intención.
*/


/*                                  ¿Qué es una expresión booleana?
Una expresión booleana es cualquier código que devuelve un valor booleano, ya sea true o false.
Las expresiones booleanas más simples son los valores true y false. Como alternativa, una expresión booleana
podría ser el resultado de un método que devuelve los valores true o false. Por ejemplo, a continuación, 
se muestra un ejemplo de código sencillo que usa el método string.Contains() para evaluar si una cadena contiene
otra. 
*/

string message = "The quick brown fox jumps over the lazy dog.";
bool result = message.Contains("dog");
Console.WriteLine(result);

if (message.Contains("fox"))
{
    Console.WriteLine("What does the fox say?");
}

/*
Como message.Contains("fox") devuelve un valor true o false, cumple los requisitos de una expresión
booleana y se puede usar en una instrucción if.

Se pueden crear otras expresiones booleanas simples mediante el uso de operadores para comparar dos valores.
Los operadores incluyen:
    ==, el operador "igual que" para probar la igualdad
    >, el operador "mayor que" para probar si el valor a la izquierda es mayor que el valor a la derecha
    <, el operador "menor que" para probar si el valor a la izquierda es menor que el valor a la derecha
    >=, el operador "mayor o igual que"
    <=, el operador "menor o igual que"
    Etcétera.
*/

/*
En este ejemplo, hemos evaluado la expresión booleana total > 14. Sin embargo, se podría haber elegido la
expresión booleana total >= 15 porque, en este caso, son lo mismo. Las reglas del juego especifican que
"si la suma de los tres dados y cualquier punto extra, es igual a 15 puntos o más, se ganará el juego".
Por lo que probablemente debería implementar la expresión >= 15. En el siguiente paso del ejercicio, se llevará
a cabo ese cambio.
*/

/*                                       ¿Qué es un bloque de código?
Un bloque de código es una colección de una o varias líneas de código delimitadas por un símbolo de llave de
apertura y otro de cierre { }. Representa una unidad completa de código que tiene una única finalidad en nuestro
sistema de software. En este caso, en tiempo de ejecución, se ejecutan todas las líneas de código del bloque de
código si la expresión booleana es verdadera. Por el contrario, si la expresión booleana es falsa, se omiten todas
las líneas de código del bloque de código.

También debe saber que los bloques de código pueden contener más bloques de código. De hecho, es habitual que un
bloque de código esté "anidado" en otro bloque de código en las aplicaciones. Para comenzar, anidará sus propios 
bloques de código más adelante en este módulo al crear una instrucción if dentro de otro bloque de código.
*/



/*          Incorporación de otra instrucción if para implementar puntos extra por obtener dobles

A continuación, puede a implementar la siguiente regla: "Si dos dados cualesquiera muestran el mismo valor,
se obtendrán dos puntos extra por obtener dobles".
Modifique el código del paso anterior para que coincida con la lista de códigos siguiente:

    1. En el editor de Visual Studio Code, busque el cursor en la línea de código en blanco encima de la primera instrucción if.

    2. Para crear la característica de juego "dobles", escriba la siguiente instrucción if.

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}

*/

/*
Aquí se combinarán tres expresiones booleanas para crear una expresión booleana compuesta en una sola línea de
código. A veces, esto se denomina condición compuesta. Cuenta con un conjunto externo de paréntesis que combina
tres conjuntos internos de paréntesis separados por dos caracteres de barra vertical.

Los caracteres de barra vertical || son el operador O lógico, que básicamente indica “la expresión a la izquierda
O la expresión a la derecha deben ser verdaderas para que toda la expresión booleana sea verdadera”.
Si ambas expresiones booleanas son falsas, toda la expresión booleana será falsa.
A continuación, usará dos operadores lógicos "O" para ampliar la evaluación a una tercera expresión booleana.

En primer lugar, evaluará (roll1 == roll2). Si es verdadera, la expresión completa es verdadera.
Si la expresión es falsa, evaluará (roll2 == roll3). Si es verdadera, la expresión completa es verdadera.
Si la expresión es falsa, evaluará (roll1 == roll3). Si es verdadera, la expresión completa es verdadera. 
Si es falsa, la expresión completa es falsa.

Si la expresión booleana compuesta es verdadera, ejecutará el bloque de código siguiente. En esta ocasión,
hay dos líneas de código. La primera línea de código imprime un mensaje al usuario. 
La segunda línea de código incrementa el valor de total en 2.

Para mejorar la legibilidad del código, actualice la segunda instrucción if de la siguiente manera:

if (total >= 15)
{
    Console.WriteLine("You win!");
}

if (total < 15)
{
    Console.WriteLine("Sorry, you lose.");
}

*/


/*
Observe que ahora usa el operador >= en la expresión que se usa para evaluar una tirada ganadora.
El operador >= significa "mayor o igual que". Como consecuencia, podrá comparar total con un valor 15 en lugar de
14. Con estos cambios, la expresión que se usa para evaluar una tirada ganadora ahora es similar a la expresión 
que se evalúa para una tirada perdedora. Esto debería facilitar la comprensión del código (legibilidad).
Dado que se trabaja con valores enteros, la nueva expresión (total >= 15) funcionará de forma similar a la que
escribió anteriormente (total > 14).
*/

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}

if (total >= 15)
{
    Console.WriteLine("You win!");
}

if (total < 15)
{
    Console.WriteLine("Sorry, you lose.");
}


/*      Incorporación de otra instrucción if para implementar los puntos extra por obtener triples
A continuación, puede implementar la siguiente regla: "Si los tres dados que tire muestran el mismo valor,
obtendrá seis puntos extra por obtener un triple". Modifique el código de los pasos anteriores para que coincida
con la siguiente lista de códigos:


if ((roll1 == roll2) && (roll2 == roll3)) 
{
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
}

Ahora combinará dos expresiones booleanas para crear una expresión booleana compuesta en una sola línea de código. 
Cuenta con un conjunto externo de paréntesis que combina dos conjuntos internos de paréntesis separados por dos
caracteres de "Y" comercial.

Los caracteres && de Y comercial son el operador Y lógico, que básicamente indica “solo si ambas expresiones son
verdaderas, la expresión completa es verdadera”. En este caso, si roll1 es igual a roll2, y roll2 es igual 
a roll3, entonces, por deducción roll1, debe ser igual a roll3 y el usuario ha sacado triples.

*/


if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}

if ((roll1 == roll2) && (roll2 == roll3))
{
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
}

if (total >= 15)
{
    Console.WriteLine("You win!");
}

if (total < 15)
{
    Console.WriteLine("Sorry, you lose.");
}



//Ahora podemos probar nuestro juego de dados

//Pero ¿realmente se debería premiar al jugador por los puntos extra por la obtención de dobles y triples?
//Después de todo, una tirada de triples implica que también se lograron dobles.
//Lo ideal sería que los puntos extra no se acumulen. Deberían darse dos condiciones por separado
//con los puntos extra.
//Se trata de un error en la lógica que deberá corregirse.


/*              Ejercicio: Creación de una lógica de decisión anidada con if, else if y else
En la unidad anterior usamos varias instrucciones if para implementar las reglas de un juego. Sin embargo,
al final de la unidad, observamos que se necesitan instrucciones if más expresivas para corregir un error
sutil en el código.

En este ejercicio usaremos instrucciones if, else y else if para mejorar las opciones de bifurcación en el código y
corregir un error de lógica.
 
*/

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}

if ((roll1 == roll2) && (roll2 == roll3))
{
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
}

if (total >= 15)
{
    Console.WriteLine("You win!");
}

if (total < 15)
{
    Console.WriteLine("Sorry, you lose.");
}



//Dedíquele un minuto a examinar las dos instrucciones if al final del archivo:

if (total >= 15)
{
    Console.WriteLine("You win!");
}

if (total < 15)
{
    Console.WriteLine("Sorry, you lose.");
}


//Observe que ambas instrucciones if comparan total con el mismo valor numérico.
//Esta es la oportunidad perfecta para usar una instrucción else.
/*
Actualice las dos instrucciones if de la siguiente manera:

if (total >= 15)
{
    Console.WriteLine("You win!");
}
else 
{
    Console.WriteLine("Sorry, you lose.");
}
Aquí, si total >= 15 es false, se ejecutará el siguiente bloque de código; después se ejecutará la palabra
clave else. 
Dado que los dos resultados son contrarios, se trata de un escenario perfecto para la palabra clave else.
*/

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    Console.WriteLine("You rolled doubles!  +2 bonus to total!");
    total += 2;
}

if ((roll1 == roll2) && (roll2 == roll3))
{
    Console.WriteLine("You rolled triples!  +6 bonus to total!");
    total += 6;
}

if (total >= 15)
{
    Console.WriteLine("You win!");
}
else
{
    Console.WriteLine("Sorry, you lose.");
}


//Modificación del código para eliminar la acumulación de puntos extra por obtener dobles y triples con anidamiento

/*
En la unidad anterior, vimos que se introdujo un error de lógica sutil en la aplicación. 
Puede corregir ese problema si anida las instrucciones if.

El anidamiento nos permite colocar bloques de código dentro de otros bloques de código. 
En este caso, anidaremos una combinación de if y else (la comprobación de dobles) dentro de otra
instrucción if (la comprobación de triples) para evitar que se otorguen ambas bonificaciones.
*/

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}

if (total >= 15)
{
    Console.WriteLine("You win!");
}
else
{
    Console.WriteLine("Sorry, you lose.");
}

/*
Tómese un minuto para revisar las instrucciones if anidadas.

El objetivo es crear una construcción if-else interna en la que los dos resultados sean contrarios y,
a continuación, usar los resultados contrarios (if/true y else/false) para conceder los puntos de bonificación
para triples y dobles. Para lograr este objetivo, comprobamos si hay dobles en la instrucción if externa y, 
a continuación, triples en la instrucción if interna. Este patrón garantiza que, cuando la comprobación
interna de triples devuelva false, el bloque de código else puede conceder los puntos para los dobles.

Próximamente, "codificaremos de forma rígida" los resultados de las tres tiradas para probar la lógica del código.

Cree una línea de código en blanco encima de la línea donde se declara e inicializa total.

Para probar una tirada de dobles, escriba el código siguiente:

roll1 = 6;
roll2 = 6;
roll3 = 5;

Para probar una tirada de triples, actualice las variables de tirada codificadas de 
forma rígida como se indica a continuación:

roll1 = 6;
roll2 = 6;
roll3 = 6;

*/



/*Uso de instrucciones if, else y else if para ofrecer un premio en lugar de un mensaje de que ha ganado o perdido

Para que el juego sea más divertido, podemos cambiar la dinámica de ganar o perder
para adjudicar premios ficticios a cada puntuación.

Podemos ofrecer cuatro premios. El jugador solo debe ganar uno:
    * Si el jugador obtiene una puntuación igual o mayor que 16, gana un coche nuevo.
    * Si el jugador obtiene una puntuación igual o mayor que 10, gana un portátil nuevo.
    * Si el jugador obtiene una puntuación de 7, gana un viaje.
    * De lo contrario, el jugador gana un gatito.

*/

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}

if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}

/*
Tómese un minuto para revisar la construcción if-elseif-else actualizada.

Las instrucciones if, else if y else permiten crear varias condiciones exclusivas como expresiones booleanas.
En otras palabras, cuando solo queremos que se produzca un resultado, pero tenemos varias condiciones y resultados 
posibles, usaremos tantas instrucciones else if como queramos. Si no se aplica ninguna de las instrucciones
if y else if, se ejecutará el bloque de código else final. else es opcional, pero debe ser la última condición
si decide incluirla.

Use la técnica de codificar temporalmente de forma rígida las variables roll para probar cada mensaje.

*/



