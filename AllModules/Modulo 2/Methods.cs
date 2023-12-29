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