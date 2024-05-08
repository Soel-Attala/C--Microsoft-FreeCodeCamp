/*

        
                        Ejercicio: Creación y configuración para los bucles de iteración.

A primera vista, la instrucción for es otra instrucción de iteración que permite recorrer en iteración un bloque
de código y, de este modo, cambiar el flujo de ejecución del código. Sin embargo, una vez que se examina su
funcionamiento, podemos identificar mejor los matices de cada instrucción de iteración y cuándo usarlas.



                                      ¿Qué es la instrucción for?

La instrucción for recorre en iteración un bloque de código un número específico de veces. Este nivel de control 
hace que la instrucción for sea única entre las demás instrucciones de iteración. La instrucción foreach recorre
en iteración un bloque de código una vez por cada elemento de una secuencia de datos, como, por ejemplo, una 
matriz o colección. La instrucción while recorre en iteración un bloque de código hasta que se cumple una
condición.

Asimismo, la instrucción for proporciona un mayor control sobre el proceso de iteración gracias a que se exponen
las condiciones para la iteración.

En este ejercicio, usará la instrucción for, aprenderá a controlar la condición previa de la iteración, la
condición de finalización, su patrón de iteración, etc. Además, verá casos de uso comunes de la instrucción for.

Bien, ahora vamos a preparar nuestro entorno de codificación y a comenzar a examinar ejemplos de código que
implementan una instrucción for.


Escritura de una instrucción for básica:

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
Dedíquele un minuto a identificar las seis partes de la instrucción for.

La instrucción for incluye las seis partes siguientes:

La palabra clave for.
Un conjunto de paréntesis que define las condiciones de la iteración for. Los paréntesis contienen tres partes
distintas separadas por el operador de fin de instrucción, que es un punto y coma.
La primera parte define e inicializa la variable del iterador. En este ejemplo, int i = 0. Esta sección se conoce
como inicializador.
La segunda parte define la condición de finalización. En este ejemplo, i < 10. En otras palabras, el entorno
de ejecución seguirá iterando por el código del bloque de código que está debajo de la instrucción for mientras
i sea menor que 10. Cuando i es igual a 10, el entorno de ejecución deja de ejecutar el bloque de código de la 
instrucción for. En la documentación se hace referencia a esta sección como condición.
La tercera parte define la acción que se realizará después de cada iteración. En este caso, después de cada
iteración, i++ incrementará el valor de i en 1. En la documentación se hace referencia a esta sección como
iterador.
Por último, el bloque de código. El bloque de código contiene el código que se ejecutará con cada iteración.
Observe que se hace referencia al valor de i dentro del bloque de código. En la documentación se hace referencia 
a esta sección como cuerpo.


Dadas nuestras reglas para asignar nombres a las variables, puede que se pregunte si i es un nombre válido para
la variable que contiene la iteración actual. En este caso, la mayoría considera que i es un nombre válido.
Otras opciones populares son x y counter. También se utiliza el nombre j en aquellas situaciones en las que
existe una instrucción for externa que usa i y se quiere crear una variable de iteración para una instrucción 
for interna.

for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine(i);
}


salida:
0
3
6
9



Uso de la palabra clave break para interrumpir la instrucción de iteración:
¿Cómo se puede salir prematuramente de la instrucción de iteración en función de una condición?
Podemos usar la palabra clave break.

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}

la salida sería:
0
1
2
3
4
5
6
7


                        Recorrido en bucle de todos los elementos de una matriz

Un uso habitual de la instrucción for es recorrer en iteración una matriz de elementos, en especial si se 
necesita cierto control sobre la manera en la que la iteración se produce. Si bien foreach recorre en iteración
todos los elementos de la matriz, la instrucción for se puede ajustar para proporcionar una mayor personalización.

 string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}

En primer lugar, observe que hemos creado una instancia de una matriz de cadenas denominada names que contiene 
cuatro nombres.

A continuación, observe que usamos la propiedad Array.Length para obtener el número de elementos de la matriz y
que usamos este valor para inicializar nuestra variable de iterador (int i = names.Length - 1). Restamos 1 del 
valor porque el número de índice de los elementos de matriz es de base cero (los números de índice de los cuatro
elementos son 0-3).

Por último, observe que hemos elegido recorrer en iteración la matriz hacia atrás, algo que no podemos hacer 
con la instrucción foreach. Usamos el valor de la variable de iteración dentro del bloque de código para 
especificar el número de índice de los elementos de matriz (names[i]).



                            Examen de la limitación de la instrucción foreach

string[] names = { "Alex", "Eddie", "David", "Michael" };
foreach (var name in names)
{
    // Can't do this:
    if (name == "David") name = "Sammy";
}

Observe el mensaje de error que se muestra.

Si se intenta compilar y ejecutar este código, aparecerá una excepción.
Cannot assign to name because it is a 'foreach iteration variable'

En otras palabras, no se puede reasignar el valor de name porque forma parte de la implementación interna
de la iteración foreach.



        Superación de la limitación de la instrucción foreach mediante la instrucción for

Vamos a intentar usar una instrucción for para modificar el contenido de una matriz dentro del bloque de código de iteración.

string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names.Length; i++)
    if (names[i] == "David") names[i] = "Sammy";

foreach (var name in names) Console.WriteLine(name);


aqui esta la forma larga de escribir el codigo abreviado:

string[] names = { "Alex", "Eddie", "David", "Michael" };

for (int i = 0; i < names.Length; i++)
{
    if (names[i] == "David")
    {
        names[i] = "Sammy";
    }
}

foreach (var name in names)
{
    Console.WriteLine(name);
}


La salida sería la siguiente:

Alex
Eddie
Sammy
Michael


                                            Resumen
    
Estos son algunos de los aportes de esta unidad:

La instrucción de iteración for permite recorrer en iteración un bloque de código un número específico de veces.

La instrucción de iteración for permite controlar todos los aspectos de la mecánica de la iteración mediante 
la modificación de las tres condiciones que se encuentran dentro de los paréntesis: el inicializador, la
condición y el iterador.

Es habitual utilizar la instrucción for cuando se necesita controlar la manera de recorrer en iteración cada
elemento de una matriz.

Si el bloque de código tiene solo una línea de código, podemos eliminar las llaves y el espacio en blanco.
 



                                        Desafío FizzBuzz
FizzBuzz es un conocido desafío de codificación y un tema que se suele plantear en las entrevistas.
Sirve para ejercitar la comprensión de las instrucciones for y if, el operador de resto % y el dominio de
la lógica básica.

Estas son las reglas de FizzBuzz que necesita implementar en el proyecto de código:

Valores de salida de 1 a 100, un número por línea, dentro del bloque de código de una instrucción de iteración.
Si el valor actual es divisible por 3, se imprime el término Fizz junto al número.
Si el valor actual es divisible por 5, se imprime el término Buzz junto al número.
Si el valor actual es divisible por 3 y por 5, se imprime el término FizzBuzz junto al número.

*/

for (int i = 1; i < 101; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
        Console.WriteLine($"{i} - FizzBuzz");
    else if (i % 3 == 0)
        Console.WriteLine($"{i} - Fizz");
    else if (i % 5 == 0)
        Console.WriteLine($"{i} - Buzz");
    else
        Console.WriteLine($"{i}");
}

