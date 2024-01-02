/*                          Ejercicio: Llamada a los métodos de una clase .NET
Ya sea que se haya dado cuenta o no, ha estado llamando a métodos de C# desde su primera aplicación "¡Hola, mundo!".
Esa aplicación usa el método WriteLine() de la clase Console para mostrar el mensaje "¡Hola, mundo!".

Aun así, no todas las clases y métodos se implementan de la misma manera. En esta unidad se tratarán algunas de las
variantes más habituales que debe comprender al usar métodos de la biblioteca de clases .NET. Lo que es más importante,
aprenderá a buscar y usar la documentación para comprender mejor cada método.

*/

/*                          Procedimiento para llamar a métodos en la biblioteca de clases .NET
 A partir de la experiencia anterior con el método Console.WriteLine(), ya debe conocer los aspectos básicos:

    * Empiece por escribir el nombre de la clase. En este caso, el nombre de clase es Console.
    * Agregue el operador de acceso al miembro, el símbolo ..
    * Agregue el nombre del método. En este caso, el nombre del método es WriteLine.
    * Agregue el operador de invocación del método, que es un conjunto de paréntesis ().
    * Por último, especifique los argumentos que se pasan al método, si hay alguno, entre paréntesis del operador de invocación de método.
    * En este caso, se especifica el texto que desea que el método Console.WriteLine() escriba en la consola (por ejemplo, "Hello World!").

Opcionalmente, en función de cómo los desarrolladores hayan diseñado e implementado el método determinado,
es posible que también necesite:

    * Pase valores adicionales como parámetros de entrada.
    * Acepte un valor devuelto. 
*/



/*                          Llame a diferentes tipos de métodos en la biblioteca de clases .NET
En el editor de Visual Studio Code, para crear un ejemplo de código que implemente métodos de las clases System.Random y System.Console,
escriba el código siguiente: 
*/
Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);

//Este código simula un lanzamiento de dados mediante el método Random.Next() para generar un número
//y el método Console.WriteLine() para mostrar el valor.

//En la tercera línea de código, se incluye una referencia a la clase Console y se llama directamente al
//método Console.WriteLine(). Sin embargo, se usa una técnica diferente para llamar al método Random.Next().
//La razón por la que está usando dos técnicas distintas se debe a que algunos métodos tienen estado y otros no.
//El siguiente paso es examinar la diferencia entre los métodos con estado y sin estado.

/*                                          MÉTODOS CON Y SIN ESTADO
En los proyectos de desarrollo de software, el término estado se usa para describir la condición del entorno de 
ejecución en un momento específico en el tiempo. A medida que el código se ejecuta línea a línea, los valores se
almacenan en variables. En cualquier momento durante la ejecución, el estado actual de la aplicación es la recopilación
de todos los valores almacenados en la memoria. 

Algunos métodos no se basan en el estado actual de la aplicación para que funcione correctamente. En otras palabras,
los métodos sin estado se implementan para poder funcionar sin hacer referencia a los valores que ya están almacenados
en la memoria y sin cambiarlos. Los métodos sin estado también se conocen como métodos estáticos.

Por ejemplo, el método Console.WriteLine() no se basa en ningún valor almacenado en memoria. Realiza su función y finaliza
sin afectar al estado de la aplicación de ningún modo.

Otros métodos, sin embargo, deben tener acceso al estado de la aplicación para funcionar correctamente.
En otras palabras, los métodos con estado se compilan de forma que dependen de los valores almacenados en memoria por líneas
anteriores de código que ya se han ejecutado. O bien modifican el estado de la aplicación actualizando valores o almacenando
nuevos valores en la memoria. También se conocen como métodos de instancia.

Los métodos con estado (de instancia) realizan un seguimiento de su estado en campos, que son variables definidas en la clase.
Cada nueva instancia de la clase obtiene su propia copia de los campos en los que se va a almacenar el estado.

Una sola clase puede admitir métodos con y sin estado. Sin embargo, cuando necesite llamar a métodos con estado,
debe crear primero una instancia de la clase para que el método pueda tener acceso al estado.
 
*/




/*                                          CREAR UNA INSTANCIA DE UNA CLASE
Una instancia de una clase se denomina objeto. Para crear una nueva instancia de una clase, use el operador new.
Considere la siguiente línea de código que crea una nueva instancia de la clase Random para crear un nuevo objeto
denominado dice:
*/

Random dice2 = new Random();

/*
    El operador new realiza varias acciones importantes:

    * Primero solicita una dirección en la memoria del equipo lo suficientemente grande como para almacenar un nuevo objeto basado en la clase Random.
    * Crea el nuevo objeto y lo almacena en la dirección de memoria.
    * Devuelve la dirección de memoria para que se pueda guardar en la variable dice.
    
  A partir de ese momento, cuando se hace referencia a la variable dice, el runtime de .NET realiza una búsqueda en
  segundo plano para dar la sensación de que se está trabajando directamente con el propio objeto.

La versión más reciente del entorno de ejecución de .NET permite crear instancias de un objeto sin tener que repetir
el nombre de tipo (invocación de constructor con tipo de destino). Por ejemplo, el código siguiente creará 
una nueva instancia de la clase Random: 
*/

Random dice3 = new();

//La idea es simplificar la legibilidad del código.
//Siempre se usan paréntesis al escribir una expresión con tipo de destino new.


/*                          ¿Por qué el método Next() tiene estado?
Es posible que se pregunte por qué el método Next() se implementó como un método con estado. 
¿Los diseñadores de la biblioteca de clases .NET no podían haber ideado una forma de generar un número aleatorio sin que se requiera un estado? 
¿Y qué almacena exactamente o a qué hace referencia el método Next()?

Son buenas preguntas. A nivel general, los equipos siguen bien las instrucciones específicas para crear un resultado repetible y confiable. 
Para dar sensación de aleatoriedad, los desarrolladores del método Next() decidieron capturar la fecha y el tiempo hasta la fracción de un milisegundo 
y usarlo para inicializar un algoritmo que genera un número diferente cada vez. Aunque no es totalmente aleatorio, es suficiente para la mayoría de las aplicaciones.
El estado que se captura y se mantiene durante el tiempo de vida del objeto dice es el valor de inicialización. Cada llamada subsiguiente 
al método Next() vuelve a ejecutar el algoritmo, pero garantiza que el valor de inicialización cambie para que no se devuelva (necesariamente) el mismo valor.

Sin embargo, para usar el método Random.Next() no es necesario entender cómo funciona. Lo importante es saber 
que algunos métodos requieren que se cree una instancia de una clase antes de llamarlos, mientras que otros no.

*/


/*      ¿Cómo se puede determinar si es necesario crear una instancia de una clase antes de llamar a sus métodos?
Un enfoque para determinar si un método es con estado o sin estado es consultar la documentación. La documentación incluye ejemplos 
que muestran si se debe llamar al método desde la instancia de objeto o directamente desde la clase.

Como alternativa a la búsqueda a través de la documentación del producto, puede intentar acceder al método directamente desde la propia clase.
Si funciona, sabe que es un método sin estado. Lo peor que puede suceder es que obtenga un error de compilación.

Intente acceder directamente al método Random.Next() y observe qué sucede.


Observe que Visual Studio marcará un error y devolvera por consola
(1,14): error CS0120: An object reference is required for the non-static field, method, or property 'Random.Next()'

Como vio en el código al principio de la unidad, puede corregir este error mediante la creación de una instancia 
de la clase Random antes de acceder al método Next(). Por ejemplo:
*/
Random dice5 = new Random();
int roll2 = dice.Next();
//En este caso, se llama al método Next() sin parámetros de entrada.




/*                     Ejercicio: Devolución de valores y parámetros de entrada de los métodos
En la unidad anterior, hemos usado un escenario de codificación "tirada de dados" para ilustrar la diferencia 
entre los métodos con estado (instancia) y sin estado (estáticos). Ese mismo escenario puede ayudarnos 
a comprender otros conceptos importantes sobre la llamada a métodos. Por ejemplo:
    * control del valor devuelto de un método.
    * pasada de parámetros de entrada a un método.
    * elección de una versión sobrecargada de un método.

*/

/*                                              Valores devueltos
Algunos métodos están diseñados para completar su función y finalizar "silenciosamente". 
En otras palabras, no devuelven valores cuando finalizan. Se hace referencia a ellos como métodos nulos (void).

Otros métodos están diseñados para devolver un valor al finalizar. 
El valor devuelto suele ser el resultado de una operación. 
Un valor devuelto es la forma principal de comunicación de un método con el código que lo llama.

Ha visto que el método Random.Next() devuelve un tipo int que contiene el valor del número generado aleatoriamente.
Sin embargo, un método se puede diseñar para devolver cualquier tipo de datos, e incluso otra clase.
Por ejemplo, la clase String tiene algunos métodos que devuelven una cadena, otros que devuelven un entero y otros que devuelven un valor booleano.

Al llamar a un método que devuelve un valor, a menudo asignaremos el valor devuelto a una variable.
De este modo, podremos usar el valor más adelante en el código. En el escenario de los dados, asignamos
el valor devuelto de Random.Next() a la variable roll:
*/

int roll3 = dice.Next(1, 7);

//En algunos casos querremos usar el valor devuelto directamente, sin asignarlo a una variable.
//Por ejemplo, que deseemos imprimir el valor devuelto en la consola de la siguiente manera:

Console.WriteLine(dice.Next(1, 7));

//Aunque un método devuelve un valor, podemos llamarlo sin usar el valor devuelto.
//Por ejemplo, podemos omitir el valor devuelto si llamamos al método de la siguiente manera:

dice.Next(1, 7);

//Sin embargo, omitir el valor devuelto sería inútil. El motivo por el que llamamos al método Next() es que
//podamos recuperar el siguiente valor aleatorio.


/*                                          Parametros de entrada

La información que consume un método se conoce como parámetro. Un método puede usar uno o varios parámetros para
realizar su tarea o ninguno en absoluto.

NOTA: Los términos "parámetro" y "volumen" se suelen usar indistintamente. Sin embargo, "parámetro" hace referencia a la variable que se usa dentro del método.
El "argumento" es el valor que se pasa cuando se llama al método.

La mayoría de los métodos están diseñados para aceptar uno o más parámetros de entrada. Los parámetros de entrada
sirven para configurar el modo en que el método realiza su trabajo, pero también se puede trabajar sobre ellos
directamente. Por ejemplo, el método Random.Next() usa parámetros de entrada para configurar los límites superior
e inferior del valor devuelto. Sin embargo, Console.WriteLine() imprime el valor en la consola, por lo que usa el parámetro de entrada directamente.

Los métodos usan una firma de método para definir el número de parámetros de entrada necesarios y el tipo de datos de cada parámetro.
Considere el uso de parámetros de entrada en el código siguiente:
*/
Random dice6 = new Random();
int roll4 = dice.Next(1, 7);
Console.WriteLine(roll);

/*
Este código crea una instancia de la clase Random denominada dice. A continuación, usa dice.Next(1, 7) para asignar
un valor aleatorio a un entero denominado roll. En este caso, el método Next() acepta dos parámetros, que se usan
para configurar los límites inferior y superior del nuevo número aleatorio. Observe que los argumentos están separados
por un símbolo ,. Por último, usa el método Console.WriteLine() para imprimir el valor de roll en la consola.
En este caso, ambos métodos usan parámetros de entrada.

Los métodos definen parámetros de entrada mediante un tipo de datos. No podemos pasar argumentos de un tipo de datos
distinto como parámetros de entrada al método y esperar que el método funcione. Si lo hemos intentado, el compilador
de C# habrá detectado el error y forzado la modificación del código antes de su compilación y ejecución. C# y .NET 
usan la comprobación de tipos para evitar que los usuarios finales experimenten errores en tiempo de ejecución.
*/




/*                                              Métodos sobrecargados
Muchos métodos de la biblioteca de clases .NET tienen firmas de método sobrecargadas. Entre otras cosas, 
esto nos permite llamar al método con o sin parámetros.

Un método sobrecargado se define con varias firmas de método. Los métodos sobrecargados proporcionan diferentes
maneras de llamar al método o proporcionan distintos tipos de datos.

En algunos casos, se usan versiones sobrecargadas de un método para aceptar un parámetro de entrada mediante
diferentes tipos de datos. Por ejemplo, el método Console.WriteLine() tiene 19 versiones sobrecargadas diferentes.
La mayoría de esas sobrecargas permiten al método aceptar diferentes tipos y escribir la información especificada en
la consola. Tenga en cuenta el código siguiente:

*/

int number = 7;
string text = "seven";

Console.WriteLine(number);
Console.WriteLine();
Console.WriteLine(text);

/*
En este ejemplo, está invocando tres versiones sobrecargadas independientes del método WriteLine().
    * El primer método WriteLine() usa una firma de método que acepta un parámetro int.
    * El segundo método WriteLine() usa una firma de método que acepta cero parámetros de entrada.
    * El tercer método WriteLine() usa una firma de método que acepta un parámetro string.

En otros casos, las versiones sobrecargadas de un método aceptan un número diferente de parámetros de entrada.
Se pueden usar parámetros de entrada alternativos para más control sobre el resultado deseado. Por ejemplo, 
el método Random.Next() tiene tres versiones sobrecargadas diferentes. Las tres versiones nos permiten establecer
varios niveles de restricción en el número generado aleatoriamente. 


Ya hemos examinado varios temas en esta unidad. Esta es una lista rápida de lo que hemos tratado:

    * Hemos examinado cómo usar el valor devuelto de un método (cuando el método lo proporciona).
    * Hemos examinado cómo un método puede usar parámetros de entrada definidos como tipos de datos específicos.
    * Hemos examinado las versiones sobrecargadas de algunos métodos que incluyen distintos parámetros de entrada o tipos de parámetros.
    
*/



/*        Ejercicio: Completar una actividad de desafío para detectar e implementar una llamada de método

Los desafíos de código le permiten reforzar lo que ha aprendido y le ayudan a tener más confianza antes de continuar.

Desafío de los métodos de la clase Math

En este desafío, usará IntelliSense o learn.microsoft.com para buscar y llamar a un método que devuelva el mayor de dos números.

Estos son los requisitos del desafío:

Asegúrese de que tiene un archivo Program.cs vacío abierto en Visual Studio Code.

Escriba el siguiente código como punto de partida del desafío.


*/


int firstValue = 500;
int secondValue = 600;
int largerValue;

largerValue = System.Math.Max(firstValue, secondValue);

Console.WriteLine("Desafío 1, Metodos = " + largerValue);

/*
3. Busque un método de la clase System.Math que devuelva el mayor de dos números.

   Puede usar "IntelliSense" en Visual Studio Code o learn.microsoft.com para buscar el método y determinar cómo llamarlo correctamente.
4. Use el método que encontró para asignar un valor a la variable denominada largerValue.

   Debe poder pasar los dos valores enteros, firstValue y secondValue, al método que encontró. 
   El método debe devolver un valor de tipo int que represente el mayor de los dos argumentos que ha pasado.

   Puede asignar el valor devuelto a largerValue en una nueva línea de código o en la línea de código existente que se usa para declarar largerValue.


NOTA: La solución final de este desafío debe usar este código y debe usar la 
      instrucción Console.WriteLine(largerValue); para generar la salida.
*/