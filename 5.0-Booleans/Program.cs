/*
Ejercicio: Evaluación de una expresión

La lógica de decisión se usa para establecer rutas alternativas mediante código, donde la decisión sobre qué ruta
de acceso seguir se basa en la evaluación de una expresión. Por ejemplo, puede escribir código que ejecute una de 
las dos rutas de acceso en función de una entrada de usuario. Si el usuario escribe la letra "a", el código
ejecutará un bloque de código. Si escribe la letra "b", el código ejecutará un bloque de código diferente. 
En este ejemplo, va a controlar la ruta de acceso de ejecución en función del valor asignado a una cadena. 
El código selecciona una ruta de acceso de ejecución basada en una expresión, cómo se evalúa esa expresión y la 
lógica subyacente que se utiliza para definir las rutas de acceso.

Examinar cómo construir y evaluar una expresión es un buen punto de partida

if (myName == "Luiz")

Es posible que haya pensado que el valor devuelto por una expresión sería un número o quizá una cadena. Es cierto
que los desarrolladores de aplicaciones usan diferentes tipos de expresiones para distintos propósitos. En este caso,
al desarrollar una instrucción de selección if, usará una expresión que devuelva true o false. Los desarrolladores
se refieren a este tipo de expresión como una expresión booleana. Cuando el código incluye una expresión booleana, 
el valor devuelto siempre es un valor único true o false.

Las expresiones booleanas son importantes porque el código puede utilizar estas expresiones para decidir qué bloque
de código se va a ejecutar.

Hay muchos tipos diferentes de operadores que se pueden usar dentro de una expresión booleana. Por ejemplo,
la instrucción if anterior usa el operador de igualdad == para comprobar si a una variable de cadena se le asigna un
valor determinado. El operador que elija dependerá de las rutas de acceso de código disponibles, las condiciones
asociadas a las rutas de acceso y la lógica de aplicación subyacente.



                                            Evaluación de igualdad y desigualdad
Una de las evaluaciones de código más comunes es una comprobación para ver si dos valores son iguales. Al comprobar
la igualdad, buscará el operador de igualdad == entre los dos valores que se están comprobando. Si los valores de
cada lado del operador de igualdad son equivalentes, la expresión devuelve true. De lo contrario, devuelve false.

Por el contrario, es posible que también tenga que comprobar si dos valores no son iguales. Para comprobar la
desigualdad, usará el operador de desigualdad != entre los dos valores.

Es posible que se pregunte por qué se necesitan operadores de igualdad y desigualdad. El motivo le va a quedar más
claro cuando aprenda a crear instrucciones de bifurcación y comience a escribir código real. Dos operadores que
realizan tareas opuestas permiten ser más expresivo y compacto.

Ahora es el momento de preparar el entorno de codificación y comenzar a escribir código que evalúe expresiones booleanas.


En el Editor de Visual Studio Code, escriba el código siguiente.
*/

Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a");

/*

Debería ver la siguiente salida.
True
False
False
True


Mejora de la comprobación de la igualdad entre cadenas mediante métodos auxiliares integrados de la cadena
Es posible que le sorprenda que la línea Console.WriteLine("a" == "A"); genere false. Al comparar cadenas, el uso 
de mayúsculas y minúsculas importa.

Además, observe esta línea de código:
Console.WriteLine("a" == "a ");
Aquí ha añadido un carácter de espacio al final de la cadena. Esta expresión también generará false.

En algunos casos, tener un carácter de espacio antes o después del texto podría ser perfectamente aceptable.
Pero si necesita aceptar una coincidencia que no sea exacta, puede "manipular" primero los datos. "Manipular"
los datos significa que realiza alguna limpieza antes de llevar a cabo una comparación de igualdad.

Por ejemplo, considere el caso en el que se esté recopilando la entrada de usuario dentro de un bucle. 
Después de escribir cada valor, puede proporcionar al usuario un mensaje para determinar si desea continuar,
como Do you want to continue (Y/N)?. Si el usuario quiere continuar, es probable que escriba y o Y. Querrá que 
el código interprete ambos valores igual, aunque y no sea equivalente a Y.

Antes de comprobar la igualdad de dos valores de cadena, especialmente cuando un usuario 
ha escrito uno o ambos valores, debe:

Asegurarse de que ambas cadenas estén en su totalidad en mayúsculas o en minúsculas con el método auxiliar 
ToUpper() o ToLower() en cualquier valor de cadena.
Quitar los espacios en blanco iniciales o finales con el método auxiliar Trim() en cualquier valor de cadena.
Puede mejorar la comprobación de igualdad anterior encadenando estos dos métodos de ayuda en ambos valores,
tal como se muestra en el siguiente listado de código:
*/

string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());


/*
Uso del operador de negación lógica
El término "Negación lógica" hace referencia al operador unario de negación !. Algunas personas llaman a este 
operador el "operador not". Cuando coloca el operador ! antes de una expresión condicional (o cualquier código
que se evalúe como true o false), obliga al código a invertir la evaluación del operando. Cuando se aplica la 
negación lógica, la evaluación genera true, si el operando se evalúa como false, y false, si el operando se
evalúa como true.

Este es un ejemplo que puede ayudarle a ver la conexión entre estas ideas. Las dos líneas de código siguientes
producen el mismo resultado. La segunda línea es más compacta.




*/
// These two lines of code will create the same output


/*
                                Ejercicio: Implementación del operador condicional
Imagine que necesita determinar rápidamente si la compra de un cliente es válida para un descuento promocional. 
Los detalles de la promoción indican que cuando un valor de compra es mayor que 1000 USD, la compra es apta para 
un descuento de 100 USD. Si el importe de la compra es de 1000 USD o menos, la compra es apta para un descuento 
de 50 USD.

Aunque ciertamente podría usar la construcción de bifurcación if ... elseif ... else para expresar esta regla de
negocio, el uso del operador condicional para evaluar la aptitud para el descuento promocional puede ser una mejor 
opción. El operador condicional usa un formato compacto que guarda algunas líneas de código y, posiblemente, aclara 
la intención del código.

                                ¿Qué es el operador condicional?

El operador condicional?: evalúa una expresión booleana y devuelve uno de los dos resultados, en función de si
la expresión booleana es true o false. El operador condicional se conoce normalmente como operador condicional 
ternario.

<evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>


Dedíquele un minuto a considerar cómo aplicar el operador condicional al escenario del descuento promocional. 
El objetivo es mostrar un mensaje al cliente en el que se indique su porcentaje de descuento. El importe de su 
descuento debe basarse en si han gastado más de 1000 USD en su compra.
*/


int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"The Discount is: {discount}");
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

