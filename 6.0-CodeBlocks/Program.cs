/*
INTRODUCCION:
Las instrucciones de selección e iteración usan bloques de código para agrupar las líneas de código que se deben
ejecutar, omitir o recorrer en iteración. Pero no es su única finalidad. También se pueden usar bloques de código
para controlar o limitar la accesibilidad a las variables. El "ámbito" de la variable hace referencia a la parte
de una aplicación donde se puede acceder a una variable. Comprender cómo un bloque de código afecta al ámbito de
una variable es una parte importante de la programación.

Supongamos que trabaja en una aplicación grande que usa instrucciones de iteración y selección anidadas para procesar
datos de matriz. La aplicación usa variables para ayudar a realizar tareas comunes en toda la aplicación.
Algunas variables tienen la misma finalidad en diferentes partes de la aplicación, y ha intentado reutilizar 
los nombres de variable. A medida que crece la aplicación, empieza a ver resultados inesperados en los cálculos y
errores que notifican que una variable no se ha inicializado o no existe. Debe mejorar el enfoque que usa para declarar
y acceder a las variables, y debe mejorar la comprensión del ámbito de las variables.

En este módulo, declarará variables para su uso dentro y fuera de los límites de los bloques de código.
Eliminará los bloques de código en determinadas situaciones para que el código sea más legible. Aprenderá cómo afectan
los bloques de código a la accesibilidad y la visibilidad de las variables.

Al final de este módulo, podrá usar los bloques de código con mayor confianza y comprenderá cómo influyen
en la visibilidad y la accesibilidad del código.


Ejercicio: Los bloques de código y el ámbito de las variables
Un bloque de código es una o varias instrucciones de C# que definen una ruta de acceso de ejecución. Las instrucciones 
fuera del bloque de código influyen en cómo, en qué casos y con qué frecuencia se ejecuta ese bloque de código en tiempo 
de ejecución. Los límites de un bloque de código normalmente se definen mediante corchetes, {}.

Además de su efecto en la ruta de acceso de ejecución, los bloques de código también pueden afectar al ámbito de las variables.
Los ejemplos de código que examine durante este ejercicio le ayudarán a comprender la relación entre los bloques de código y el
ámbito de variable.

Los bloques de código afectan al ámbito de las declaraciones de variable
El ámbito de variable hace referencia a la visibilidad de una variable para el código restante de la aplicación. Una variable de
ámbito local solo es accesible dentro del bloque de código en el que está definida. Si intenta acceder a la variable fuera del
bloque de código, recibirá un error del compilador.

El resto de esta unidad explora la relación entre los bloques de código y el ámbito de variable.

*/

bool flag = true;
if (flag)
{
    int value2 = 10;
    Console.WriteLine($"Inside the code block: {value2}");
}



//Intentaremos ultilizar la variable value desde fuera del bloque
//Console.WriteLine($"Outside the code block: {value}");
//como podemos observar obtenemos un error.

int value;
value = 10;

//ahora que ya declaramos value si podemos acceder desde fuera del bloque
Console.WriteLine($"Outside the code block: {value}");

//ahora tendremos o que actualizar el valor dentro del bloque a value = 10 en lugar de
// int value = 10, o podemos cambiar el nombre de value a value 2.

