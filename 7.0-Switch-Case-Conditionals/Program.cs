
/*

                                Ejercicio: Implementacion de una shitch.

Una instrucción switch es una instrucción de selección de C# que proporciona una alternativa a una construcción de bifurcación if-elseif-else. La instrucción switch proporciona ventajas sobre una construcción if-elseif-else al evaluar un valor único en una lista de valores coincidentes conocidos.

Considere el caso siguiente:

Está trabajando en una aplicación relacionada con la nutrición alimentaria. Una sección del código se ocupa 
de las frutas.El código incluye una variable denominada fruit que se usa para contener el nombre de diferentes 
tipos de fruta.
Dispone de una lista de 20 frutas en las que se centra la aplicación.
Quiere bifurcar el código en función del valor asignado a fruit.
En este escenario, puede usar una instrucción switch para crear una rama independiente para cada tipo de fruta.



                                ¿Cómo funciona una instrucción switch?

La instrucción switch elige una sección de código que se va a ejecutar en una lista de posibles secciones switch.
La sección switch seleccionada se elige en función de una coincidencia de patrón con la expresión de coincidencia
de la instrucción.

Un ejemplo sería:
switch (fruit)
{
    case "apple":
        Console.WriteLine($"App will display information for apple.");
        break;

    case "banana":
        Console.WriteLine($"App will display information for banana.");
        break;

    case "cherry":
        Console.WriteLine($"App will display information for cherry.");
        break;
}



La expresión match (que también se puede denominar expresión switch) es el valor que sigue a la palabra clave
switch, en este caso (fruit). Cada sección switch se define mediante un patrón de caso. Los patrones de caso se
construyen mediante la palabra clave case seguida de un valor. El primer patrón de caso de este ejemplo es case
"apple":. Los patrones de caso son expresiones booleanas que se evalúan como true o false. Cada sección switch
incluye un pequeño número de líneas de código que se ejecutarán si el patrón de caso es una coincidencia para
la expresión match. En este ejemplo, si a fruit se le asigna un valor de "apple", el primer patrón de caso se 
evaluará como true y se ejecutará esa sección switch.

Una instrucción switch debe incluir al menos una sección switch, pero normalmente contendrá 
tres o más secciones switch.

Switch se aprovecha mejor cuando:

Dispone de un valor único (variable o expresión) que debe emparejar con muchos valores posibles.
Para cualquier coincidencia determinada, debe ejecutar un par de líneas de código como máximo.


*/

int employeeLevel = 200;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
        title = "Junior Associate";
        break;
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");


/*
                                Desafío de conversión de instrucciones a switch.
En este desafío reescribiremos una construcción if-elseif-else como instrucción switch. Este desafío nos ayudará 
a ver las ventajas y los inconvenientes de usar la instrucción switch en comparación con una construcción 
if-elseif-else.

            Desafío de código: Reescritura de if-elseif-else mediante una instrucción switch.
Comenzaremos con el código que usa una construcción if-elseif-else para evaluar los componentes de una SKU de 
producto. 

La SKU (referencia de almacén) tiene el formato de tres valores codificados:
<product #>-<2-letter color code>-<size code>.

Por ejemplo, un valor de SKU de 01-MN-L corresponde a (sweat shirt)-(maroon)-(large) y el código genera una
descripción que aparece como "Product: Large Maroon Sweat shirt".

El desafío es convertir el código de la instrucción if en una instrucción switch que logre el mismo resultado 
que el código inicial.

*/

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

if (product[0] == "01")
{
    type = "Sweat shirt";
}
else if (product[0] == "02")
{
    type = "T-Shirt";
}
else if (product[0] == "03")
{
    type = "Sweat pants";
}
else
{
    type = "Other";
}

if (product[1] == "BL")
{
    color = "Black";
}
else if (product[1] == "MN")
{
    color = "Maroon";
}
else
{
    color = "White";
}

if (product[2] == "S")
{
    size = "Small";
}
else if (product[2] == "M")
{
    size = "Medium";
}
else if (product[2] == "L")
{
    size = "Large";
}
else
{
    size = "One Size Fits All";
}

Console.WriteLine($"Product: {size} {color} {type}");



//Resolución:


switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;
    case "02":
        type = "T-Shirt";
        break;
    case "03":
        type = "Sweat pants";
        break;
    default:
        type = "Other";
        break;
}

switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";
        break;
}

switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size Fits All";
        break;
}

Console.WriteLine($"Product: {size} {color} {type}");

