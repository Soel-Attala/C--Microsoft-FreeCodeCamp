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

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

//Dedique un minuto a revisar el código que está ejecutando.

/*
Para empezar, cree una nueva instancia de la clase System.Random y almacene una referencia al objeto en una variable
denominada dice. A continuación, llamamos al método Random.Next() en el objeto dice tres veces y proporcionamos
los límites inferior y superior para limitar los valores posibles entre 1 y 6 (el límite superior es exclusivo).
Guardamos los tres números aleatorios en las variables roll1, roll2 y roll3, respectivamente.

A continuación, se suman los tres dados y se guarda el valor en una variable entera denominada total.

Por último, use el método WriteLine() para mostrar los tres valores mediante la interpolación de cadenas.

Al ejecutar el código, debería ver el mensaje que se indica a continuación (los números serán diferentes).
*/

